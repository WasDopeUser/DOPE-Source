using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using DOPE.Common;
using DOPE.Common.Models;

public class GClass920 : GClass916
{
	public GClass920(GClass890 gclass890_1)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor(gclass890_1, "HangarInfoProvider");
	}

	public override int Cooldown
	{
		get
		{
			if (base.Context.Game.Web.Equipment.Hangars != null)
			{
				return 60000;
			}
			return 2000;
		}
	}

	[CompilerGenerated]
	public DateTimeOffset method_2()
	{
		return this.dateTimeOffset_1;
	}

	[CompilerGenerated]
	public void method_3(DateTimeOffset dateTimeOffset_2)
	{
		this.dateTimeOffset_1 = dateTimeOffset_2;
	}

	public override void Execute()
	{
		GClass28.GClass48 hangarList = base.Context.Game.Web.Equipment.GetHangarList();
		GClass49.GClass76 hangar = base.Context.Game.Web.Equipment.GetHangar();
		IDopeService service = base.Context.MainController.Parent.Service;
		List<string> list = hangarList.data.ret.hangars.Select(new Func<GClass28.GClass32, string>(GClass920.<>c.<>c_0.method_0)).ToList<string>();
		if (list != null && list.Any<string>() && hangar != null)
		{
			VolatileData volatileData = new VolatileData();
			volatileData.LastUpdated = DateTimeOffset.Now;
			volatileData.Hangars = list;
			VolatileData volatileData2 = volatileData;
			GClass28.GClass32 gclass = hangarList.data.ret.hangars.FirstOrDefault(new Func<GClass28.GClass32, bool>(GClass920.<>c.<>c_0.method_1));
			string activeHangar;
			if (gclass == null)
			{
				activeHangar = null;
			}
			else
			{
				GClass28.GClass31 gclass31_ = gclass.GClass31_0;
				if (gclass31_ == null)
				{
					activeHangar = null;
				}
				else
				{
					GClass28.GClass30 gclass30_ = gclass31_.GClass30_0;
					activeHangar = ((gclass30_ != null) ? gclass30_.String_0 : null);
				}
			}
			volatileData2.ActiveHangar = activeHangar;
			volatileData.Fill();
			base.Context.Account.Volatile = volatileData;
			if (this.method_2().Cooldown(120000))
			{
				service.UpdateVolatile(base.Context.Account.BotId, volatileData);
				this.method_3(DateTimeOffset.Now);
			}
		}
	}

	public override bool vmethod_0()
	{
		return true;
	}

	[CompilerGenerated]
	private DateTimeOffset dateTimeOffset_1;
}
