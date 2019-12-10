using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml.Serialization;
using DarkorbitAPI;
using DOPE.Common.Models;

public class GClass832 : GClass829
{
	[CompilerGenerated]
	public DarkOrbitWebAPI.GalaxyGatesInfo method_2()
	{
		return this.galaxyGatesInfo_0;
	}

	[CompilerGenerated]
	public void method_3(DarkOrbitWebAPI.GalaxyGatesInfo galaxyGatesInfo_1)
	{
		this.galaxyGatesInfo_0 = galaxyGatesInfo_1;
	}

	public GClass832(GClass810 gclass810_1)
	{
		Class8.xDph7tozmh5WD();
		base..ctor(gclass810_1, "GgSpinner");
	}

	public override int Cooldown
	{
		get
		{
			if (!this.method_11())
			{
				return 60000;
			}
			return 1000;
		}
	}

	protected void method_4()
	{
		foreach (DarkOrbitWebAPI.jumpgateGate jumpgateGate in this.method_2().gates)
		{
			if (jumpgateGate.current == jumpgateGate.total && !jumpgateGate.prepared)
			{
				bool argument = false;
				string text;
				string argument2 = GClass832.dictionary_0.TryGetValue(jumpgateGate.id, out text) ? text : "unknown";
				if (this.method_8(jumpgateGate.id))
				{
					jumpgateGate.prepared = true;
					argument = true;
				}
				base.Log.Info<string, bool>("Deploying GG {ggName} success={success}", argument2, argument);
			}
		}
	}

	protected Dictionary<string, bool> method_5()
	{
		AccountSettings account = base.Context.Account;
		return new Dictionary<string, bool>
		{
			{
				"alpha",
				account != null && account.Spinner_Alpha
			},
			{
				"beta",
				account != null && account.Spinner_Beta
			},
			{
				"gamma",
				account != null && account.Spinner_Gamma
			},
			{
				"delta",
				account != null && account.Spinner_Delta
			},
			{
				"epsilon",
				account != null && account.Spinner_Epsilon
			},
			{
				"zeta",
				account != null && account.Spinner_Zeta
			},
			{
				"kappa",
				account != null && account.Spinner_Kappa
			},
			{
				"lambda",
				account != null && account.Spinner_Lambda
			},
			{
				"streuner",
				account != null && account.Spinner_Kuiper
			}
		};
	}

	protected bool method_6(out string string_0, out int int_0)
	{
		string_0 = null;
		Dictionary<string, bool> dictionary = this.method_5();
		int_0 = 0;
		bool flag = true;
		AccountSettings account = base.Context.Account;
		if (account != null && account.Spinner_StopABG)
		{
			foreach (DarkOrbitWebAPI.jumpgateGate jumpgateGate in this.method_2().gates)
			{
				string text;
				string a = GClass832.dictionary_0.TryGetValue(jumpgateGate.id, out text) ? text : "unknown";
				if ((a == "alpha" || a == "beta" || a == "gamma") && jumpgateGate.current == jumpgateGate.total)
				{
					flag = false;
					break;
				}
			}
		}
		foreach (DarkOrbitWebAPI.jumpgateGate jumpgateGate2 in this.method_2().gates)
		{
			string text3;
			string text2 = GClass832.dictionary_0.TryGetValue(jumpgateGate2.id, out text3) ? text3 : "unknown";
			bool flag2;
			if (jumpgateGate2.current != jumpgateGate2.total && dictionary.TryGetValue(text2, out flag2) && flag2 && ((!(text2 == "alpha") && !(text2 == "beta") && !(text2 == "gamma")) || flag))
			{
				string_0 = text2;
				int_0 = jumpgateGate2.id;
				return true;
			}
		}
		return false;
	}

