﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using System;

namespace Aura.Shared.Const
{
	[Flags]
	public enum CreatureStates : uint
	{
		Initialized = 0x00000001,
		Dead = 0x00000002,
		SitDown = 0x00000004,
		Spawned = 0x00000008,
		EverEnteredWorld = 0x00000010,
		NorespawnPenalty = 0x00000020,
		InventoryViewDisable = 0x00000080,
		PetFinishMode = 0x00000100,
		FreeRebirth = 0x00000200,
		JustRebirth = 0x00000400,
		LevelResetRebirth = 0x00000800,
		EnableCommonPvp = 0x00001000,
		JournalVisible = 0x00002000,
		TransformCutsceneSkip = 0x00004000,
		EscortNpc = 0x02000000,
		UntouchableNpc = 0x08000000,
		InstantNpc = 0x10000000,
		GoodNpc = 0x20000000,
		NamedNpc = 0x40000000,
		Npc = 0x80000000,
	}

	[Flags]
	public enum CreatureStatesEx : uint
	{
		DefenceBonus = 0x00000001,
		WhisperDisable = 0x00000002,
		FakeDeath = 0x00000004,
		Cloaking = 0x00000008,
		ThrowingStone = 0x00000010,
		SubRace = 0x00000020,
		NotDown = 0x00000040,
		NoHitDelay = 0x00000080,
		Hibernation = 0x00000100,
		SummonedByGiant = 0x00000200,
		DisableMeleeAttack = 0x00000400,
		SyncFrameworkEffect = 0x00000800,
		CloakingAfterRevival = 0x00001000,
		Bubble = 0x00002000,
		CaptureTheFlagMember = 0x00004000,
		CaptureTheFlagRedteam = 0x00008000,
		CaptureTheFlagHasflag = 0x00010000,
		CaptureTheFlagRedflag = 0x00020000,
		CaptureTheFlagFreezed = 0x00040000,
		WaterBalloonBattleMember = 0x00080000,
		WaterBalloonBattleRed = 0x00100000,
		WearShadowdungeonMask = 0x00400000,
		RoyalAlchemist = 0x00800000,
		TailingClaudius = 0x01000000,
		UseUmbrella = 0x02000000,
		ThrowingGold = 0x04000000,
		ZombieWalk = 0x08000000,
	}

