﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using System.Linq;

namespace Aura.Data
{
	public class SkillRankInfo
	{
		public ushort SkillId;
		public uint Race;
		public byte Rank;
		public byte Ap;
		public float Cp;
		public uint Range;
		public byte Stack, StackMax;
		public uint LoadTime, NewLoadTime, CoolDown;
		public float StaminaCost, StaminaPrepare, StaminaWait, StaminaUse;
		public float ManaCost, ManaPrepare, ManaWait, ManaUse;
		public float Life, Mana, Stamina, Str, Int, Dex, Will, Luck;
		public float LifeTotal, ManaTotal, StaminaTotal, StrTotal, IntTotal, DexTotal, WillTotal, LuckTotal;
		public float Var1, Var2, Var3, Var4, Var5, Var6, Var7, Var8, Var9;
	}

	public class SkillRankDb : DatabaseCSV<SkillRankInfo>
	{
		public override int Load(string path, bool clear)
		{
			var res = base.Load(path, clear);
			this.CalculateTotals();
			return res;
		}

		protected void CalculateTotals()
		{
			var skills = this.Entries.Select(c => c.SkillId).Distinct().ToList();

			foreach (var skillId in skills)
			{
				float lifeT = 0, manaT = 0, staminaT = 0, strT =0, intT = 0, dexT = 0, willT = 0, luckT = 0;

				for (byte i = 0; i <= 18; i++) // Novice -> D3
				{
					var sInfo = this.Find(skillId, i);

					if (sInfo != null)
					{
						sInfo.DexTotal = (dexT += sInfo.Dex);
						sInfo.IntTotal = (intT += sInfo.Int);
						sInfo.LifeTotal = (lifeT += sInfo.Life);
						sInfo.LuckTotal = (luckT += sInfo.Luck);
						sInfo.ManaTotal = (manaT += sInfo.Mana);
						sInfo.StaminaTotal = (staminaT += sInfo.Stamina);
						sInfo.StrTotal = (strT += sInfo.Str);
						sInfo.WillTotal = (willT += sInfo.Will);
					}
				}
			}
		}

		public SkillRankInfo Find(ushort id, byte rank)
		{
			return this.Entries.FirstOrDefault(a => a.SkillId == id && a.Rank == rank);
		}

		protected override void ReadEntry(CSVEntry entry)
		{
			if (entry.Count < 36)
				throw new FieldCountException(36);

			var info = new SkillRankInfo();
			info.SkillId = entry.ReadUShort();
			info.Race = entry.ReadUInt();
			info.Rank = entry.ReadUByte();
			info.Ap = entry.ReadUByte();
			info.Cp = entry.ReadFloat();
			info.Range = entry.ReadUInt();
			info.Stack = entry.ReadUByte();
			info.StackMax = entry.ReadUByte();
			info.LoadTime = entry.ReadUInt();
			info.NewLoadTime = entry.ReadUInt();
			info.CoolDown = entry.ReadUInt();
			info.StaminaCost = entry.ReadFloat();
			info.StaminaPrepare = entry.ReadFloat();
			info.StaminaWait = entry.ReadFloat();
			info.StaminaUse = entry.ReadFloat();
			info.ManaCost = entry.ReadFloat();
			info.ManaPrepare = entry.ReadFloat();
			info.ManaWait = entry.ReadFloat();
			info.ManaUse = entry.ReadFloat();
			info.Life = entry.ReadFloat();
			info.Mana = entry.ReadFloat();
			info.Stamina = entry.ReadFloat();
			info.Str = entry.ReadFloat();
			info.Int = entry.ReadFloat();
			info.Dex = entry.ReadFloat();
			info.Will = entry.ReadFloat();
			info.Luck = entry.ReadFloat();
			info.Var1 = entry.ReadFloat();
			info.Var2 = entry.ReadFloat();
			info.Var3 = entry.ReadFloat();
			info.Var4 = entry.ReadFloat();
			info.Var5 = entry.ReadFloat();
			info.Var6 = entry.ReadFloat();
			info.Var7 = entry.ReadFloat();
			info.Var8 = entry.ReadFloat();
			info.Var9 = entry.ReadFloat();

			this.Entries.Add(info);
		}
	}
}
