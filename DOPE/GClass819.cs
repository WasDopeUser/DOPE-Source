using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DarkorbitAPI;
using DOPE.Common.Models.Bot.Stats;

public class GClass819 : StatisticsCategory
{
	public DarkOrbitWebAPI Web { get; }

	public GClass819(DarkOrbitWebAPI darkOrbitWebAPI_1)
	{
		Class13.igxcIukzfpare();
		base..ctor("GG", new string[]
		{
			"Name",
			"Parts",
			"Wave",
			"Lives"
		}, null);
		this.Web = darkOrbitWebAPI_1;
		base.Subscribe<DarkOrbitWebAPI>(this.Web);
	}

	public override void Update()
	{
		DarkOrbitWebAPI.GalaxyGatesInfo ggInfo = this.Web.GgInfo;
		if (ggInfo == null)
		{
			return;
		}
		Dictionary<Type, object> subscribed = this.Subscribed;
		lock (subscribed)
		{
			this.Subscribed[typeof(DarkOrbitWebAPI.GalaxyGatesInfo)] = ggInfo;
		}
		DarkOrbitWebAPI.jumpgateGate[] gates = ggInfo.gates;
		for (int i = 0; i < gates.Length; i++)
		{
			GClass819.<>c__DisplayClass4_0 CS$<>8__locals1 = new GClass819.<>c__DisplayClass4_0();
			CS$<>8__locals1.jumpgateGate_0 = gates[i];
			string key;
			if (GClass851.dictionary_0.TryGetValue(CS$<>8__locals1.jumpgateGate_0.id, out key))
			{
				base.Add(StatisticsCategory.WithName(key, new IValueWrapper<string>[]
				{
					this.method_0(new Func<DarkOrbitWebAPI.GalaxyGatesInfo, string>(CS$<>8__locals1.method_0)),
					this.method_0(new Func<DarkOrbitWebAPI.GalaxyGatesInfo, string>(CS$<>8__locals1.method_1)),
					this.method_0(new Func<DarkOrbitWebAPI.GalaxyGatesInfo, string>(CS$<>8__locals1.method_2))
				}));
			}
		}
		base.Update();
	}

	[CompilerGenerated]
	private IValueWrapper<string> method_0(Func<DarkOrbitWebAPI.GalaxyGatesInfo, string> func_0)
	{
		return base.L<DarkOrbitWebAPI.GalaxyGatesInfo>(func_0);
	}

	[CompilerGenerated]
	private readonly DarkOrbitWebAPI darkOrbitWebAPI_0;
}