	public enum Stat : byte
	{
		Name,
		Title,
		EngTitle,
		Type,
		SkinColor,
		EyeType,
		EyeColor,
		MouthType,
		State,
		StateEx,
		StateEx2, // [180300, NA166 (18.09.2013)]
		Height,
		Weight,
		Upper,
		Lower,
		RegionId,
		PositionX,
		PositionY,
		Direction,
		BattleState,
		WeaponSet,
		Extra1,
		Extra2,
		Extra3,
		CombatPower,
		MotionType,
		Life,
		LifeInjured,
		LifeMax,
		LifeMaxMod,
		Mana,
		ManaMax,
		ManaMaxMod,
		Stamina,
		StaminaMax,
		StaminaMaxMod,
		Food,
		FoodMinRatio,
		Level,
		LevelTotal,
		LevelMax,
		RebirthCount,
		LifeTimeSkill,
		Experience,
		Age,
		Str,
		StrMod,
		Dex,
		DexMod,
		Int,
		IntMod,
		Will,
		WillMod,
		Luck,
		LuckMod,
		LifeMaxByFood,
		ManaMaxByFood,
		StaminaMaxByFood,
		StrengthByFood,
		DexterityByFood,
		IntelligenceByFood,
		WillByFood,
		LuckByFood,
		AbilityPoints,
		AttackMinBase,
		AttackMinMod,
		AttackMaxBase,
		AttackMaxMod,
		WattackMinBase,
		WattackMinMod,
		WattackMaxBase,
		WattackMaxMod,
		LeftAttackMinMod,
		LeftAttackMaxMod,
		RightAttackMinMod,
		RightAttackMaxMod,
		LeftWattackMinMod,
		LeftWattackMaxMod,
		RightWattackMinMod,
		RightWattackMaxMod,
		LeftCriticalMod,
		RightCriticalMod,
		LeftRateMod,
		RightRateMod,
		MagicDefenseMod,
		MagicAttackMod,
		_UnkMagicProtectMod, // [180300, NA166 (18.09.2013)]
		MeleeAttackRateMod,
		RangeAttackRateMod,
		CriticalBase,
		CriticalMod,
		ProtectBase,
		ProtectMod,
		DefenseBase,
		DefenseMod,
		RateBase,
		RateMod,
		Rank1,
		Rank2,
		_UnkDefensePiercing, // [180300, NA166 (18.09.2013)]
		Score,
		AttackMinBaseMod,
		AttackMaxBaseMod,
		WattackMinBaseMod,
		WattackMaxBaseMod,
		CriticalBaseMod,
		ProtectBaseMod,
		DefenseBaseMod,
		RateBaseMod,
		MeleeAttackMinBaseMod,
		MeleeAttackMaxBaseMod,
		MeleeWattackMinBaseMod,
		MeleeWattackMaxBaseMod,
		RangeAttackMinBaseMod,
		RangeAttackMaxBaseMod,
		RangeWattackMinBaseMod,
		RangeWattackMaxBaseMod,
		PoisonBase,
		PoisonMod,
		PoisonImmuneBase,
		PoisonImmuneMod,
		_UnkDualgunA, // [180300, NA166 (18.09.2013)]
		_UnkDualgunB, // [180300, NA166 (18.09.2013)]
		_UnkDualgunC, // [180300, NA166 (18.09.2013)]
		_UnkDualgunD, // [180300, NA166 (18.09.2013)]
		PoisonDamageRatio1,
		PoisonDamageRatio2,
		EnchantCombatPowerMod,
		CumulateStr,
		CumulateDex,
		CumulateInt,
		CumulateWill,
		CumulateLuck,
		CumulateHeight,
		CumulateFatness,
		CumulateUpper,
		CumulateLower,
		CumulateLife,
		CumulateMana,
		CumulateStamina,
		Toxic,
		ToxicDrunkenTime,
		ToxicStr,
		ToxicInt,
		ToxicDex,
		ToxicWill,
		ToxicLuck,
		LastTown,
		LastDungeon,
		ExploLevel,
		ExploMaxKeyLevel,
		ExploCumLevel,
		ExploExp,
		DiscoverCount,
		ConditionStr,
		ConditionInt,
		ConditionDex,
		ConditionWill,
		ConditionLuck,
		ElementPhysical,
		ElementLightning,
		ElementFire,
		ElementIce,
		BareAttackMin,
		BareAttackMax,
		BareWattackMin,
		BareWattackMax,
		BareCritical,
		BareRate,
	}

