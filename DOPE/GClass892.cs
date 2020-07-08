using System;
using System.Collections.Generic;
using System.Linq;
using DOPE.Common.Models;

public class GClass892 : GClass891
{
	public override MapProfile UpdateProfile(BotProfile botProfile_1)
	{
		return null;
	}

	public override bool ShouldBeInGame()
	{
		return false;
	}

	public override int UpdatePriority()
	{
		return -1;
	}

	public override void UpdateState()
	{
		base.UpdateState();
	}

	public override MapProfile GetMapProfile()
	{
		return base.Context.MapProfile ?? this.mapProfile_1;
	}

	public GClass892(GClass889 gclass889_1)
	{
		Class13.xnk8ImWzpOt04();
		this.mapProfile_1 = new MapProfile
		{
			TargetMap = TargetMap.X1
		};
		base..ctor(gclass889_1, "Idle", -1);
		base.MapProfile = null;
	}

	public override bool ShouldChangeHangar(out string string_1)
	{
		string_1 = null;
		AccountSettings account = base.C.Account;
		if (account != null && account.Spinner_UsePhoenix)
		{
			AccountSettings account2 = base.C.Account;
			if (((account2 != null) ? account2.HangarDefault : null) != null && base.Started.Cooldown(30000))
			{
				GClass892.<>c__DisplayClass8_0 CS$<>8__locals1 = new GClass892.<>c__DisplayClass8_0();
				GClass918 gclass = base.Context.method_61<GClass918>();
				GClass892.<>c__DisplayClass8_0 CS$<>8__locals2 = CS$<>8__locals1;
				AccountSettings account3 = base.C.Account;
				List<string> list;
				if (account3 == null)
				{
					list = null;
				}
				else
				{
					VolatileData @volatile = account3.Volatile;
					list = ((@volatile != null) ? @volatile.Hangars : null);
				}
				CS$<>8__locals2.list_0 = list;
				string_1 = ((CS$<>8__locals1.list_0 == null) ? null : GClass892.list_0.FirstOrDefault(new Func<string, bool>(CS$<>8__locals1.method_0)));
				return string_1 != null && gclass.method_15() > 0;
			}
		}
		return false;
	}

	public override string ToString()
	{
		return "Idle";
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass892()
	{
		Class13.xnk8ImWzpOt04();
		GClass892.list_0 = new List<string>
		{
			"ship_phoenix",
			"ship_liberator"
		};
	}

	private MapProfile mapProfile_1;

	public static List<string> list_0;
}
