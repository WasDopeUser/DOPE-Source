using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

[DebuggerNonUserCode]
[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
internal static class Class5
{
	// Note: this type is marked as 'beforefieldinit'.
	static Class5()
	{
		Class13.igxcIukzfpare();
		Class5.propertyChangedEventArgs_0 = new PropertyChangedEventArgs("Ammo");
		Class5.AmmoHS1 = new PropertyChangedEventArgs("AmmoHS1");
		Class5.AmmoR1 = new PropertyChangedEventArgs("AmmoR1");
		Class5.AmmoR2 = new PropertyChangedEventArgs("AmmoR2");
		Class5.AmmoR3 = new PropertyChangedEventArgs("AmmoR3");
		Class5.AmmoR4 = new PropertyChangedEventArgs("AmmoR4");
		Class5.AmmoX1 = new PropertyChangedEventArgs("AmmoX1");
		Class5.AmmoX2 = new PropertyChangedEventArgs("AmmoX2");
		Class5.AmmoX3 = new PropertyChangedEventArgs("AmmoX3");
		Class5.propertyChangedEventArgs_1 = new PropertyChangedEventArgs("AmmoX4");
		Class5.propertyChangedEventArgs_2 = new PropertyChangedEventArgs("Assets");
		Class5.propertyChangedEventArgs_3 = new PropertyChangedEventArgs("Battlestation");
		Class5.propertyChangedEventArgs_4 = new PropertyChangedEventArgs("BootyKeys");
		Class5.propertyChangedEventArgs_5 = new PropertyChangedEventArgs("CanKamikaze");
		Class5.propertyChangedEventArgs_6 = new PropertyChangedEventArgs("CargoCapacity");
		Class5.propertyChangedEventArgs_7 = new PropertyChangedEventArgs("CargoDisplay");
		Class5.Center = new PropertyChangedEventArgs("Center");
		Class5.propertyChangedEventArgs_8 = new PropertyChangedEventArgs("ClanDiplomacy");
		Class5.propertyChangedEventArgs_9 = new PropertyChangedEventArgs("ClanTag");
		Class5.propertyChangedEventArgs_10 = new PropertyChangedEventArgs("Cloaked");
		Class5.propertyChangedEventArgs_11 = new PropertyChangedEventArgs("Collectibles");
		Class5.propertyChangedEventArgs_12 = new PropertyChangedEventArgs("Collidables");
		Class5.Config = new PropertyChangedEventArgs("Config");
		Class5.Connection = new PropertyChangedEventArgs("Connection");
		Class5.propertyChangedEventArgs_13 = new PropertyChangedEventArgs("Cooldowns");
		Class5.Credits = new PropertyChangedEventArgs("Credits");
		Class5.propertyChangedEventArgs_14 = new PropertyChangedEventArgs("DefaultWorkArea");
		Class5.propertyChangedEventArgs_15 = new PropertyChangedEventArgs("Dope");
		Class5.propertyChangedEventArgs_16 = new PropertyChangedEventArgs("EnabledSince");
		Class5.propertyChangedEventArgs_17 = new PropertyChangedEventArgs("EnemyLocated");
		Class5.propertyChangedEventArgs_18 = new PropertyChangedEventArgs("Equipment");
		Class5.Experience = new PropertyChangedEventArgs("Experience");
		Class5.propertyChangedEventArgs_19 = new PropertyChangedEventArgs("FactionId");
		Class5.propertyChangedEventArgs_20 = new PropertyChangedEventArgs("ForcedUserAgent");
		Class5.propertyChangedEventArgs_21 = new PropertyChangedEventArgs("FreeCargo");
		Class5.propertyChangedEventArgs_22 = new PropertyChangedEventArgs("FrozenLabirynthClosing");
		Class5.propertyChangedEventArgs_23 = new PropertyChangedEventArgs("FrozenLabirynthOpening");
		Class5.propertyChangedEventArgs_24 = new PropertyChangedEventArgs("Fuel");
		Class5.Game = new PropertyChangedEventArgs("Game");
		Class5.propertyChangedEventArgs_25 = new PropertyChangedEventArgs("Gates");
		Class5.GG = new PropertyChangedEventArgs("GG");
		Class5.propertyChangedEventArgs_26 = new PropertyChangedEventArgs("GgInfo");
		Class5.propertyChangedEventArgs_27 = new PropertyChangedEventArgs("Grid");
		Class5.Group = new PropertyChangedEventArgs("Group");
		Class5.Hero = new PropertyChangedEventArgs("Hero");
		Class5.Honor = new PropertyChangedEventArgs("Honor");
		Class5.propertyChangedEventArgs_28 = new PropertyChangedEventArgs("Host");
		Class5.propertyChangedEventArgs_29 = new PropertyChangedEventArgs("Hp");
		Class5.HpDisplay = new PropertyChangedEventArgs("HpDisplay");
		Class5.propertyChangedEventArgs_30 = new PropertyChangedEventArgs("HpMax");
		Class5.HpPercentage = new PropertyChangedEventArgs("HpPercentage");
		Class5.Id = new PropertyChangedEventArgs("Id");
		Class5.propertyChangedEventArgs_31 = new PropertyChangedEventArgs("InjectedEncoder");
		Class5.NbqoJhOdgaB = new PropertyChangedEventArgs("InjectedLen");
		Class5.propertyChangedEventArgs_32 = new PropertyChangedEventArgs("InSafeZone");
		Class5.InviteList = new PropertyChangedEventArgs("InviteList");
		Class5.propertyChangedEventArgs_33 = new PropertyChangedEventArgs("Invites");
		Class5.propertyChangedEventArgs_34 = new PropertyChangedEventArgs("IsActive");
		Class5.propertyChangedEventArgs_35 = new PropertyChangedEventArgs("IsAuthenticated");
		Class5.propertyChangedEventArgs_36 = new PropertyChangedEventArgs("IsAvailable");
		Class5.propertyChangedEventArgs_37 = new PropertyChangedEventArgs("IsCloaked");
		Class5.propertyChangedEventArgs_38 = new PropertyChangedEventArgs("IsControlDisabled");
		Class5.propertyChangedEventArgs_39 = new PropertyChangedEventArgs("IsEnabled");
		Class5.propertyChangedEventArgs_40 = new PropertyChangedEventArgs("IsFighting");
		Class5.propertyChangedEventArgs_41 = new PropertyChangedEventArgs("IsGG");
		Class5.propertyChangedEventArgs_42 = new PropertyChangedEventArgs("IsInitialized");
		Class5.IsLoggedIn = new PropertyChangedEventArgs("IsLoggedIn");
		Class5.propertyChangedEventArgs_43 = new PropertyChangedEventArgs("IsLoggedOut");
		Class5.jkjoJdxknIo = new PropertyChangedEventArgs("IsNpc");
		Class5.IsOwner = new PropertyChangedEventArgs("IsOwner");
		Class5.propertyChangedEventArgs_44 = new PropertyChangedEventArgs("IsRepairNeeded");
		Class5.propertyChangedEventArgs_45 = new PropertyChangedEventArgs("IsX1");
		Class5.propertyChangedEventArgs_46 = new PropertyChangedEventArgs("Jackpot");
		Class5.propertyChangedEventArgs_47 = new PropertyChangedEventArgs("LastAttacked");
		Class5.propertyChangedEventArgs_48 = new PropertyChangedEventArgs("LastAttackedHero");
		Class5.propertyChangedEventArgs_49 = new PropertyChangedEventArgs("LastAttackedHeroDamage");
		Class5.propertyChangedEventArgs_50 = new PropertyChangedEventArgs("LastConfigSwitched");
		Class5.propertyChangedEventArgs_51 = new PropertyChangedEventArgs("LastControlDisabled");
		Class5.propertyChangedEventArgs_52 = new PropertyChangedEventArgs("LastDailyLogin");
		Class5.propertyChangedEventArgs_53 = new PropertyChangedEventArgs("LastDied");
		Class5.propertyChangedEventArgs_54 = new PropertyChangedEventArgs("LastDistance");
		Class5.propertyChangedEventArgs_55 = new PropertyChangedEventArgs("LastJumped");
		Class5.propertyChangedEventArgs_56 = new PropertyChangedEventArgs("LastPinged");
		Class5.propertyChangedEventArgs_57 = new PropertyChangedEventArgs("LastStatUpdate");
		Class5.propertyChangedEventArgs_58 = new PropertyChangedEventArgs("LastTookDamage");
		Class5.propertyChangedEventArgs_59 = new PropertyChangedEventArgs("LastTookDamageEnemy");
		Class5.propertyChangedEventArgs_60 = new PropertyChangedEventArgs("LastTookDamageFrom");
		Class5.propertyChangedEventArgs_61 = new PropertyChangedEventArgs("LastTookDamageHero");
		Class5.propertyChangedEventArgs_62 = new PropertyChangedEventArgs("LeashedBy");
		Class5.propertyChangedEventArgs_63 = new PropertyChangedEventArgs("Level");
		Class5.propertyChangedEventArgs_64 = new PropertyChangedEventArgs("LicenseExpiration");
		Class5.propertyChangedEventArgs_65 = new PropertyChangedEventArgs("LicenseState");
		Class5.propertyChangedEventArgs_66 = new PropertyChangedEventArgs("Location");
		Class5.propertyChangedEventArgs_67 = new PropertyChangedEventArgs("Log");
		Class5.propertyChangedEventArgs_68 = new PropertyChangedEventArgs("LogManager");
		Class5.Map = new PropertyChangedEventArgs("Map");
		Class5.MapId = new PropertyChangedEventArgs("MapId");
		Class5.MapName = new PropertyChangedEventArgs("MapName");
		Class5.propertyChangedEventArgs_69 = new PropertyChangedEventArgs("MapSize");
		Class5.MemberList = new PropertyChangedEventArgs("MemberList");
		Class5.propertyChangedEventArgs_70 = new PropertyChangedEventArgs("Members");
		Class5.Mode = new PropertyChangedEventArgs("Mode");
		Class5.propertyChangedEventArgs_71 = new PropertyChangedEventArgs("ModeExtra");
		Class5.ybaoJatPqLe = new PropertyChangedEventArgs("Modes");
		Class5.Name = new PropertyChangedEventArgs("Name");
		Class5.propertyChangedEventArgs_72 = new PropertyChangedEventArgs("NextMapId");
		Class5.propertyChangedEventArgs_73 = new PropertyChangedEventArgs("NpcTypes");
		Class5.propertyChangedEventArgs_74 = new PropertyChangedEventArgs("OwnerId");
		Class5.Pet = new PropertyChangedEventArgs("Pet");
		Class5.propertyChangedEventArgs_75 = new PropertyChangedEventArgs("Position");
		Class5.propertyChangedEventArgs_76 = new PropertyChangedEventArgs("Premium");
		Class5.propertyChangedEventArgs_77 = new PropertyChangedEventArgs("ProxySettings");
		Class5.propertyChangedEventArgs_78 = new PropertyChangedEventArgs("ProxySocket");
		Class5.propertyChangedEventArgs_79 = new PropertyChangedEventArgs("Range");
		Class5.propertyChangedEventArgs_80 = new PropertyChangedEventArgs("RangeFix");
		Class5.propertyChangedEventArgs_81 = new PropertyChangedEventArgs("Rect");
		Class5.propertyChangedEventArgs_82 = new PropertyChangedEventArgs("ResourceDuranium");
		Class5.propertyChangedEventArgs_83 = new PropertyChangedEventArgs("ResourceEndurium");
		Class5.propertyChangedEventArgs_84 = new PropertyChangedEventArgs("ResourcePalladium");
		Class5.propertyChangedEventArgs_85 = new PropertyChangedEventArgs("ResourcePromerium");
		Class5.propertyChangedEventArgs_86 = new PropertyChangedEventArgs("ResourcePrometid");
		Class5.propertyChangedEventArgs_87 = new PropertyChangedEventArgs("ResourcePrometium");
		Class5.Resources = new PropertyChangedEventArgs("Resources");
		Class5.propertyChangedEventArgs_88 = new PropertyChangedEventArgs("ResourceSeprom");
		Class5.propertyChangedEventArgs_89 = new PropertyChangedEventArgs("ResourceTerbium");
		Class5.propertyChangedEventArgs_90 = new PropertyChangedEventArgs("ResourceXenomit");
		Class5.propertyChangedEventArgs_91 = new PropertyChangedEventArgs("RightCorner");
		Class5.propertyChangedEventArgs_92 = new PropertyChangedEventArgs("SecretKey");
		Class5.propertyChangedEventArgs_93 = new PropertyChangedEventArgs("Security");
		Class5.SelectedShip = new PropertyChangedEventArgs("SelectedShip");
		Class5.propertyChangedEventArgs_94 = new PropertyChangedEventArgs("Server");
		Class5.propertyChangedEventArgs_95 = new PropertyChangedEventArgs("Settings");
		Class5.propertyChangedEventArgs_96 = new PropertyChangedEventArgs("Shield");
		Class5.ShieldDisplay = new PropertyChangedEventArgs("ShieldDisplay");
		Class5.propertyChangedEventArgs_97 = new PropertyChangedEventArgs("ShieldMax");
		Class5.ShieldPercentage = new PropertyChangedEventArgs("ShieldPercentage");
		Class5.propertyChangedEventArgs_98 = new PropertyChangedEventArgs("ShipInfo");
		Class5.propertyChangedEventArgs_99 = new PropertyChangedEventArgs("Ships");
		Class5.propertyChangedEventArgs_100 = new PropertyChangedEventArgs("Sid");
		Class5.propertyChangedEventArgs_101 = new PropertyChangedEventArgs("Socket");
		Class5.propertyChangedEventArgs_102 = new PropertyChangedEventArgs("Speed");
		Class5.propertyChangedEventArgs_103 = new PropertyChangedEventArgs("Target");
		Class5.zvwoYdyOnOC = new PropertyChangedEventArgs("TargetId");
		Class5.propertyChangedEventArgs_104 = new PropertyChangedEventArgs("Type");
		Class5.propertyChangedEventArgs_105 = new PropertyChangedEventArgs("TypeId");
		Class5.propertyChangedEventArgs_106 = new PropertyChangedEventArgs("Uid");
		Class5.Uridium = new PropertyChangedEventArgs("Uridium");
		Class5.propertyChangedEventArgs_107 = new PropertyChangedEventArgs("UserAgent");
		Class5.propertyChangedEventArgs_108 = new PropertyChangedEventArgs("UserName");
		Class5.Web = new PropertyChangedEventArgs("Web");
	}

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_0;

	internal static readonly PropertyChangedEventArgs AmmoHS1;

	internal static readonly PropertyChangedEventArgs AmmoR1;

	internal static readonly PropertyChangedEventArgs AmmoR2;

	internal static readonly PropertyChangedEventArgs AmmoR3;

	internal static readonly PropertyChangedEventArgs AmmoR4;

	internal static readonly PropertyChangedEventArgs AmmoX1;

	internal static readonly PropertyChangedEventArgs AmmoX2;

	internal static readonly PropertyChangedEventArgs AmmoX3;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_1;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_2;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_3;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_4;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_5;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_6;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_7;

	internal static readonly PropertyChangedEventArgs Center;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_8;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_9;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_10;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_11;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_12;

	internal static readonly PropertyChangedEventArgs Config;

	internal static readonly PropertyChangedEventArgs Connection;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_13;

	internal static readonly PropertyChangedEventArgs Credits;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_14;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_15;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_16;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_17;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_18;

	internal static readonly PropertyChangedEventArgs Experience;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_19;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_20;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_21;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_22;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_23;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_24;

	internal static readonly PropertyChangedEventArgs Game;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_25;

	internal static readonly PropertyChangedEventArgs GG;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_26;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_27;

	internal static readonly PropertyChangedEventArgs Group;

	internal static readonly PropertyChangedEventArgs Hero;

	internal static readonly PropertyChangedEventArgs Honor;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_28;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_29;

	internal static readonly PropertyChangedEventArgs HpDisplay;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_30;

	internal static readonly PropertyChangedEventArgs HpPercentage;

	internal static readonly PropertyChangedEventArgs Id;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_31;

	internal static readonly PropertyChangedEventArgs NbqoJhOdgaB;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_32;

	internal static readonly PropertyChangedEventArgs InviteList;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_33;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_34;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_35;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_36;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_37;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_38;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_39;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_40;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_41;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_42;

	internal static readonly PropertyChangedEventArgs IsLoggedIn;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_43;

	internal static readonly PropertyChangedEventArgs jkjoJdxknIo;

	internal static readonly PropertyChangedEventArgs IsOwner;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_44;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_45;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_46;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_47;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_48;

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

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_59;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_60;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_61;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_62;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_63;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_64;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_65;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_66;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_67;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_68;

	internal static readonly PropertyChangedEventArgs Map;

	internal static readonly PropertyChangedEventArgs MapId;

	internal static readonly PropertyChangedEventArgs MapName;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_69;

	internal static readonly PropertyChangedEventArgs MemberList;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_70;

	internal static readonly PropertyChangedEventArgs Mode;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_71;

	internal static readonly PropertyChangedEventArgs ybaoJatPqLe;

	internal static readonly PropertyChangedEventArgs Name;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_72;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_73;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_74;

	internal static readonly PropertyChangedEventArgs Pet;

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

	internal static readonly PropertyChangedEventArgs Resources;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_88;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_89;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_90;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_91;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_92;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_93;

	internal static readonly PropertyChangedEventArgs SelectedShip;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_94;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_95;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_96;

	internal static readonly PropertyChangedEventArgs ShieldDisplay;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_97;

	internal static readonly PropertyChangedEventArgs ShieldPercentage;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_98;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_99;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_100;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_101;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_102;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_103;

	internal static readonly PropertyChangedEventArgs zvwoYdyOnOC;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_104;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_105;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_106;

	internal static readonly PropertyChangedEventArgs Uridium;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_107;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_108;

	internal static readonly PropertyChangedEventArgs Web;
}