	public enum CreatureConditionA : ulong
	{
		Poisoned = 0x0000000000000001,
		Deadly = 0x0000000000000002,
		PotionPoisoning = 0x0000000000000004,
		Numb = 0x0000000000000008,
		Silence = 0x0000000000000010,
		Petrified = 0x0000000000000020,
		Coward = 0x0000000000000040,
		Outraged = 0x0000000000000080,
		Confused = 0x0000000000000100,
		Combat2xExp = 0x0000000000000200,
		Slow = 0x0000000000000400,
		Luck = 0x0000000000000800,
		Misfortune = 0x0000000000001000,
		LeadersBlessing = 0x0000000000002000,
		Explode1 = 0x0000000000004000,
		Explode2 = 0x0000000000008000,
		Mirage = 0x0000000000010000,
		Weak = 0x0000000000020000,
		PVPPenalty = 0x0000000000040000,
		Lethargic = 0x0000000000080000,
		CancelDarkKnight = 0x0000000000100000,
		Camouflage = 0x0000000000200000,
		Blessed = 0x0000000000400000,
		Invisible = 0x0000000000800000,
		NoTrade = 0x0000000001000000,
		Following = 0x0000000002000000,
		ChatBanned = 0x0000000004000000,
		ViewCutScene = 0x0000000008000000,
		Ensemble = 0x0000000010000000,
		SharpAiming = 0x0000000020000000,
		FastCasting = 0x0000000040000000,
		Weaken = 0x0000000080000000,
		MushroomCookie = 0x0000000100000000,
		CryFood = 0x0000000200000000,
		CrazyFood = 0x0000000400000000,
		SelfPraiseFood = 0x0000000800000000,
		HeartFood = 0x0000001000000000,
		PoisonImmune = 0x0000002000000000,
		PetrificationImmunity = 0x0000004000000000,
		ManaUsageReduction = 0x0000008000000000,
		StaminaUsageReduction = 0x0000010000000000,
		ExplosiveImmunity = 0x0000020000000000,
		StompImmunity = 0x0000040000000000,
		ManaUsageIncrease = 0x0000080000000000,
		StaminaUsageIncrease = 0x0000100000000000,
		ShareFood = 0x0000200000000000,
		IceShield = 0x0000400000000000,
		FireShield = 0x0000800000000000,
		LightningShield = 0x0001000000000000,
		NaturalShield = 0x0002000000000000,
		MoveSlow = 0x0004000000000000,
		FastGathering = 0x0008000000000000,
		Charge = 0x0010000000000000,
		AttackSpeed = 0x0020000000000000,
		Moonlight = 0x0040000000000000,
		SulfurPoison = 0x0080000000000000,
		Burn = 0x0100000000000000,
		Freeze = 0x0200000000000000,
		StarFood = 0x0400000000000000,
		ManaShield = 0x0800000000000000,
		CherryTree = 0x1000000000000000,
		Boose = 0x2000000000000000,
		FastCasting2 = 0x4000000000000000,
		WeaponAttackBoost = 0x8000000000000000,
	}

	public enum CreatureConditionB : ulong
	{
		Transparent = 0x0000000000000001,
		CombatExpPlus1_1 = 0x0000000000000002,
		CombatExpPlus2 = 0x0000000000000004,
		Bewildered = 0x0000000000000008,
		ElephantShower = 0x0000000000000010,
		Curse = 0x0000000000000020,
		Blind = 0x0000000000000040,
		Ice = 0x0000000000000080,
		ProductionRateChange = 0x0000000000000100,
		ItemProfInc = 0x0000000000000200,
		AlchemyCloud = 0x0000000000000400,
		FailedBotCheck = 0x0000000000000800,
		SnowStorm = 0x0000000000001000,
		Doppelganger = 0x0000000000002000,
		Demigod = 0x0000000000004000,
		DoppelgangerLaugh = 0x0000000000008000,
		DoppelgangerPain = 0x0000000000010000,
		ValentineHappy = 0x0000000000020000,
		ValentineUnhappy = 0x0000000000040000,
		FashionShow = 0x0000000000080000,
		LargeUpper = 0x0000000000100000,
		DumbTalking = 0x0000000000200000,
		LargeLower = 0x0000000000400000,
		VeryBig = 0x0000000000800000,
		VerySmall = 0x0000000001000000,
		Blessed = 0x0000000002000000,
		Outraged = 0x0000000004000000,
		MiniPotion = 0x0000000008000000,
		NoConsume = 0x0000000010000000,
		StoneBarrier = 0x0000000020000000,
		Discharge = 0x0000000040000000,
		Stand = 0x0000000080000000,
		LifeExpInc = 0x0000000100000000,
		CombatExpInc = 0x0000000200000000,
		MagicExpInc = 0x0000000400000000,
		AlchemyExpInc = 0x0000000800000000,
		NameColorChange = 0x0000001000000000,
		TowerCylinder = 0x0000002000000000,
		DemiStrInc = 0x0000004000000000,
		DemiDexInc = 0x0000008000000000,
		DemiWillInc = 0x0000010000000000,
		DemiLuckInc = 0x0000020000000000,
		DemiIntInc = 0x0000040000000000,
		DemiFuryInc = 0x0000080000000000,
		DemiSpearInc = 0x0000100000000000,
		DemiShadowInc = 0x0000200000000000,
		DemiDurationInc = 0x0000400000000000,
		DemiCooldownDec = 0x0000800000000000,
		DemiBrionacDmgInc = 0x0001000000000000,
		DemiBrionacCritInc = 0x0002000000000000,
		BardInc = 0x0004000000000000,
		SpeedInc = 0x0008000000000000,
		DemiImmune = 0x0010000000000000,
		HeightChange = 0x0020000000000000,
		RavenAttack = 0x0040000000000000,
		NuadhaPhase = 0x0080000000000000,
		MountAttack = 0x0100000000000000,
		StatsDec = 0x0200000000000000,
		ShadowBonus = 0x0400000000000000,
		ItemDropInc = 0x0800000000000000,
		ItemDropInc2 = 0x1000000000000000,
		FishDropInc = 0x2000000000000000,
		FishDropInc2 = 0x4000000000000000,
		ChatColorChange = 0x8000000000000000,
	}

