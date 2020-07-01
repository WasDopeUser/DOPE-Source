using System;
using System.Collections.Generic;
using System.Linq;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;

public class GClass899 : GClass896
{
	public override bool IsInterruptible
	{
		get
		{
			return false;
		}
	}

	public GClass899(GClass890 gclass890_1)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor(gclass890_1, TargetMap.PayloadEscort);
	}

	public override MapProfile UpdateProfile(BotProfile botProfile_1)
	{
		if (botProfile_1 == null)
		{
			return null;
		}
		List<MapProfile> maps = botProfile_1.Maps;
		if (maps == null)
		{
			return null;
		}
		return maps.FirstOrDefault(new Func<MapProfile, bool>(GClass899.<>c.<>c_0.method_0));
	}

	public override bool TrySwitchMap(out int int_2)
	{
		int_2 = 431;
		if (MapUtils.smethod_2(base.C.Map.MapId) == MapGroup.PayloadEscort)
		{
			int_2 = MapUtils.smethod_12(1, base.C.Hero.FactionId);
		}
		return true;
	}

	public override int UpdatePriority()
	{
		DateTimeOffset eventGateOpening = base.C.Game.EventGateOpening;
		DateTimeOffset eventGateClosing = base.C.Game.EventGateClosing;
		DateTimeOffset now = DateTimeOffset.Now;
		bool flag = (eventGateOpening != default(DateTimeOffset) && eventGateOpening < now && eventGateClosing < now) || base.C.Hero.LastStatUpdate == default(DateTimeOffset);
		bool flag2 = base.C.Hero.method_26("resource_payload-keys") > 0.0;
		if (!flag && (!(eventGateClosing > eventGateOpening) || !(eventGateClosing > now) || !flag2) && (!base.C.gclass907_0.method_28().smethod_0(120000) || !base.C.Game.LastDied.smethod_0(60000)))
		{
			return int.MinValue;
		}
		int num = base.UpdatePriority();
		if (num > 0)
		{
			base.C.Scheduler.method_11(this);
		}
		return num;
	}

	public override bool CheckStopped()
	{
		return MapUtils.smethod_2(base.C.Map.MapId) != MapGroup.PayloadEscort;
	}

	public override string ToString()
	{
		return "Payload Escort";
	}
}
