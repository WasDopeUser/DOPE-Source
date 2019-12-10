using System;
using System.Collections.Generic;
using System.Linq;
using DOPE.Common.Models;

public class GClass813 : GClass812
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

	public GClass813(GClass810 gclass810_1)
	{
		Class8.xDph7tozmh5WD();
		this.mapProfile_1 = new MapProfile
		{
			TargetMap = TargetMap.X1
		};
		base..ctor(gclass810_1, "Idle", -1);
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
				GClass813.<>c__DisplayClass8_0 CS$<>8__locals1 = new GClass813.<>c__DisplayClass8_0();
				GClass832 gclass = base.Context.QrIiaYslyyT<GClass832>();
				GClass813.<>c__DisplayClass8_0 CS$<>8__locals2 = CS$<>8__locals1;
				AccountSettings account3 = base.C.Account;
				List<string> olCigxAtwm;
				if (account3 == null)
				{
					olCigxAtwm = null;
				}
				else
				{
					VolatileData @volatile = account3.Volatile;
					olCigxAtwm = ((@volatile != null) ? @volatile.Hangars : null);
				}
				CS$<>8__locals2.OlCigxAtwm2 = olCigxAtwm;
				string_1 = ((CS$<>8__locals1.OlCigxAtwm2 == null) ? null : GClass813.list_0.FirstOrDefault(new Func<string, bool>(CS$<>8__locals1.method_0)));
				return string_1 != null && gclass.method_14() > 0;
			}
		}
		return false;
	}

	public override string ToString()
	{
		return "Idle";
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass813()
	{
		Class8.xDph7tozmh5WD();
		GClass813.list_0 = new List<string>
		{
			"ship_phoenix",
			"ship_liberator"
		};
	}

	private MapProfile mapProfile_1;

	public static List<string> list_0;
}
