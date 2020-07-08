using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DarkorbitAPI.Structures;
using DOPE.Common.Models.Bot.Stats;
using xcwaDuiebvuNrIkSlmL;

public class GClass886 : StatisticsCategory
{
	public HeroPet Pet { get; }

	public GClass881 Stats { get; }

	public GClass886(HeroPet heroPet_1, GClass881 gclass881_1)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor("Pet", new string[]
		{
			"Name",
			"Value"
		}, null);
		this.Pet = heroPet_1;
		this.Stats = gclass881_1;
		base.Subscribe<HeroPet>(this.Pet);
		base.Subscribe<GClass881>(this.Stats);
	}

	public override void Update()
	{
		GClass886.<>c__DisplayClass7_0 CS$<>8__locals1;
		CS$<>8__locals1.gclass886_0 = this;
		List<IRowEntry> list = new List<IRowEntry>();
		list.Add(this.method_0("Available", new Func<HeroPet, string>(GClass886.<>c.<>c_0.method_0), ref CS$<>8__locals1));
		CS$<>8__locals1.omswiQaUjfd = list;
		if (this.Pet.IsAvailable)
		{
			this.method_1("Enabled", new Func<HeroPet, string>(GClass886.<>c.<>c_0.method_1), ref CS$<>8__locals1);
			this.method_1("Name", new Func<HeroPet, string>(GClass886.<>c.<>c_0.method_2), ref CS$<>8__locals1);
			this.method_1("Fuel", new Func<HeroPet, string>(GClass886.<>c.<>c_0.method_3), ref CS$<>8__locals1);
			this.method_1("Level", new Func<HeroPet, string>(GClass886.<>c.<>c_0.method_4), ref CS$<>8__locals1);
			this.method_1("Experience", new Func<HeroPet, string>(GClass886.<>c.<>c_0.method_5), ref CS$<>8__locals1);
			this.method_1("HP", new Func<HeroPet, string>(GClass886.<>c.<>c_0.method_6), ref CS$<>8__locals1);
			this.method_1("Shield", new Func<HeroPet, string>(GClass886.<>c.<>c_0.method_7), ref CS$<>8__locals1);
			this.method_1("Mode", new Func<HeroPet, string>(GClass886.<>c.<>c_0.method_8), ref CS$<>8__locals1);
			List<IRowEntry> omswiQaUjfd = CS$<>8__locals1.omswiQaUjfd;
			string key = "Deaths";
			IValueWrapper<string>[] array = new IValueWrapper<string>[1];
			array[0] = base.L<GClass881>(new Func<GClass881, string>(GClass886.<>c.<>c_0.method_9));
			omswiQaUjfd.Add(StatisticsCategory.WithName(key, array));
		}
		int num = 0;
		foreach (IRowEntry rowEntry in CS$<>8__locals1.omswiQaUjfd)
		{
			rowEntry.Order = num++;
			base.Add(rowEntry);
		}
		base.Update();
	}

	[CompilerGenerated]
	private IRowEntry method_0(string string_0, Func<HeroPet, string> func_0, ref GClass886.<>c__DisplayClass7_0 <>c__DisplayClass7_0_0)
	{
		return StatisticsCategory.WithName(string_0, new IValueWrapper<string>[]
		{
			base.L<HeroPet>(func_0)
		});
	}

	[CompilerGenerated]
	private void method_1(string string_0, Func<HeroPet, string> func_0, ref GClass886.<>c__DisplayClass7_0 <>c__DisplayClass7_0_0)
	{
		<>c__DisplayClass7_0_0.omswiQaUjfd.Add(this.method_0(string_0, func_0, ref <>c__DisplayClass7_0_0));
	}

	[CompilerGenerated]
	private readonly HeroPet heroPet_0;

	[CompilerGenerated]
	private readonly GClass881 gclass881_0;
}
