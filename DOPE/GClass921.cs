﻿using System;
using System.Runtime.CompilerServices;
using System.Threading;

public class GClass921 : GClass916
{
	public override int Cooldown
	{
		get
		{
			if (!this.method_2())
			{
				return 300000;
			}
			return 60000;
		}
	}

	[CompilerGenerated]
	public bool method_2()
	{
		return this.bool_1;
	}

	[CompilerGenerated]
	public void method_3(bool bool_2)
	{
		this.bool_1 = bool_2;
	}

	public GClass921(GClass890 gclass890_1)
	{
		Class13.lOBHd9Nzn7x2T();
		this.bool_1 = true;
		base..ctor(gclass890_1, "SkylabWorker");
	}

	public void method_4()
	{
		this.method_3(true);
		GClass78 skylab = base.Context.Game.Web.Skylab;
		GClass49.GClass76 hangar = base.Context.Game.Web.Equipment.Hangar;
		DateTimeOffset? dateTimeOffset = skylab.method_0().method_5();
		skylab.method_1().GetAwaiter().GetResult();
		DateTimeOffset? dateTimeOffset2 = skylab.method_0().method_5();
		if (dateTimeOffset != null && dateTimeOffset2 == null)
		{
			base.Log.Info("Transfer complete. Refreshing");
			base.Context.method_62<GClass920>().imethod_1();
			return;
		}
		if (dateTimeOffset2 != null)
		{
			base.Log.Info<DateTimeOffset>("Transfer in progress. Complete at {time}", dateTimeOffset2.Value);
			return;
		}
		int num = (int)base.Context.Hero.ResourcePromerium;
		int num2 = (int)base.Context.Hero.ResourceSeprom;
		if (!base.Context.Game.Connection.Socket.method_2() || !base.Context.Hero.IsInitialized)
		{
			num = (int)hangar.method_2("resource_ore_promerium");
			num2 = (int)hangar.method_2("resource_ore_seprom");
		}
		int skylab_KeepPromerium = base.Context.Account.Skylab_KeepPromerium;
		int skylab_KeepSeprom = base.Context.Account.Skylab_KeepSeprom;
		int num3 = Math.Min(Math.Max(0, skylab_KeepPromerium - num), skylab.method_0().method_2("resource_ore_promerium"));
		int num4 = Math.Min(Math.Max(0, skylab_KeepSeprom - num2), skylab.method_0().method_2("resource_ore_seprom"));
		base.Log.Info<int, int>("Need to transfer {promerium} promerium & {seprom} seprom", num3, num4);
		num4 = Math.Min(num4, 90);
		int val = 100 - num4;
		num3 = Math.Min(num3, val);
		if (num3 + num4 == 0)
		{
			return;
		}
		Thread.Sleep(2000);
		base.Log.Info<int, int>("Transferring a batch of {promerium} promerium & {seprom} seprom", num3, num4);
		bool result = skylab.method_2(num3, num4).GetAwaiter().GetResult();
		this.method_3(result);
		base.Log.Info("Transfer state: {state}", result);
	}

	public override void Execute()
	{
		this.method_4();
	}

	public override bool vmethod_0()
	{
		return base.Context.Game.Web.Equipment.Hangar != null && base.Context.Account.Skylab_KeepPromerium + base.Context.Account.Skylab_KeepSeprom > 0;
	}

	[CompilerGenerated]
	private bool bool_1;
}
