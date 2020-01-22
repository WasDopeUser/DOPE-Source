using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DarkorbitAPI.Structures;
using DOPE.Common.Models.Bot.Stats;

public class GClass819 : StatisticsCategory
{
	public HeroPet Pet { get; }

	public GClass814 Stats { get; }

	public GClass819(HeroPet heroPet_1, GClass814 gclass814_1)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor("Pet", new string[]
		{
			"Name",
			"Value"
		}, null);
		this.Pet = heroPet_1;
		this.Stats = gclass814_1;
		base.Subscribe<HeroPet>(this.Pet);
		base.Subscribe<GClass814>(this.Stats);
	}

	public override void Update()
	{
		GClass819.<>c__DisplayClass7_0 CS$<>8__locals1;
		CS$<>8__locals1.gclass819_0 = this;
		List<IRowEntry> list = new List<IRowEntry>();
		list.Add(this.method_0("Available", new Func<HeroPet, string>(GClass819.<>c.<>c_0.method_0), ref CS$<>8__locals1));
		CS$<>8__locals1.list_0 = list;
		if (this.Pet.IsAvailable)
		{
			this.method_1("Enabled", new Func<HeroPet, string>(GClass819.<>c.<>c_0.method_1), ref CS$<>8__locals1);
			this.method_1("Name", new Func<HeroPet, string>(GClass819.<>c.<>c_0.method_2), ref CS$<>8__locals1);
			this.method_1("Fuel", new Func<HeroPet, string>(GClass819.<>c.<>c_0.method_3), ref CS$<>8__locals1);
			this.method_1("Level", new Func<HeroPet, string>(GClass819.<>c.<>c_0.method_4), ref CS$<>8__locals1);
			this.method_1("Experience", new Func<HeroPet, string>(GClass819.<>c.<>c_0.method_5), ref CS$<>8__locals1);
			this.method_1("HP", new Func<HeroPet, string>(GClass819.<>c.<>c_0.method_6), ref CS$<>8__locals1);
			this.method_1("Shield", new Func<HeroPet, string>(GClass819.<>c.<>c_0.method_7), ref CS$<>8__locals1);
			this.method_1("Mode", new Func<HeroPet, string>(GClass819.<>c.<>c_0.method_8), ref CS$<>8__locals1);
			List<IRowEntry> list_ = CS$<>8__locals1.list_0;
			string key = "Deaths";
			IValueWrapper<string>[] array = new IValueWrapper<string>[1];
			array[0] = base.L<GClass814>(new Func<GClass814, string>(GClass819.<>c.<>c_0.method_9));
			list_.Add(StatisticsCategory.WithName(key, array));
		}
		int num = 0;
		foreach (IRowEntry rowEntry in CS$<>8__locals1.list_0)
		{
			rowEntry.Order = num++;
			base.Add(rowEntry);
		}
		base.Update();
	}

	[CompilerGenerated]
	private IRowEntry method_0(string string_0, Func<HeroPet, string> func_0, ref GClass819.<>c__DisplayClass7_0 <>c__DisplayClass7_0_0)
	{
		return StatisticsCategory.WithName(string_0, new IValueWrapper<string>[]
		{
			base.L<HeroPet>(func_0)
		});
	}

	[CompilerGenerated]
	private void method_1(string string_0, Func<HeroPet, string> func_0, ref GClass819.<>c__DisplayClass7_0 <>c__DisplayClass7_0_0)
	{
		<>c__DisplayClass7_0_0.list_0.Add(this.method_0(string_0, func_0, ref <>c__DisplayClass7_0_0));
	}

	[CompilerGenerated]
	private readonly HeroPet heroPet_0;

	[CompilerGenerated]
	private readonly GClass814 gclass814_0;
}
