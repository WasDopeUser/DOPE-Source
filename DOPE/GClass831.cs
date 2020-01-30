using System;
using System.Collections.Generic;
using System.Linq;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;
using DOPE.Common.Models.Bot;

public class GClass831 : GClass829
{
	public GClass831(GClass823 gclass823_1)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor(gclass823_1, TargetMap.FL_ATLAS_A);
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
		return maps.FirstOrDefault(new Func<MapProfile, bool>(GClass831.<>c.<>c_0.method_0));
	}

	public override bool TrySwitchMap(out int int_2)
	{
		if (!base.C.IsStopping)
		{
			if (base.State == ModuleState.Started)
			{
				int_2 = 430;
				return base.C.Map.MapId < 430 || base.C.Map.MapId > 445;
			}
		}
		int_2 = MapUtils.smethod_9(1, base.C.Hero.FactionId);
		return int_2 != base.C.Map.MapId;
	}

	public override int UpdatePriority()
	{
		DateTimeOffset frozenLabirynthOpening = base.C.Game.FrozenLabirynthOpening;
		DateTimeOffset frozenLabirynthClosing = base.C.Game.FrozenLabirynthClosing;
		bool flag = frozenLabirynthOpening == default(DateTimeOffset) || frozenLabirynthClosing == default(DateTimeOffset);
		DateTimeOffset now = DateTimeOffset.Now;
		if (!flag && !(frozenLabirynthOpening < now) && !(frozenLabirynthClosing > now))
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
