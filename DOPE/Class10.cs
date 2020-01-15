using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
[DebuggerNonUserCode]
[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
internal static class Class10
{
	// Note: this type is marked as 'beforefieldinit'.
	static Class10()
	{
		Class13.nIxas2ezryi9b();
		Class10.Account = new PropertyChangedEventArgs("Account");
		Class10.propertyChangedEventArgs_0 = new PropertyChangedEventArgs("AttackingId");
		Class10.propertyChangedEventArgs_1 = new PropertyChangedEventArgs("BackgroundQueue");
		Class10.propertyChangedEventArgs_2 = new PropertyChangedEventArgs("Behavior");
		Class10.propertyChangedEventArgs_3 = new PropertyChangedEventArgs("BestSpawn");
		Class10.propertyChangedEventArgs_4 = new PropertyChangedEventArgs("BestSpawnTime");
		Class10.propertyChangedEventArgs_5 = new PropertyChangedEventArgs("BotProfiles");
		Class10.propertyChangedEventArgs_6 = new PropertyChangedEventArgs("BotThread");
		Class10.propertyChangedEventArgs_7 = new PropertyChangedEventArgs("BoxTracker");
		Class10.propertyChangedEventArgs_8 = new PropertyChangedEventArgs("C");
		Class10.propertyChangedEventArgs_9 = new PropertyChangedEventArgs("CollectibleTarget");
		Class10.propertyChangedEventArgs_10 = new PropertyChangedEventArgs("CollectProfile");
		Class10.Connection = new PropertyChangedEventArgs("Connection");
		Class10.Context = new PropertyChangedEventArgs("Context");
		Class10.propertyChangedEventArgs_11 = new PropertyChangedEventArgs("Control");
		Class10.Controller = new PropertyChangedEventArgs("Controller");
		Class10.propertyChangedEventArgs_12 = new PropertyChangedEventArgs("Cooldown");
		Class10.propertyChangedEventArgs_13 = new PropertyChangedEventArgs("Cooldowns");
		Class10.Count = new PropertyChangedEventArgs("Count");
		Class10.CreditsHourly = new PropertyChangedEventArgs("CreditsHourly");
		Class10.propertyChangedEventArgs_14 = new PropertyChangedEventArgs("CurrentPath");
		Class10.propertyChangedEventArgs_15 = new PropertyChangedEventArgs("CurrentProfile");
		Class10.propertyChangedEventArgs_16 = new PropertyChangedEventArgs("DarkorbitAPI.Licensing.IDopeServiceProxy.Service");
		Class10.propertyChangedEventArgs_17 = new PropertyChangedEventArgs("DeathLog");
		Class10.Deaths = new PropertyChangedEventArgs("Deaths");
		Class10.propertyChangedEventArgs_18 = new PropertyChangedEventArgs("DormantTargets");
		Class10.Email = new PropertyChangedEventArgs("Email");
		Class10.propertyChangedEventArgs_19 = new PropertyChangedEventArgs("EnemyLocated");
		Class10.propertyChangedEventArgs_20 = new PropertyChangedEventArgs("EnemyTarget");
		Class10.propertyChangedEventArgs_21 = new PropertyChangedEventArgs("FailedJumpCount");
		Class10.propertyChangedEventArgs_22 = new PropertyChangedEventArgs("ForceLogout");
		Class10.propertyChangedEventArgs_23 = new PropertyChangedEventArgs("GalaxyGateType");
		Class10.Game = new PropertyChangedEventArgs("Game");
		Class10.propertyChangedEventArgs_24 = new PropertyChangedEventArgs("GameServer");
		Class10.Hero = new PropertyChangedEventArgs("Hero");
		Class10.propertyChangedEventArgs_25 = new PropertyChangedEventArgs("HeroPosition");
		Class10.propertyChangedEventArgs_26 = new PropertyChangedEventArgs("ignoreShields");
		Class10.propertyChangedEventArgs_27 = new PropertyChangedEventArgs("IsAttacking");
		Class10.propertyChangedEventArgs_28 = new PropertyChangedEventArgs("IsCollecting");
		Class10.propertyChangedEventArgs_29 = new PropertyChangedEventArgs("IsEnabled");
		Class10.IsPaused = new PropertyChangedEventArgs("IsPaused");
		Class10.propertyChangedEventArgs_30 = new PropertyChangedEventArgs("IsStopping");
		Class10.propertyChangedEventArgs_31 = new PropertyChangedEventArgs("Key");
		Class10.propertyChangedEventArgs_32 = new PropertyChangedEventArgs("LastBackgroundAction");
		Class10.propertyChangedEventArgs_33 = new PropertyChangedEventArgs("LastBackgroundHandlerAction");
		Class10.LastDisconnectReason = new PropertyChangedEventArgs("LastDisconnectReason");
		Class10.propertyChangedEventArgs_34 = new PropertyChangedEventArgs("LastLogin");
		Class10.propertyChangedEventArgs_35 = new PropertyChangedEventArgs("LastMapLogin");
		Class10.propertyChangedEventArgs_36 = new PropertyChangedEventArgs("LastStates");
		Class10.propertyChangedEventArgs_37 = new PropertyChangedEventArgs("Log");
		Class10.propertyChangedEventArgs_38 = new PropertyChangedEventArgs("LoginTask");
		Class10.propertyChangedEventArgs_39 = new PropertyChangedEventArgs("MainController");
		Class10.Map = new PropertyChangedEventArgs("Map");
		Class10.propertyChangedEventArgs_40 = new PropertyChangedEventArgs("MapProfile");
		Class10.Module = new PropertyChangedEventArgs("Module");
		Class10.Name = new PropertyChangedEventArgs("Name");
		Class10.propertyChangedEventArgs_41 = new PropertyChangedEventArgs("NextBot");
		Class10.propertyChangedEventArgs_42 = new PropertyChangedEventArgs("NpcLockout");
		Class10.propertyChangedEventArgs_43 = new PropertyChangedEventArgs("Priority");
		Class10.propertyChangedEventArgs_44 = new PropertyChangedEventArgs("Profile");
		Class10.propertyChangedEventArgs_45 = new PropertyChangedEventArgs("RealDist");
		Class10.propertyChangedEventArgs_46 = new PropertyChangedEventArgs("ReturnState");
		Class10.propertyChangedEventArgs_47 = new PropertyChangedEventArgs("RoamTarget");
		Class10.propertyChangedEventArgs_48 = new PropertyChangedEventArgs("Run");
		Class10.RunTime = new PropertyChangedEventArgs("RunTime");
		Class10.Scheduler = new PropertyChangedEventArgs("Scheduler");
		Class10.propertyChangedEventArgs_49 = new PropertyChangedEventArgs("SelectedAmmo");
		Class10.propertyChangedEventArgs_50 = new PropertyChangedEventArgs("SelectedHS");
		Class10.propertyChangedEventArgs_51 = new PropertyChangedEventArgs("SelectedRockets");
		Class10.propertyChangedEventArgs_52 = new PropertyChangedEventArgs("SellProfile");
		Class10.propertyChangedEventArgs_53 = new PropertyChangedEventArgs("Server");
		Class10.propertyChangedEventArgs_54 = new PropertyChangedEventArgs("Service");
		Class10.ServiceStatus = new PropertyChangedEventArgs("ServiceStatus");
		Class10.propertyChangedEventArgs_55 = new PropertyChangedEventArgs("ShouldBeDisabled");
		Class10.Started = new PropertyChangedEventArgs("Started");
		Class10.State = new PropertyChangedEventArgs("State");
		Class10.propertyChangedEventArgs_56 = new PropertyChangedEventArgs("StateIters");
		Class10.Stats = new PropertyChangedEventArgs("Stats");
		Class10.Status = new PropertyChangedEventArgs("Status");
		Class10.Stopped = new PropertyChangedEventArgs("Stopped");
		Class10.propertyChangedEventArgs_57 = new PropertyChangedEventArgs("Timeout");
		Class10.propertyChangedEventArgs_58 = new PropertyChangedEventArgs("TimeTableActive");
		Class10.propertyChangedEventArgs_59 = new PropertyChangedEventArgs("TimeTableProfile");
		Class10.propertyChangedEventArgs_60 = new PropertyChangedEventArgs("TravelTarget");
		Class10.UridiumHourly = new PropertyChangedEventArgs("UridiumHourly");
	}

	internal static readonly PropertyChangedEventArgs Account;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_0;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_1;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_2;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_3;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_4;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_5;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_6;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_7;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_8;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_9;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_10;

	internal static readonly PropertyChangedEventArgs Connection;

	internal static readonly PropertyChangedEventArgs Context;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_11;

	internal static readonly PropertyChangedEventArgs Controller;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_12;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_13;

	internal static readonly PropertyChangedEventArgs Count;

	internal static readonly PropertyChangedEventArgs CreditsHourly;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_14;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_15;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_16;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_17;

	internal static readonly PropertyChangedEventArgs Deaths;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_18;

	internal static readonly PropertyChangedEventArgs Email;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_19;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_20;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_21;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_22;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_23;

	internal static readonly PropertyChangedEventArgs Game;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_24;

	internal static readonly PropertyChangedEventArgs Hero;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_25;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_26;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_27;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_28;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_29;

	internal static readonly PropertyChangedEventArgs IsPaused;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_30;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_31;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_32;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_33;

	internal static readonly PropertyChangedEventArgs LastDisconnectReason;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_34;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_35;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_36;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_37;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_38;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_39;

	internal static readonly PropertyChangedEventArgs Map;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_40;

	internal static readonly PropertyChangedEventArgs Module;

	internal static readonly PropertyChangedEventArgs Name;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_41;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_42;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_43;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_44;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_45;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_46;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_47;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_48;

	internal static readonly PropertyChangedEventArgs RunTime;

	internal static readonly PropertyChangedEventArgs Scheduler;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_49;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_50;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_51;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_52;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_53;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_54;

	internal static readonly PropertyChangedEventArgs ServiceStatus;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_55;

	internal static readonly PropertyChangedEventArgs Started;

	internal static readonly PropertyChangedEventArgs State;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_56;

	internal static readonly PropertyChangedEventArgs Stats;

	internal static readonly PropertyChangedEventArgs Status;

	internal static readonly PropertyChangedEventArgs Stopped;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_57;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_58;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_59;

	internal static readonly PropertyChangedEventArgs propertyChangedEventArgs_60;

	internal static readonly PropertyChangedEventArgs UridiumHourly;
}
