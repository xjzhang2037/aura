﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aura.World.World;
using Aura.World.Network;
using Aura.Shared.Network;
using Aura.Shared.Util;
using Aura.Shared.Const;

namespace Aura.World.Skills
{
	[SkillAttr(SkillConst.MeleeCounterattack)]
	public class CounterHandler : SkillHandler
	{
		private const ushort StunTime = 3000;

		public override SkillResults Prepare(MabiCreature creature, MabiSkill skill, MabiPacket packet, uint castTime)
		{
			Send.Flash(creature);
			Send.SkillPrepare(creature.Client, creature, skill.Id, castTime);

			return SkillResults.Okay;
		}

		public override SkillResults Ready(MabiCreature creature, MabiSkill skill)
		{
			Send.SkillReady(creature.Client, creature, skill.Id);

			return SkillResults.Okay;
		}

		public override SkillResults Complete(MabiCreature creature, MabiSkill skill, MabiPacket packet)
		{
			Send.SkillComplete(creature.Client, creature, skill.Id);

			return SkillResults.Okay;
		}

		public override SkillResults UseCombat(MabiCreature attacker, ulong targetId, MabiSkill skill)
		{
			var target = WorldManager.Instance.GetCreatureById(targetId);
			if (target == null)
				return SkillResults.InvalidTarget;

			var sAction = new AttackerAction(CombatActionType.HardHit, attacker, skill.Id, targetId);
			sAction.Options |= AttackerOptions.Result;

			var tAction = new TargetAction(CombatActionType.CounteredHit, target, attacker, skill.Id);
			tAction.Options |= TargetOptions.Result | TargetOptions.KnockDown;

			var cap = new CombatActionPack(attacker, skill.Id);
			cap.Add(sAction, tAction);

			var damage =
				(attacker.GetRndTotalDamage() * (skill.RankInfo.Var2 / 100f)) +
				(target.GetRndTotalDamage() * (skill.RankInfo.Var1 / 100f));

			if (CombatHelper.TryAddCritical(attacker, ref damage, (target.CriticalChanceAgainst(attacker) + skill.RankInfo.Var3)))
				tAction.Options |= TargetOptions.Critical;

			CombatHelper.ReduceDamage(ref damage, target.DefenseTotal, target.Protection);

			target.TakeDamage(tAction.Damage = damage);

			if (target.IsDead)
				tAction.Options |= TargetOptions.FinishingKnockDown;

			attacker.Stun = sAction.StunTime = StunTime;
			target.Stun = tAction.StunTime = StunTime;

			tAction.OldPosition = CombatHelper.KnockBack(target, attacker);

			WorldManager.Instance.HandleCombatActionPack(cap);

			Send.SkillUse(attacker.Client, attacker, skill.Id, StunTime, 1);

			SkillHelper.GiveSkillExp(attacker, skill, 20);

			return SkillResults.Okay;
		}
	}
}
