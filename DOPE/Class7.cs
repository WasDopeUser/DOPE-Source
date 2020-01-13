using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

[DebuggerNonUserCode]
[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
internal static class Class7
{
	// Note: this type is marked as 'beforefieldinit'.
	static Class7()
	{
		Class13.tMHx78BzgCM8j();
		Class7.propertyChangedEventArgs_0 = new PropertyChangedEventArgs("AttackConfig");
		Class7.propertyChangedEventArgs_1 = new PropertyChangedEventArgs("AttackFormation");
		Class7.propertyChangedEventArgs_2 = new PropertyChangedEventArgs("AutoRefine");
		Class7.propertyChangedEventArgs_3 = new PropertyChangedEventArgs("Autostart");
		Class7.propertyChangedEventArgs_4 = new PropertyChangedEventArgs("BotControlState");
		Class7.propertyChangedEventArgs_5 = new PropertyChangedEventArgs("BotId");
		Class7.BotName = new PropertyChangedEventArgs("BotName");
		Class7.propertyChangedEventArgs_6 = new PropertyChangedEventArgs("BotStateName");
		Class7.Boxes = new PropertyChangedEventArgs("Boxes");
		Class7.BoxStats = new PropertyChangedEventArgs("BoxStats");
		Class7.propertyChangedEventArgs_7 = new PropertyChangedEventArgs("CircleNpcs");
		Class7.propertyChangedEventArgs_8 = new PropertyChangedEventArgs("CircleRange");
		Class7.propertyChangedEventArgs_9 = new PropertyChangedEventArgs("Cloak");
		Class7.propertyChangedEventArgs_10 = new PropertyChangedEventArgs("CollectBonus");
		Class7.propertyChangedEventArgs_11 = new PropertyChangedEventArgs("CollectCargo");
		Class7.propertyChangedEventArgs_12 = new PropertyChangedEventArgs("CollectGoldBooty");
		Class7.propertyChangedEventArgs_13 = new PropertyChangedEventArgs("CollectGreenBooty");
		Class7.propertyChangedEventArgs_14 = new PropertyChangedEventArgs("CollectMaterials");
		Class7.propertyChangedEventArgs_15 = new PropertyChangedEventArgs("Collector");
		Class7.propertyChangedEventArgs_16 = new PropertyChangedEventArgs("CollectPalladium");
		Class7.Config = new PropertyChangedEventArgs("Config");
		Class7.Deaths = new PropertyChangedEventArgs("Deaths");
		Class7.DeathStats = new PropertyChangedEventArgs("DeathStats");
		Class7.propertyChangedEventArgs_17 = new PropertyChangedEventArgs("DefaultHellstorm");
		Class7.propertyChangedEventArgs_18 = new PropertyChangedEventArgs("DefaultLaser");
		Class7.propertyChangedEventArgs_19 = new PropertyChangedEventArgs("DefaultRocket");
		Class7.propertyChangedEventArgs_20 = new PropertyChangedEventArgs("DroneFormation");
		Class7.EarnedCredits = new PropertyChangedEventArgs("EarnedCredits");
		Class7.EarnedEnergy = new PropertyChangedEventArgs("EarnedEnergy");
		Class7.EarnedExp = new PropertyChangedEventArgs("EarnedExp");
		Class7.EarnedHonor = new PropertyChangedEventArgs("EarnedHonor");
		Class7.propertyChangedEventArgs_21 = new PropertyChangedEventArgs("EarnedJackpot");
		Class7.propertyChangedEventArgs_22 = new PropertyChangedEventArgs("EarnedSAB");
		Class7.EarnedUridium = new PropertyChangedEventArgs("EarnedUridium");
		Class7.propertyChangedEventArgs_23 = new PropertyChangedEventArgs("EarnedX1");
		Class7.propertyChangedEventArgs_24 = new PropertyChangedEventArgs("EarnedX2");
		Class7.propertyChangedEventArgs_25 = new PropertyChangedEventArgs("EarnedX3");
		Class7.propertyChangedEventArgs_26 = new PropertyChangedEventArgs("EarnedX4");
		Class7.Enabled = new PropertyChangedEventArgs("Enabled");
		Class7.propertyChangedEventArgs_27 = new PropertyChangedEventArgs("EnableTimeTable");
		Class7.propertyChangedEventArgs_28 = new PropertyChangedEventArgs("First");
		Class7.propertyChangedEventArgs_29 = new PropertyChangedEventArgs("FleeConfig");
		Class7.propertyChangedEventArgs_30 = new PropertyChangedEventArgs("FleeFormation");
		Class7.propertyChangedEventArgs_31 = new PropertyChangedEventArgs("FleeFromEnemyAttacker");
		Class7.propertyChangedEventArgs_32 = new PropertyChangedEventArgs("FleeFromEnemySeen");
		Class7.propertyChangedEventArgs_33 = new PropertyChangedEventArgs("FleeOnlyFromKnownEnemySeen");
		Class7.propertyChangedEventArgs_34 = new PropertyChangedEventArgs("FleeStopOnEnemyLost");
		Class7.propertyChangedEventArgs_35 = new PropertyChangedEventArgs("FleeTimeout");
		Class7.propertyChangedEventArgs_36 = new PropertyChangedEventArgs("FlyingConfig");
		Class7.propertyChangedEventArgs_37 = new PropertyChangedEventArgs("FlyingFormation");
		Class7.propertyChangedEventArgs_38 = new PropertyChangedEventArgs("GG_ChaseFleeing");
		Class7.propertyChangedEventArgs_39 = new PropertyChangedEventArgs("GG_DragNpcs");
		Class7.propertyChangedEventArgs_40 = new PropertyChangedEventArgs("GG_UseKamikazeCorner");
		Class7.propertyChangedEventArgs_41 = new PropertyChangedEventArgs("GgCornerLaser");
		Class7.GgStats = new PropertyChangedEventArgs("GgStats");
		Class7.Group = new PropertyChangedEventArgs("Group");
		Class7.propertyChangedEventArgs_42 = new PropertyChangedEventArgs("GroupAttackMode");
		Class7.propertyChangedEventArgs_43 = new PropertyChangedEventArgs("HangarDefault");
		Class7.propertyChangedEventArgs_44 = new PropertyChangedEventArgs("HangarPalladiumCollect");
		Class7.propertyChangedEventArgs_45 = new PropertyChangedEventArgs("HangarPalladiumSell");
		Class7.propertyChangedEventArgs_46 = new PropertyChangedEventArgs("HasLicense");
		Class7.propertyChangedEventArgs_47 = new PropertyChangedEventArgs("HasNextProfile");
		Class7.propertyChangedEventArgs_48 = new PropertyChangedEventArgs("Hellstorm");
		Class7.HeroStats = new PropertyChangedEventArgs("HeroStats");
		Class7.propertyChangedEventArgs_49 = new PropertyChangedEventArgs("Hunter");
		Class7.propertyChangedEventArgs_50 = new PropertyChangedEventArgs("IgnoreOwnership");
		Class7.propertyChangedEventArgs_51 = new PropertyChangedEventArgs("JumpGGLastLife");
		Class7.propertyChangedEventArgs_52 = new PropertyChangedEventArgs("KamikazeConfig");
		Class7.propertyChangedEventArgs_53 = new PropertyChangedEventArgs("KamikazeFormation");
		Class7.propertyChangedEventArgs_54 = new PropertyChangedEventArgs("Key");
		Class7.propertyChangedEventArgs_55 = new PropertyChangedEventArgs("Laser");
		Class7.propertyChangedEventArgs_56 = new PropertyChangedEventArgs("LastError");
		Class7.propertyChangedEventArgs_57 = new PropertyChangedEventArgs("MapCooldown");
		Class7.propertyChangedEventArgs_58 = new PropertyChangedEventArgs("MapDuration");
		Class7.MapName = new PropertyChangedEventArgs("MapName");
		Class7.propertyChangedEventArgs_59 = new PropertyChangedEventArgs("Maps");
		Class7.propertyChangedEventArgs_60 = new PropertyChangedEventArgs("MaxDeaths");
		Class7.propertyChangedEventArgs_61 = new PropertyChangedEventArgs("MinHealHp");
		Class7.propertyChangedEventArgs_62 = new PropertyChangedEventArgs("MinHp");
		Class7.propertyChangedEventArgs_63 = new PropertyChangedEventArgs("MinSabShield");
		Class7.propertyChangedEventArgs_64 = new PropertyChangedEventArgs("ModuleType");
		Class7.Name = new PropertyChangedEventArgs("Name");
		Class7.propertyChangedEventArgs_65 = new PropertyChangedEventArgs("NextProfileName");
		Class7.propertyChangedEventArgs_66 = new PropertyChangedEventArgs("NpcId");
		Class7.NpcStats = new PropertyChangedEventArgs("NpcStats");
		Class7.propertyChangedEventArgs_67 = new PropertyChangedEventArgs("NpcWhitelist");
		Class7.propertyChangedEventArgs_68 = new PropertyChangedEventArgs("Order");
		Class7.propertyChangedEventArgs_69 = new PropertyChangedEventArgs("PalladiumCollectionAreaWidth");
		Class7.propertyChangedEventArgs_70 = new PropertyChangedEventArgs("Password");
		Class7.propertyChangedEventArgs_71 = new PropertyChangedEventArgs("PetDeaths");
		Class7.propertyChangedEventArgs_72 = new PropertyChangedEventArgs("PetMode");
		Class7.PetStats = new PropertyChangedEventArgs("PetStats");
		Class7.propertyChangedEventArgs_73 = new PropertyChangedEventArgs("Priority");
		Class7.propertyChangedEventArgs_74 = new PropertyChangedEventArgs("ProfileName");
		Class7.propertyChangedEventArgs_75 = new PropertyChangedEventArgs("ProxyString");
		Class7.propertyChangedEventArgs_76 = new PropertyChangedEventArgs("QZ_GroupSize");
		Class7.propertyChangedEventArgs_77 = new PropertyChangedEventArgs("RepairDrones");
		Class7.propertyChangedEventArgs_78 = new PropertyChangedEventArgs("Resets");
		Class7.propertyChangedEventArgs_79 = new PropertyChangedEventArgs("ReviveAtPortal");
		Class7.propertyChangedEventArgs_80 = new PropertyChangedEventArgs("Rocket");
		Class7.propertyChangedEventArgs_81 = new PropertyChangedEventArgs("SecondaryCircleNpcs");
		Class7.propertyChangedEventArgs_82 = new PropertyChangedEventArgs("Server");
		Class7.propertyChangedEventArgs_83 = new PropertyChangedEventArgs("SessionId");
		Class7.propertyChangedEventArgs_84 = new PropertyChangedEventArgs("Skylab_KeepPromerium");
		Class7.propertyChangedEventArgs_85 = new PropertyChangedEventArgs("Skylab_KeepSeprom");
		Class7.propertyChangedEventArgs_86 = new PropertyChangedEventArgs("Spinner_Alpha");
		Class7.propertyChangedEventArgs_87 = new PropertyChangedEventArgs("Spinner_Beta");
		Class7.propertyChangedEventArgs_88 = new PropertyChangedEventArgs("Spinner_Delta");
		Class7.propertyChangedEventArgs_89 = new PropertyChangedEventArgs("Spinner_Enabled");
		Class7.propertyChangedEventArgs_90 = new PropertyChangedEventArgs("Spinner_Epsilon");
		Class7.propertyChangedEventArgs_91 = new PropertyChangedEventArgs("Spinner_Gamma");
		Class7.propertyChangedEventArgs_92 = new PropertyChangedEventArgs("Spinner_Kappa");
		Class7.propertyChangedEventArgs_93 = new PropertyChangedEventArgs("Spinner_Kuiper");
		Class7.propertyChangedEventArgs_94 = new PropertyChangedEventArgs("Spinner_Lambda");
		Class7.propertyChangedEventArgs_95 = new PropertyChangedEventArgs("Spinner_PlaceGates");
		Class7.propertyChangedEventArgs_96 = new PropertyChangedEventArgs("Spinner_SpinDelay");
		Class7.propertyChangedEventArgs_97 = new PropertyChangedEventArgs("Spinner_SpinSize");
		Class7.propertyChangedEventArgs_98 = new PropertyChangedEventArgs("Spinner_StopABG");
		Class7.propertyChangedEventArgs_99 = new PropertyChangedEventArgs("Spinner_UsePhoenix");
		Class7.propertyChangedEventArgs_100 = new PropertyChangedEventArgs("Spinner_UseUridium");
		Class7.propertyChangedEventArgs_101 = new PropertyChangedEventArgs("Spinner_Zeta");
		Class7.Spins = new PropertyChangedEventArgs("Spins");
		Class7.propertyChangedEventArgs_102 = new PropertyChangedEventArgs("TargetMap");
		Class7.propertyChangedEventArgs_103 = new PropertyChangedEventArgs("TimeTable");
		Class7.propertyChangedEventArgs_104 = new PropertyChangedEventArgs("TimeTableActive");
		Class7.propertyChangedEventArgs_105 = new PropertyChangedEventArgs("TimeTableUseUtc");
		Class7.propertyChangedEventArgs_106 = new PropertyChangedEventArgs("Use3D");
		Class7.propertyChangedEventArgs_107 = new PropertyChangedEventArgs("UseKamikaze");
		Class7.propertyChangedEventArgs_108 = new PropertyChangedEventArgs("UseMothToKillCorners");
		Class7.propertyChangedEventArgs_109 = new PropertyChangedEventArgs("UseOffensiveAbility");
		Class7.propertyChangedEventArgs_110 = new PropertyChangedEventArgs("UsePetLocator");
		Class7.propertyChangedEventArgs_111 = new PropertyChangedEventArgs("UserAgent");
		Class7.propertyChangedEventArgs_112 = new PropertyChangedEventArgs("UserId");
		Class7.propertyChangedEventArgs_113 = new PropertyChangedEventArgs("Username");
		Class7.propertyChangedEventArgs_114 = new PropertyChangedEventArgs("UseRocketPrecision");
		Class7.propertyChangedEventArgs_115 = new PropertyChangedEventArgs("UseSab");
		Class7.Value = new PropertyChangedEventArgs("Value");
		Class7.propertyChangedEventArgs_116 = new PropertyChangedEventArgs("Volatile");
	}

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_0;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_1;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_2;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_3;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_4;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_5;

	internal static readonly PropertyChangedEventArgs BotName;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_6;

	internal static readonly PropertyChangedEventArgs Boxes;

	internal static readonly PropertyChangedEventArgs BoxStats;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_7;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_8;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_9;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_10;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_11;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_12;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_13;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_14;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_15;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_16;

	internal static readonly PropertyChangedEventArgs Config;

	internal static readonly PropertyChangedEventArgs Deaths;

	internal static readonly PropertyChangedEventArgs DeathStats;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_17;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_18;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_19;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_20;

	internal static readonly PropertyChangedEventArgs EarnedCredits;

	internal static readonly PropertyChangedEventArgs EarnedEnergy;

	internal static readonly PropertyChangedEventArgs EarnedExp;

	internal static readonly PropertyChangedEventArgs EarnedHonor;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_21;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_22;

	internal static readonly PropertyChangedEventArgs EarnedUridium;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_23;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_24;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_25;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_26;

	internal static readonly PropertyChangedEventArgs Enabled;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_27;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_28;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_29;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_30;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_31;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_32;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_33;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_34;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_35;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_36;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_37;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_38;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_39;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_40;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_41;

	internal static readonly PropertyChangedEventArgs GgStats;

	internal static readonly PropertyChangedEventArgs Group;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_42;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_43;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_44;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_45;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_46;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_47;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_48;

	internal static readonly PropertyChangedEventArgs HeroStats;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_49;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_50;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_51;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_52;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_53;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_54;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_55;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_56;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_57;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_58;

	internal static readonly PropertyChangedEventArgs MapName;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_59;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_60;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_61;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_62;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_63;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_64;

	internal static readonly PropertyChangedEventArgs Name;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_65;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_66;

	internal static readonly PropertyChangedEventArgs NpcStats;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_67;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_68;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_69;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_70;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_71;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_72;

	internal static readonly PropertyChangedEventArgs PetStats;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_73;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_74;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_75;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_76;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_77;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_78;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_79;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_80;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_81;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_82;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_83;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_84;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_85;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_86;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_87;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_88;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_89;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_90;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_91;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_92;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_93;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_94;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_95;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_96;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_97;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_98;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_99;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_100;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_101;

	internal static readonly PropertyChangedEventArgs Spins;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_102;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_103;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_104;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_105;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_106;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_107;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_108;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_109;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_110;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_111;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_112;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_113;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_114;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_115;

	internal static readonly PropertyChangedEventArgs Value;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_116;
}
