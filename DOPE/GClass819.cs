using System;
using System.Collections.Generic;
using System.Linq;
using DarkorbitAPI;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;
using DOPE.UI.Models;

public class GClass819 : GClass818
{
	public GClass819(GClass810 gclass810_1)
	{
		Class8.xDph7tozmh5WD();
		base..ctor(gclass810_1, TargetMap.GG_VoT);
	}

	protected override void OnBind()
	{
		base.C.Game.LogMessage += this.method_1;
	}

	protected override void OnUnbind()
	{
		base.C.Game.LogMessage -= this.method_1;
	}

	private void method_1(GameManager gameManager_0, GClass255 gclass255_0)
	{
		string[] source;
		if (GClass90.smethod_1(gclass255_0.string_0, out source, new string[]
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

	public override bool vmethod_1()
	{
		return false;
	}

	public override SelectedNpcModel vmethod_2()
	{
		Ship selectedShip = base.C.Map.SelectedShip;
		if (selectedShip == null)
		{
			return null;
		}
		MapProfile mapProfile = base.MapProfile;
		if (mapProfile == null)
		{
			return null;
		}
		return mapProfile.GetModel(selectedShip, base.C.Map, null, 0);
	}

	public DateTimeOffset dateTimeOffset_2;
}
