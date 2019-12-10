using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DarkorbitAPI;

public class GClass78
{
	public DarkOrbitWebAPI Web { get; }

	[CompilerGenerated]
	public GClass78.GClass80 method_0()
	{
		return this.gclass80_0;
	}

	public GClass78(DarkOrbitWebAPI darkOrbitWebAPI_1)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Web = darkOrbitWebAPI_1;
		this.gclass80_0 = new GClass78.GClass80();
	}

	public async Task method_1()
	{
		string sUrl = GClass801.smethod_0(this.Web.Server, "internalSkylab");
		DarkOrbitWebAPI.Response response = await this.Web.GetAsync(sUrl, null);
		response.Data.EnsureSuccessStatusCode();
		this.method_0().method_8(response.Content);
	}

	public async Task<bool> method_2(int int_0, int int_1)
	{
		Dictionary<string, string> data = new Dictionary<string, string>
		{
			{
				"reloadToken",
				this.Web.ReloadToken
			},
			{
				"action",
				"internalSkylab"
			},
			{
				"subaction",
				"startTransport"
			},
			{
				"mode",
				"normal"
			},
			{
				"construction",
				"TRANSPORT_MODULE"
			},
			{
				"count_prometium",
				"0"
			},
			{
				"count_endurium",
				"0"
			},
			{
				"count_terbium",
				"0"
			},
			{
				"count_prometid",
				"0"
			},
			{
				"count_duranium",
				"0"
			},
			{
				"count_xenomit",
				"0"
			},
			{
				"count_promerium",
				string.Format("{0}", int_0)
			},
			{
				"count_seprom",
				string.Format("{0}", int_1)
			}
		};
		DarkOrbitWebAPI.Response response = await this.Web.PostAsync(GClass801.smethod_0(this.Web.Server, null), data, GClass801.smethod_0(this.Web.Server, "internalSkylab"), null);
		bool result;
		if (!response.Data.IsSuccessStatusCode)
		{
			result = false;
		}
		else
		{
			this.method_0().method_8(response.Content);
			result = (this.method_0().method_9("transportModule").method_0() != null);
		}
		return result;
	}

	[CompilerGenerated]
	private readonly DarkOrbitWebAPI darkOrbitWebAPI_0;

	[CompilerGenerated]
	private readonly GClass78.GClass80 gclass80_0;

	public class GClass79
	{
		public bool IsEnabled { get; set; }

		[CompilerGenerated]
		public DateTimeOffset? method_0()
		{
			return this.nullable_0;
		}

		[CompilerGenerated]
		public void method_1(DateTimeOffset? nullable_1)
		{
			this.nullable_0 = nullable_1;
		}

		public string Name { get; set; }

		public int Level { get; set; }

		public GClass79()
		{
			Class8.xDph7tozmh5WD();
			base..ctor();
		}

		// Note: this type is marked as 'beforefieldinit'.
		static GClass79()
		{
			Class8.xDph7tozmh5WD();
			GClass78.GClass79.list_0 = new List<string>
			{
				"baseModule",
				"solarModule",
				"prometiumCollector",
				"enduriumCollector",
				"terbiumCollector",
				"storageModule",
				"prometidRefinery",
				"duraniumRefinery",
				"promeriumRefinery",
				"xenoModule",
				"sepromRefinery",
				"transportModule"
			};
		}

		public static List<string> list_0;

		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private DateTimeOffset? nullable_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private int int_0;
	}

	public class GClass80
	{
		[CompilerGenerated]
		public DateTimeOffset method_0()
		{
			return this.dateTimeOffset_0;
		}

		[CompilerGenerated]
		private void method_1(DateTimeOffset dateTimeOffset_1)
		{
			this.dateTimeOffset_0 = dateTimeOffset_1;
		}

		public ConcurrentDictionary<string, int> Resources { get; }

		public int method_2(string string_0)
		{
			int result;
			if (!this.Resources.TryGetValue(string_0, out result))
			{
				return 0;
			}
			return result;
		}

		public int Promerium
		{
			get
			{
				return this.method_2("resource_ore_promerium");
			}
		}

		public int Seprom
		{
			get
			{
				return this.method_2("resource_ore_seprom");
			}
		}

		[CompilerGenerated]
		public DateTimeOffset? method_3()
		{
			return this.nullable_0;
		}

		[CompilerGenerated]
		public void method_4(DateTimeOffset? nullable_1)
		{
			this.nullable_0 = nullable_1;
		}

		[CompilerGenerated]
		public List<GClass78.GClass79> method_5()
		{
			return this.list_0;
		}

		public GClass80()
		{
			Class8.xDph7tozmh5WD();
			base..ctor();
			this.Resources = new ConcurrentDictionary<string, int>();
			this.list_0 = new List<GClass78.GClass79>();
			foreach (string name in GClass78.GClass79.list_0)
			{
				this.method_5().Add(new GClass78.GClass79
				{
					Name = name
				});
			}
		}

		private void method_6(string string_0)
		{
			foreach (object obj in Regex.Matches(string_0, "<span class=\"ore_(.+?)\">.+?<\\/span><br \\/>\\s+(\\S+)"))
			{
				Match match = (Match)obj;
				string key = "resource_ore_" + match.Groups[1].Value;
				int value;
				if (!int.TryParse(new string(match.Groups[2].Value.Where(new Func<char, bool>(char.IsDigit)).ToArray<char>()), out value))
				{
					value = 0;
				}
				this.Resources[key] = value;
			}
		}

		private void method_7(string string_0)
		{
			Dictionary<string, DateTimeOffset> dictionary = new Dictionary<string, DateTimeOffset>();
			foreach (object obj in Regex.Matches(string_0, "tmp\\.init\\(\\s*'(.+?)',\\s*(.+?),\\s*(.+?)\\s*\\);"))
			{
				Match match = (Match)obj;
				string value = match.Groups[1].Value;
				string value2 = match.Groups[2].Value;
				long seconds = long.Parse(match.Groups[3].Value);
				dictionary[value] = DateTimeOffset.FromUnixTimeSeconds(seconds);
			}
			foreach (GClass78.GClass79 gclass in this.method_5())
			{
				DateTimeOffset value3;
				if (dictionary.TryGetValue(gclass.Name, out value3))
				{
					gclass.method_1(new DateTimeOffset?(value3));
				}
				else
				{
					gclass.method_1(null);
				}
			}
			this.method_4(this.method_9("transportModule").method_0());
		}

		public void method_8(string string_0)
		{
			this.method_6(string_0);
			this.method_7(string_0);
			this.method_1(DateTimeOffset.Now);
		}

		public GClass78.GClass79 method_9(string string_0)
		{
			GClass78.GClass80.<>c__DisplayClass23_0 CS$<>8__locals1 = new GClass78.GClass80.<>c__DisplayClass23_0();
			CS$<>8__locals1.string_0 = string_0;
			return this.method_5().Find(new Predicate<GClass78.GClass79>(CS$<>8__locals1.method_0));
		}

		[CompilerGenerated]
		private DateTimeOffset dateTimeOffset_0;

		[CompilerGenerated]
		private readonly ConcurrentDictionary<string, int> concurrentDictionary_0;

		[CompilerGenerated]
		private DateTimeOffset? nullable_0;

		[CompilerGenerated]
		private readonly List<GClass78.GClass79> list_0;
	}
}