	public enum CreatureConditionC : ulong
	{
		CombatExpBoost = 0x0000000000000001,
		DamageCurse = 0x0000000000000002,
		Frenzy = 0x0000000000000004,
		NuadhaSet = 0x0000000000000008,
		TheatreDungeonSpotLight = 0x0000000000000010,
		HamelinContract = 0x0000000000000020,
		OutOfBody = 0x0000000000000040,
		SpiritClear = 0x0000000000000080,
		HandsFull = 0x0000000000000100,
		TrollRecorvery = 0x0000000000000200,
		SmashEnhancement = 0x0000000000000400,
		AssaultSlashEnhancement = 0x0000000000000800,
		ChargeEnhancement = 0x0000000000001000,
		IceBoltEnhancement = 0x0000000000002000,
		FireBoltEnhancement = 0x0000000000004000,
		HealingEnhancement = 0x0000000000008000,
		FlameBurstEnhancement = 0x0000000000010000,
		WaterCannonEnhancement = 0x0000000000020000,
		LifeDrainEnhancement = 0x0000000000040000,
		MagnumShotEnhancement = 0x0000000000080000,
		SupportShotEnhancement = 0x0000000000100000,
		FishingEnhancement = 0x0000000000200000,
		RefiningEnhancement = 0x0000000000400000,
		BlacksmithEnhancement = 0x0000000000800000,
		MetallurgyEnhancement = 0x0000000001000000,
		ArmorBearRoar = 0x0000000002000000,
		RosemaryGloves = 0x0000000004000000,
		FlyingPetBoost = 0x0000000008000000,
		ClaudiusPursuit = 0x0000000010000000,
		AnimalCharacterTrainingKit = 0x0000000020000000,
		AnimalCharacterTrainingBoost = 0x0000000040000000,
		FlyingAnimalCharacterTrainingBoost = 0x0000000080000000,
		TodayShadowMissionComplete = 0x0000000100000000,
		UpToLadeca = 0x0000000200000000,
		OXQuiz = 0x0000000400000000,
		PetLandBoost = 0x0000000800000000,
		CommerceTransport = 0x0000001000000000,
		WingsOfEclipse = 0x0000002000000000,
		WingsOfRage = 0x0000004000000000,
		StatusBuffPotion = 0x0000008000000000,
		PersonaSpeedUp = 0x0000010000000000,
		Hurry = 0x0000020000000000,
		WeaponSealRemoval = 0x0000040000000000,
		MiniCharacterSize = 0x0000080000000000,
		MetalwareMoveSpeedUp = 0x0000100000000000,
		MetalwareCommerceSpeedUp = 0x0000200000000000,
		FishingChair = 0x0000400000000000,
		CommerceWarranty = 0x0000800000000000,
		PotionBoost = 0x0001000000000000,
		MagicAttackEnhance = 0x0002000000000000,
		Zombie = 0x0004000000000000,
		MusicalPetrification = 0x0008000000000000,
		GoldStrikeEnhancement = 0x0010000000000000,
		OutlawPursuit = 0x0020000000000000,
		DefProtectDebuff = 0x0040000000000000,
		RespiteAftereffect = 0x0080000000000000,
		FastMove = 0x0100000000000000,
		Pinned = 0x0200000000000000,
		Dazed = 0x0400000000000000,
		MaritalPounding = 0x0800000000000000,
		MerrowsCurse = 0x1000000000000000,
		FighterSkillTrainingBoost = 0x2000000000000000,
		DekalFollow = 0x4000000000000000,
		BomberMan = 0x8000000000000000,
	}

