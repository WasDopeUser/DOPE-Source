using System;
using System.Collections.Generic;
using System.Linq;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;
using DOPE.Common.Models.Bot;

public class GClass898 : GClass896
{
	public GClass898(GClass890 gclass890_1)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor(gclass890_1, TargetMap.FL_ATLAS_A);
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
		return maps.FirstOrDefault(new Func<MapProfile, bool>(GClass898.<>c.<>c_0.method_0));
	}

	public override bool TrySwitchMap(out int int_2)
	{
		if (!base.C.IsStopping)
		{
			if (base.State == ModuleState.Started)
			{
				int_2 = 430;
				return MapUtils.smethod_2(base.C.Map.MapId) != MapGroup.FrozenLabyrinth;
			}
		}
		int_2 = MapUtils.smethod_12(1, base.C.Hero.FactionId);
		return int_2 != base.C.Map.MapId;
	}

	public override int UpdatePriority()
	{
		DateTimeOffset eventGateOpening = base.C.Game.EventGateOpening;
		DateTimeOffset eventGateClosing = base.C.Game.EventGateClosing;
		bool flag = eventGateOpening == default(DateTimeOffset) || eventGateClosing == default(DateTimeOffset);
		DateTimeOffset now = DateTimeOffset.Now;
		if (!flag && !(eventGateOpening < now) && !(eventGateClosing > now))
		{
			return int.MinValue;
		}
		return base.UpdatePriority();
	}

	public override string ToString()
	{
		return "Frozen Labirynth";
	}
}
