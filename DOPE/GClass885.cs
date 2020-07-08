using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using DarkorbitAPI.Structures;
using DOPE.Common;
using DOPE.Common.Models.Bot.Stats;
using xcwaDuiebvuNrIkSlmL;

public class GClass885 : StatisticsCategory
{
	public Hero Hero { get; }

	public GClass881 Stats { get; }

	public GClass885(Hero hero_1, GClass881 gclass881_1)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor("Hero", new string[]
		{
			"Name",
			"Value"
		}, null);
		this.Hero = hero_1;
		this.Stats = gclass881_1;
		base.Subscribe<Hero>(this.Hero);
		base.Subscribe<GClass881>(this.Stats);
	}

	private void method_0(List<IRowEntry> list_2)
	{
		List<IRowEntry> list = new List<IRowEntry>();
		using (IEnumerator<KeyValuePair<string, double>> enumerator = this.Hero.Ammo.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GClass885.<>c__DisplayClass9_0 CS$<>8__locals1 = new GClass885.<>c__DisplayClass9_0();
				CS$<>8__locals1.keyValuePair_0 = enumerator.Current;
				list.Add(StatisticsCategory.WithName(CS$<>8__locals1.keyValuePair_0.Key.ToPascal(), new IValueWrapper<string>[]
				{
					base.L<Hero>(new Func<Hero, string>(CS$<>8__locals1.method_0))
				}));
			}
		}
		foreach (IRowEntry item in list.OrderBy(new Func<IRowEntry, double>(GClass885.<>c.<>c_0.method_0)).ThenBy(new Func<IRowEntry, string>(GClass885.<>c.<>c_0.method_1)))
		{
			list_2.Add(item);
		}
	}

	private void method_1(List<IRowEntry> list_2)
	{
		List<IRowEntry> list = new List<IRowEntry>();
		foreach (string text in GClass885.list_0)
		{
			string text2 = "resource_" + text;
			if (this.Hero.Resources.ContainsKey(text2))
			{
				list_2.Add(StatisticsCategory.WithName("Cargo_" + text.ToPascal(), new IValueWrapper<string>[]
				{
					this.method_2(text2)
				}));
			}
		}
		foreach (KeyValuePair<string, double> keyValuePair in this.Hero.Resources)
		{
			if (!GClass885.list_0.Contains(keyValuePair.Key.Replace("resource_", "")))
			{
				list.Add(StatisticsCategory.WithName(keyValuePair.Key.Replace("resource_collectable", "Materials").ToPascal(), new IValueWrapper<string>[]
				{
					this.method_2(keyValuePair.Key)
				}));
			}
		}
		foreach (IRowEntry item in list.OrderBy(new Func<IRowEntry, string>(GClass885.<>c.<>c_0.method_2)))
		{
			list_2.Add(item);
		}
	}

	public override void Update()
	{
		List<IRowEntry> list = new List<IRowEntry>();
		list.Add(this.method_3("In game", new Func<Hero, string>(GClass885.<>c.<>c_0.method_3)));
		list.Add(this.method_3("Name", new Func<Hero, string>(GClass885.<>c.<>c_0.method_4)));
		list.Add(this.method_3("Clan", new Func<Hero, string>(GClass885.<>c.<>c_0.method_5)));
		list.Add(this.method_3("Credits", new Func<Hero, string>(GClass885.<>c.<>c_0.method_6)));
		list.Add(this.method_3("Uridium", new Func<Hero, string>(GClass885.<>c.<>c_0.method_7)));
		list.Add(this.method_3("Level", new Func<Hero, string>(GClass885.<>c.<>c_0.method_8)));
		list.Add(this.method_3("Experience", new Func<Hero, string>(GClass885.<>c.<>c_0.method_9)));
		list.Add(this.method_3("Honor", new Func<Hero, string>(GClass885.<>c.<>c_0.method_10)));
		list.Add(this.method_3("Booty keys", new Func<Hero, string>(GClass885.<>c.<>c_0.method_11)));
		list.Add(this.method_3("Map", new Func<Hero, string>(GClass885.<>c.<>c_0.method_12)));
		list.Add(this.method_4("TypeId", new Func<Hero, string>(GClass885.<>c.<>c_0.method_13)));
		list.Add(this.method_4("Cloaked", new Func<Hero, string>(GClass885.<>c.<>c_0.method_14)));
		list.Add(this.method_4("Speed", new Func<Hero, string>(GClass885.<>c.<>c_0.method_15)));
		list.Add(this.method_4("HP", new Func<Hero, string>(GClass885.<>c.<>c_0.method_16)));
		list.Add(this.method_4("Shield", new Func<Hero, string>(GClass885.<>c.<>c_0.method_17)));
		list.Add(this.method_4("Config", new Func<Hero, string>(GClass885.<>c.<>c_0.cHiwikZopOH)));
		list.Add(this.method_4("Formation", new Func<Hero, string>(GClass885.<>c.<>c_0.method_18)));
		list.Add(this.method_4("Cargo", new Func<Hero, string>(GClass885.<>c.<>c_0.method_19)));
		List<IRowEntry> list2 = list;
		this.method_0(list2);
		this.method_1(list2);
		int num = 0;
		foreach (IRowEntry rowEntry in list2)
		{
			rowEntry.Order = num++;
			base.Add(rowEntry);
		}
		base.Update();
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass885()
	{
		Class13.xnk8ImWzpOt04();
		GClass885.list_0 = new List<string>
		{
			"prometium",
			"endurium",
			"terbium",
			"duranium",
			"prometid",
			"promerium",
			"seprom",
			"xenomit",
			"palladium"
		};
		GClass885.list_1 = new List<string>
		{
			"ammunition_laser_lcb-10",
			"ammunition_laser_mcb-25",
			"ammunition_laser_mcb-50",
			"ammunition_laser_ucb-100",
			"ammunition_laser_job-100",
			"ammunition_laser_sab-50",
			"ammunition_rocket_r-310",
			"ammunition_rocket_plt-2026",
			"ammunition_rocket_plt-2021",
			"ammunition_rocket_plt-3030",
			"ammunition_rocketlauncher_eco-10",
			"ammunition_rocketlauncher_hstrm-01",
			"ammunition_rocketlauncher_ubr-100"
		};
	}

	[CompilerGenerated]
	private LazyBindingValue<string, Hero> method_2(string string_0)
	{
		GClass885.<>c__DisplayClass10_0 CS$<>8__locals1 = new GClass885.<>c__DisplayClass10_0();
		CS$<>8__locals1.string_0 = string_0;
		return base.L<Hero>(new Func<Hero, string>(CS$<>8__locals1.method_0));
	}

	[CompilerGenerated]
	private IRowEntry method_3(string string_0, Func<Hero, string> func_0)
	{
		return StatisticsCategory.WithName(string_0, new IValueWrapper<string>[]
		{
			base.L<Hero>(func_0)
		});
	}

	[CompilerGenerated]
	private IRowEntry method_4(string string_0, Func<Hero, string> func_0)
	{
		return StatisticsCategory.WithName("Ship_" + string_0, new IValueWrapper<string>[]
		{
			base.L<Hero>(func_0)
		});
	}

	[CompilerGenerated]
	private readonly Hero hero_0;

	[CompilerGenerated]
	private readonly GClass881 gclass881_0;

	public static readonly List<string> list_0;

	public static readonly List<string> list_1;
}