	public enum CreatureConditionD : ulong
	{
		MusicOfHaste = 0x0000000000000001,
		MagicalMusic = 0x0000000000000002,
		MusicOfHarvest = 0x0000000000000004,
		MusicOfPeace = 0x0000000000000008,
		Batter = 0x0000000000000010,
		RescueRevive = 0x0000000000000020,
		CommerceTransportLock = 0x0000000000000040,
		MusicSkillExpBoost = 0x0000000000000080,
		MarionetteSkillExpBoost = 0x0000000000000100,
		FlameOfResurrection = 0x0000000000000200,
		WireBound = 0x0000000000000400,
		WireTangle = 0x0000000000000800,
		TheatreMissionCrystal = 0x0000000000001000,
		BountyHunter = 0x0000000000002000,
		MarionetteSpirit = 0x0000000000004000,
		ImmuneInterrupt = 0x0000000000008000,
		MarionetteSpiralBuff = 0x0000000000010000,
		SkillStun = 0x0000000000020000,
		FlameOfResurrectionEx = 0x0000000000040000,
		BoneDragonDevilRush = 0x0000000000080000,
		BoneDragonDevilCry = 0x0000000000100000,
		TransformationEnhancement = 0x0000000000200000,
		IncreaseDamage = 0x0000000000400000,
		DecreaseDamage = 0x0000000000800000,
		DecreaseDefenseProtection = 0x0000000001000000,
		DoubleCompleteSkillExp = 0x0000000002000000,
		WindmillEnhance = 0x0000000004000000,
		Tangled = 0x0000000008000000,
		BerserkArmor = 0x0000000010000000,
		RestfulWind = 0x0000000020000000,
		RestfulWindsEmbrace = 0x0000000040000000,
		IncreaseDefenseProtection = 0x0000000080000000,
		Steadfast = 0x0000000100000000,
		Absorbtion = 0x0000000200000000,
		QuestExpBonus = 0x0000000400000000,
		RaidCrystal = 0x0000000800000000,
		RaidBossDamageEnhance = 0x0000001000000000,
		DragonSummonBonus = 0x0000002000000000,
		WayOfTheGun = 0x0000004000000000,
		DualGunSkillExpBoost = 0x0000008000000000,
		SpreadWings = 0x0000010000000000,
		MeteorStrike = 0x0000020000000000,
		InstanceCasting = 0x0000040000000000,
		Frostbite = 0x0000080000000000,
		EnhancedAssaultSlash = 0x0000100000000000,
		EngineShocked = 0x0000200000000000,
		MusicChorus = 0x0000400000000000,
		MusicSongOfSigh = 0x0000800000000000,
		AlchemyElemental = 0x0001000000000000,
		GoldenTime = 0x0002000000000000,
		InstrumentInstalled = 0x0004000000000000,
		LifeSkillExpBoostToday = 0x0008000000000000,
		DoubleCombatExpToday = 0x0010000000000000,
		ShadowMissionBonusToday = 0x0020000000000000,
		AlchemyElementalSpark = 0x0040000000000000,
		AlchemyWindPassive = 0x0080000000000000,
		CurseofAbyss = 0x0200000000000000,
		DukeBleeding = 0x0400000000000000,
		DukeTemptation = 0x0800000000000000,
		EmergencyEscape = 0x1000000000000000,
		Clocking = 0x2000000000000000,
	}

	public struct CreatureCondition
	{
		public CreatureConditionA A;
		public CreatureConditionB B;
		public CreatureConditionC C;
		public CreatureConditionD D;

		public void Clear()
		{
			A = 0;
			B = 0;
			C = 0;
			D = 0;
		}
	}
}
