using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using DOPE.Common;
using DOPE.Common.Models;

public abstract class GClass895 : GClass892
{
	public TargetMap Map
	{
		[CompilerGenerated]
		get
		{
			return this.targetMap_0;
		}
		[CompilerGenerated]
		protected set
		{
			if (this.targetMap_0 == value)
			{
				return;
			}
			this.targetMap_0 = value;
			this.method_0(Class10.Map);
		}
	}

	public GClass895(GClass890 gclass890_1, TargetMap targetMap_1, string string_1, int int_2 = -2147483648)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor(gclass890_1, string_1 + "_" + targetMap_1.GetName(), int_2);
		this.Map = targetMap_1;
	}

	public override MapProfile UpdateProfile(BotProfile botProfile_1)
	{
		GClass895.<>c__DisplayClass5_0 CS$<>8__locals1 = new GClass895.<>c__DisplayClass5_0();
		CS$<>8__locals1.targetMap_0 = this.Map;
		if (botProfile_1 == null)
		{
			return null;
		}
		List<MapProfile> maps = botProfile_1.Maps;
		if (maps == null)
		{
			return null;
		}
		return maps.FirstOrDefault(new Func<MapProfile, bool>(CS$<>8__locals1.method_0));
	}

	public override string ToString()
	{
		return this.Map.GetName() ?? "";
	}

	[CompilerGenerated]
	private TargetMap targetMap_0;
}
