using System;
using System.Collections.Generic;
using System.Linq;
using DarkorbitAPI;
using DOPE.Common.Models;

public class GClass851 : GClass850
{
	public GClass851(GClass839 gclass839_1)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor(gclass839_1, TargetMap.GG_VoT);
	}

	protected override void OnBind()
	{
		base.C.Game.LogMessage += this.method_3;
	}

	protected override void OnUnbind()
	{
		base.C.Game.LogMessage -= this.method_3;
	}

	private void method_3(GameManager gameManager_0, GClass273 gclass273_0)
	{
		string[] source;
		if (GClass90.smethod_1(gclass273_0.string_0, out source, new string[]
		{
			"n",
			"MSG",
			"1",
			"0",
			"msg_galaxy_gate_cooldown_active"
		}) && source.FirstOrDefault<string>() != null)
		{
			Dictionary<string, string> dictionary = GClass90.smethod_0(source.FirstOrDefault<string>());
			string s;
			string s2;
			int num;
			int num2;
			if (dictionary.TryGetValue("%HOURS%", out s) && dictionary.TryGetValue("%MINUTES%", out s2) && int.TryParse(s, out num) && int.TryParse(s2, out num2))
			{
				base.Log.Info<int, int>("GG cooldown: {hours}h {minutes}m", num, num2);
				this.dateTimeOffset_2 = DateTimeOffset.Now.AddHours((double)num).AddMinutes((double)num2);
			}
		}
	}

	protected override bool vmethod_0()
	{
		return this.dateTimeOffset_2.Cooldown(0);
	}

	public DateTimeOffset dateTimeOffset_2;
}
