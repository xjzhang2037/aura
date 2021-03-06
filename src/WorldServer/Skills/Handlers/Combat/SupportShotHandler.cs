﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using Aura.Shared.Network;
using Aura.Shared.Util;
using Aura.World.Network;
using Aura.World.World;
using Aura.World.Events;
using Aura.Shared.Const;

namespace Aura.World.Skills
{
	[SkillAttr(SkillConst.SupportShot)]
	public class SupportShotHandler : SkillHandler
	{
		/// <summary>
		/// Stun time for attacker and target.
		/// </summary>
		private const ushort StunTime = 2600;
		private const ushort AfterUseStun = 600;

		public override SkillResults Prepare(MabiCreature creature, MabiSkill skill, MabiPacket packet, uint castTime)
		{
			Send.Flash(creature);
			Send.SkillPrepare(creature.Client, creature, skill.Id, castTime);

			return SkillResults.Okay;
		}

		public override SkillResults Ready(MabiCreature creature, MabiSkill skill)
		{
			if (creature.ActiveSkillStacks < 1)
			{
				SkillHelper.IncStack(creature, skill);
			}
			Send.SkillReady(creature.Client, creature, skill.Id);

			return SkillResults.Okay;
		}

		public override SkillResults Complete(MabiCreature creature, MabiSkill skill, MabiPacket packet)
		{
			creature.Client.Send(new MabiPacket(Op.CombatSetAimR, creature.Id).PutByte(0));

			Send.SkillComplete(creature.Client, creature, skill.Id);

			return SkillResults.Okay;
		}

		public override SkillResults Cancel(MabiCreature creature, MabiSkill skill)
		{
			if (creature.Target != null)
				creature.Client.Send(new MabiPacket(Op.CombatSetAimR, creature.Id).PutByte(0));

			Send.SkillUse(creature.Client, creature, skill.Id, AfterUseStun, 1);

			return SkillResults.Okay;
		}

		public override SkillResults UseCombat(MabiCreature attacker, ulong targetId, MabiSkill skill)
		{
			var target = WorldManager.Instance.GetCreatureById(targetId);
			if (target == null)
				return SkillResults.InvalidTarget;

			if (attacker.Magazine == null || attacker.Magazine.Count < 1)
				return SkillResults.Failure;

			var rnd = RandomProvider.Get();

			attacker.StopMove();

			var factory = new CombatFactory();
			factory.SetAttackerAction(attacker, CombatActionType.RangeHit, skill.Id, targetId);
			factory.SetAttackerOptions(AttackerOptions.Result);
			factory.SetAttackerStun(AfterUseStun);

			bool hit = false;

			if (attacker.GetAimPercent(attacker.Skills.Get(SkillConst.RangedCombatMastery).RankInfo.Var3) > rnd.NextDouble())
			{
				target.StopMove();

				factory.AddTargetAction(target, CombatActionType.TakeHit);
				factory.SetTargetOptions(TargetOptions.Result);
				factory.SetTargetStun(StunTime);

				hit = true;
			}
			else
			{
				factory.AddTargetAction(target, CombatActionType.None);
			}

			Send.SkillUse(attacker.Client, attacker, skill.Id, AfterUseStun, 1);

			SkillHelper.ClearStack(attacker, skill);

			attacker.Client.Send(new MabiPacket(Op.CombatTargetSet, attacker.Id).PutLong(0));

			factory.ExecuteDamage(new System.Func<MabiCreature, MabiCreature, float>((a, t) =>
				{
					var damage = attacker.GetRndRangeDamage();
					return damage * .8f;
				}));
			factory.ExecuteStun();
			factory.ExecuteKnockback(0f);

			WorldManager.Instance.HandleCombatActionPack(factory.GetCap());

			if (!target.IsDead && hit)
			{
				// TODO: debuff

				WorldManager.Instance.Broadcast(new MabiPacket(Op.Effect, target.Id).PutInt(Effect.SupportShot).PutByte(1), SendTargets.Range, target);

				System.Threading.Thread t = new System.Threading.Thread(() =>
				{
					System.Threading.Thread.Sleep(3000);
					WorldManager.Instance.Broadcast(new MabiPacket(Op.Effect, target.Id).PutInt(Effect.SupportShot).PutByte(0), SendTargets.Range, target);
				});

				t.Start();

				CombatHelper.SetAggro(attacker, target);
			}

			SkillHelper.GiveSkillExp(attacker, skill, 20);

			return SkillResults.Okay;
		}
	}
}