	protected bool method_7()
	{
		GClass832.<>c__DisplayClass11_0 CS$<>8__locals1 = new GClass832.<>c__DisplayClass11_0();
		int num;
		if (!this.method_6(out CS$<>8__locals1.string_0, out num))
		{
			base.Log.Warn("Nothing to spin");
			return false;
		}
		DarkOrbitWebAPI.jumpgateMultiplier jumpgateMultiplier = this.method_2().multipliers.FirstOrDefault(new Func<DarkOrbitWebAPI.jumpgateMultiplier, bool>(CS$<>8__locals1.method_0));
		bool flag = jumpgateMultiplier != null && jumpgateMultiplier.value > 0;
		string text = "&multiplier=" + (flag ? 1 : 0);
		long samples = this.method_2().samples;
		string text2 = "&sample=1";
		DarkOrbitWebAPI web = base.Context.Game.Web;
		DarkOrbitWebAPI.Response response = web.Get(string.Concat(new string[]
		{
			GClass801.smethod_3(web.Server, web.Uid, web.Sid, "multiEnergy"),
			string.Format("&gateID={0}&{1}=1", num, CS$<>8__locals1.string_0),
			text2,
			text,
			"&spinamount=1"
		}), null);
		if (!response.Data.IsSuccessStatusCode)
		{
			return false;
		}
		base.Log.Info("Spinning GG {mode}", CS$<>8__locals1.string_0);
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(DarkOrbitWebAPI.GalaxyGatesInfoUpdate));
		using (StringReader stringReader = new StringReader(response.Content))
		{
			DarkOrbitWebAPI.GalaxyGatesInfoUpdate galaxyGatesInfoUpdate_ = (DarkOrbitWebAPI.GalaxyGatesInfoUpdate)xmlSerializer.Deserialize(stringReader);
			this.method_10(galaxyGatesInfoUpdate_);
		}
		return true;
	}

	protected bool method_8(int int_0)
	{
		DarkOrbitWebAPI web = base.Context.Game.Web;
		return web.Get(GClass801.smethod_3(web.Server, web.Uid, web.Sid, "setupGate") + "&gateID=" + int_0, null).Data.IsSuccessStatusCode;
	}

	protected bool method_9()
	{
		AccountSettings account = base.Context.Account;
		if (account != null && account.Spinner_UseUridium == 0)
		{
			return this.method_2().samples > 0L;
		}
		long num = this.method_2().money - (long)this.method_2().energy_cost.Value;
		AccountSettings account2 = base.Context.Account;
		return num > (long)Math.Max((account2 != null) ? account2.Spinner_UseUridium : 0, 0);
	}

	protected bool method_10(DarkOrbitWebAPI.GalaxyGatesInfoUpdate galaxyGatesInfoUpdate_0)
	{
		this.method_2().mode = galaxyGatesInfoUpdate_0.mode;
		this.method_2().money = galaxyGatesInfoUpdate_0.money;
		this.method_2().samples = galaxyGatesInfoUpdate_0.samples;
		this.method_2().spinOnSale = (int)galaxyGatesInfoUpdate_0.spinOnSale;
		this.method_2().spinSalePercentage = (int)galaxyGatesInfoUpdate_0.spinSalePercentage;
		this.method_2().galaxyGateDay = (int)galaxyGatesInfoUpdate_0.galaxyGateDay;
		this.method_2().bonusRewardsDay = (int)galaxyGatesInfoUpdate_0.bonusRewardsDay;
		this.method_2().spinamount_selected = (int)galaxyGatesInfoUpdate_0.spinamount_selected;
		this.method_2().energy_cost.Value = galaxyGatesInfoUpdate_0.energy_cost.Value;
		DarkOrbitWebAPI.jumpgateMultiplier[] multipliers = galaxyGatesInfoUpdate_0.multipliers;
		for (int i = 0; i < multipliers.Length; i++)
		{
			GClass832.<>c__DisplayClass14_0 CS$<>8__locals1 = new GClass832.<>c__DisplayClass14_0();
			CS$<>8__locals1.jumpgateMultiplier_0 = multipliers[i];
			DarkOrbitWebAPI.jumpgateMultiplier jumpgateMultiplier = this.method_2().multipliers.FirstOrDefault(new Func<DarkOrbitWebAPI.jumpgateMultiplier, bool>(CS$<>8__locals1.method_0));
			if (jumpgateMultiplier != null)
			{
				jumpgateMultiplier.state = CS$<>8__locals1.jumpgateMultiplier_0.state;
				jumpgateMultiplier.value = CS$<>8__locals1.jumpgateMultiplier_0.value;
			}
		}
		bool result = false;
		DarkOrbitWebAPI.jumpgateItem[] items = galaxyGatesInfoUpdate_0.items;
		for (int i = 0; i < items.Length; i++)
		{
			GClass832.<>c__DisplayClass14_1 CS$<>8__locals2 = new GClass832.<>c__DisplayClass14_1();
			CS$<>8__locals2.jumpgateItem_0 = items[i];
			if (CS$<>8__locals2.jumpgateItem_0.type == "part" && (!CS$<>8__locals2.jumpgateItem_0.duplicateSpecified || !CS$<>8__locals2.jumpgateItem_0.duplicate))
			{
				DarkOrbitWebAPI.jumpgateGate jumpgateGate = this.method_2().gates.FirstOrDefault(new Func<DarkOrbitWebAPI.jumpgateGate, bool>(CS$<>8__locals2.method_0));
				if (jumpgateGate != null)
				{
					jumpgateGate.current = CS$<>8__locals2.jumpgateItem_0.current;
					jumpgateGate.total = CS$<>8__locals2.jumpgateItem_0.total;
					jumpgateGate.state = CS$<>8__locals2.jumpgateItem_0.state;
					result = (jumpgateGate.current == jumpgateGate.total);
				}
			}
		}
		return result;
	}

	[CompilerGenerated]
	public bool method_11()
	{
		return this.bool_1;
	}

	[CompilerGenerated]
	public void method_12(bool bool_2)
	{
		this.bool_1 = bool_2;
	}

	public override void Execute()
	{
		AccountSettings account = base.Context.Account;
		int millisecondsTimeout = (account != null) ? account.Spinner_SpinDelay : 250;
		this.method_3(base.Context.Game.Web.GgInfo);
		this.method_12(false);
		AccountSettings account2 = base.Context.Account;
		if (account2 != null && account2.Spinner_PlaceGates)
		{
			this.method_4();
		}
		int num = 0;
		while (num < 6 && this.method_9() && this.method_7())
		{
			GClass803 stats = base.Context.Stats;
			int spins = stats.Spins;
			stats.Spins = spins + 1;
			Thread.Sleep(millisecondsTimeout);
			num++;
		}
		this.method_12(num == 6);
	}

	private bool method_13()
	{
		if (base.Context.Game.Web.GgInfo == null)
		{
			return false;
		}
		AccountSettings account = base.Context.Account;
		return account != null && account.Spinner_Enabled;
	}

	public override bool vmethod_0()
	{
		if (!this.method_13())
		{
			return false;
		}
		string activeHangarName = base.Context.Game.Web.Equipment.ActiveHangarName;
		AccountSettings account = base.Context.Account;
		return account == null || !account.Spinner_UsePhoenix || GClass813.list_0.Contains(activeHangarName);
	}

	public int method_14()
	{
		DarkOrbitWebAPI.GalaxyGatesInfo ggInfo = base.Context.Game.Web.GgInfo;
		if (!this.method_13())
		{
			return 0;
		}
		int result = (int)ggInfo.samples;
		AccountSettings account = base.Context.Account;
		if (account != null && account.Spinner_UseUridium == 0)
		{
			return result;
		}
		return (int)ggInfo.samples + (int)(Math.Max(0L, ggInfo.money - (long)base.Context.Account.Spinner_UseUridium) / (long)ggInfo.energy_cost.Value);
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass832()
	{
		Class8.xDph7tozmh5WD();
		GClass832.dictionary_0 = new Dictionary<int, string>
		{
			{
				1,
				"alpha"
			},
			{
				2,
				"beta"
			},
			{
				3,
				"gamma"
			},
			{
				4,
				"delta"
			},
			{
				5,
				"epsilon"
			},
			{
				6,
				"zeta"
			},
			{
				7,
				"kappa"
			},
			{
				8,
				"lambda"
			},
			{
				19,
				"streuner"
			}
		};
	}

	[CompilerGenerated]
	private DarkOrbitWebAPI.GalaxyGatesInfo galaxyGatesInfo_0;

	public static Dictionary<int, string> dictionary_0;

	[CompilerGenerated]
	private bool bool_1;
}
