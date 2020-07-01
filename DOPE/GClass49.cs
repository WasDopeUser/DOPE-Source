using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

public static class GClass49
{
	public class GClass50
	{
		[JsonProperty("weapons")]
		public IList<int> IList_0 { get; set; }

		[JsonProperty("generators")]
		public IList<int> IList_1 { get; set; }

		[JsonProperty("extras")]
		public IList<int> IList_2 { get; set; }

		[JsonProperty("ammunition")]
		public IList<int> IList_3 { get; set; }

		[JsonProperty("resources")]
		public IList<int> IList_4 { get; set; }

		[JsonProperty("drone_related")]
		public IList<int> IList_5 { get; set; }

		[JsonProperty("modules")]
		public IList<int> QnVmnvUlbq { get; set; }

		[JsonProperty("pet_related")]
		public IList<int> IList_6 { get; set; }

		public GClass50()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private IList<int> GjomEsTwo8;

		[CompilerGenerated]
		private IList<int> ilist_0;

		[CompilerGenerated]
		private IList<int> ilist_1;

		[CompilerGenerated]
		private IList<int> ilist_2;

		[CompilerGenerated]
		private IList<int> ilist_3;

		[CompilerGenerated]
		private IList<int> ilist_4;

		[CompilerGenerated]
		private IList<int> ilist_5;

		[CompilerGenerated]
		private IList<int> ilist_6;
	}

	public class GClass51
	{
		[JsonProperty("I")]
		public int Int32_0 { get; set; }

		[JsonProperty("HP")]
		public string HP { get; set; }

		[JsonProperty("L")]
		public int Int32_1 { get; set; }

		[JsonProperty("SM")]
		public string String_0 { get; set; }

		[JsonProperty("M")]
		public IList<string> IList_0 { get; set; }

		[JsonProperty("SCE")]
		public int Int32_2 { get; set; }

		[JsonProperty("SCU")]
		public int Int32_3 { get; set; }

		public GClass51()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private IList<string> lxlrewMktF;

		[CompilerGenerated]
		private int int_2;

		[CompilerGenerated]
		private int int_3;
	}

	public class GClass52
	{
		[JsonProperty("I")]
		public string String_0 { get; set; }

		[JsonProperty("L")]
		public int Int32_0 { get; set; }

		[JsonProperty("LV")]
		public int Int32_1 { get; set; }

		[JsonProperty("HP")]
		public string HP { get; set; }

		[JsonProperty("EF")]
		public string String_1 { get; set; }

		[JsonProperty("SP")]
		public int Int32_2 { get; set; }

		[JsonProperty("DE")]
		public string String_2 { get; set; }

		[JsonProperty("CU")]
		public string String_3 { get; set; }

		[JsonProperty("DL")]
		public int? Nullable_0 { get; set; }

		[JsonProperty("SL")]
		public int? Nullable_1 { get; set; }

		[JsonProperty("repair")]
		public int Int32_3 { get; set; }

		[JsonProperty("currency")]
		public string String_4 { get; set; }

		public GClass52()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private string ythrYutZex;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private int int_2;

		[CompilerGenerated]
		private string string_2;

		[CompilerGenerated]
		private string string_3;

		[CompilerGenerated]
		private int? nullable_0;

		[CompilerGenerated]
		private int? nullable_1;

		[CompilerGenerated]
		private int int_3;

		[CompilerGenerated]
		private string string_4;
	}

	public class GClass53
	{
		[JsonProperty("ship")]
		public GClass49.GClass51 GClass51_0 { get; set; }

		[JsonProperty("drones")]
		public IList<GClass49.GClass52> IList_0 { get; set; }

		public GClass53()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private GClass49.GClass51 gclass51_0;

		[CompilerGenerated]
		private IList<GClass49.GClass52> ilist_0;
	}

	public class GClass54
	{
		[JsonProperty("hangarID")]
		public int Int32_0 { get; set; }

		[JsonProperty("hangar_is_active")]
		public bool Boolean_0 { get; set; }

		[JsonProperty("general")]
		public GClass49.GClass53 GClass53_0 { get; set; }

		public GClass54()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private GClass49.GClass53 gclass53_0;
	}

	public class GClass55
	{
		[JsonProperty("durability")]
		public object Object_0 { get; set; }

		[JsonProperty("active")]
		public object Object_1 { get; set; }

		[JsonProperty("attachedAmmo")]
		public string String_0 { get; set; }

		[JsonProperty("installDate")]
		public string String_1 { get; set; }

		[JsonProperty("hitPoints")]
		public string String_2 { get; set; }

		public GClass55()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private object object_0;

		[CompilerGenerated]
		private object object_1;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private string string_2;
	}

	public class GClass56
	{
		[JsonProperty("I")]
		public string String_0 { get; set; }

		[JsonProperty("LV")]
		public int Int32_0 { get; set; }

		[JsonProperty("L")]
		public int Int32_1 { get; set; }

		[JsonIgnore]
		public string String_1 { get; set; }

		[JsonProperty("S")]
		public int S { get; set; }

		[JsonProperty("EQH")]
		public string String_2 { get; set; }

		[JsonProperty("EQC")]
		public string String_3 { get; set; }

		[JsonProperty("EQT")]
		public string String_4 { get; set; }

		[JsonProperty("properties")]
		public GClass49.GClass55 GClass55_0 { get; set; }

		[JsonProperty("CH")]
		public string String_5 { get; set; }

		[JsonProperty("Q")]
		public long? Nullable_0 { get; set; }

		[JsonIgnore]
		public long Count
		{
			get
			{
				long? num = this.Nullable_0;
				if (num == null)
				{
					return 1L;
				}
				return num.GetValueOrDefault();
			}
		}

		[JsonProperty("IN")]
		public bool? Nullable_1 { get; set; }

		[JsonProperty("HP")]
		public int? HP { get; set; }

		[JsonProperty("MHP")]
		public int? Nullable_2 { get; set; }

		[JsonProperty("RC")]
		public int? Nullable_3 { get; set; }

		[JsonIgnore]
		public GClass49.GClass69 GClass69_0 { get; set; }

		public GClass56()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private int int_2;

		[CompilerGenerated]
		private string string_2;

		[CompilerGenerated]
		private string string_3;

		[CompilerGenerated]
		private string string_4;

		[CompilerGenerated]
		private GClass49.GClass55 gclass55_0;

		[CompilerGenerated]
		private string string_5;

		[CompilerGenerated]
		private long? nullable_0;

		[CompilerGenerated]
		private bool? nullable_1;

		[CompilerGenerated]
		private int? nullable_2;

		[CompilerGenerated]
		private int? nullable_3;

		[CompilerGenerated]
		private int? nullable_4;

		[CompilerGenerated]
		private GClass49.GClass69 gclass69_0;
	}

	public class GClass57
	{
		[JsonProperty("T")]
		public IList<int> IList_0 { get; set; }

		[JsonProperty("Q")]
		public long Int64_0 { get; set; }

		public GClass57()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private IList<int> ilist_0;

		[CompilerGenerated]
		private long long_0;
	}

	public class GClass58
	{
		[JsonProperty("T")]
		public IList<int> IList_0 { get; set; }

		[JsonProperty("Q")]
		public long Int64_0 { get; set; }

		public GClass58()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private IList<int> ilist_0;

		[CompilerGenerated]
		private long long_0;
	}

	public class GClass59
	{
		[JsonProperty("T")]
		public IList<int> IList_0 { get; set; }

		[JsonProperty("Q")]
		public long Int64_0 { get; set; }

		public GClass59()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private IList<int> ilist_0;

		[CompilerGenerated]
		private long long_0;
	}

	public class GClass60
	{
		[JsonProperty("T")]
		public IList<int> IList_0 { get; set; }

		[JsonProperty("Q")]
		public long Int64_0 { get; set; }

		public GClass60()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private IList<int> ilist_0;

		[CompilerGenerated]
		private long long_0;
	}

	public class GClass61
	{
		[JsonProperty("T")]
		public IList<int> IList_0 { get; set; }

		[JsonProperty("Q")]
		public long Int64_0 { get; set; }

		public GClass61()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private IList<int> ilist_0;

		[CompilerGenerated]
		private long nXaeTiDuFH;
	}

	public class GClass62
	{
		[JsonProperty("T")]
		public IList<int> IList_0 { get; set; }

		[JsonProperty("Q")]
		public long Int64_0 { get; set; }

		public GClass62()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private IList<int> ilist_0;

		[CompilerGenerated]
		private long long_0;
	}

	public class GClass63
	{
		[JsonProperty("T")]
		public IList<int> IList_0 { get; set; }

		[JsonProperty("Q")]
		public long Int64_0 { get; set; }

		public GClass63()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private IList<int> ilist_0;

		[CompilerGenerated]
		private long long_0;
	}

	public class GClass64
	{
		[JsonProperty("lasers")]
		public GClass49.GClass57 GClass57_0 { get; set; }

		[JsonProperty("generators")]
		public GClass49.GClass58 GClass58_0 { get; set; }

		[JsonProperty("heavy_guns")]
		public GClass49.GClass59 GClass59_0 { get; set; }

		[JsonProperty("extras")]
		public GClass49.GClass60 GClass60_0 { get; set; }

		[JsonProperty("default")]
		public GClass49.GClass61 GClass61_0 { get; set; }

		[JsonProperty("design")]
		public GClass49.GClass62 GClass62_0 { get; set; }

		[JsonProperty("visual")]
		public GClass49.GClass63 GClass63_0 { get; set; }

		public GClass64()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private GClass49.GClass57 gclass57_0;

		[CompilerGenerated]
		private GClass49.GClass58 gclass58_0;

		[CompilerGenerated]
		private GClass49.GClass59 gclass59_0;

		[CompilerGenerated]
		private GClass49.GClass60 gclass60_0;

		[CompilerGenerated]
		private GClass49.GClass61 gclass61_0;

		[CompilerGenerated]
		private GClass49.GClass62 gclass62_0;

		[CompilerGenerated]
		private GClass49.GClass63 gclass63_0;
	}

	public class GClass65
	{
		[JsonProperty("30x30")]
		public string String_0 { get; set; }

		[JsonProperty("63x63")]
		public string String_1 { get; set; }

		[JsonProperty("100x100")]
		public string String_2 { get; set; }

		[JsonProperty("top")]
		public string String_3 { get; set; }

		public GClass65()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private string YbxhhxLriL;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private string string_2;
	}

	public class GClass66
	{
		[JsonProperty("credits")]
		public long credits { get; set; }

		public GClass66()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private long long_0;
	}

	public class GClass67
	{
		[JsonProperty("slotsets")]
		public GClass49.GClass64 GClass64_0 { get; set; }

		[JsonProperty("cdn")]
		public GClass49.GClass65 GClass65_0 { get; set; }

		[JsonProperty("selling")]
		public GClass49.GClass66 GClass66_0 { get; set; }

		public GClass67()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private GClass49.GClass64 gclass64_0;

		[CompilerGenerated]
		private GClass49.GClass65 gclass65_0;

		[CompilerGenerated]
		private GClass49.GClass66 gclass66_0;
	}

	public class GClass68
	{
		[JsonProperty("%TIME%")]
		public int Int32_0 { get; set; }

		[JsonProperty("%AMOUNT%")]
		public int Int32_1 { get; set; }

		public GClass68()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;
	}

	public class GClass69
	{
		[JsonProperty("L")]
		public int Int32_0 { get; set; }

		[JsonIgnore]
		public string String_0 { get; set; }

		[JsonProperty("name")]
		public string String_1 { get; set; }

		[JsonProperty("T")]
		public int Int32_1 { get; set; }

		[JsonIgnore]
		public string Type { get; set; }

		[JsonProperty("C")]
		public string String_2 { get; set; }

		[JsonIgnore]
		public IList<GClass49.GClass67> IList_0 { get; set; }

		[JsonProperty("repair")]
		public int? Nullable_0 { get; set; }

		[JsonProperty("textReplace")]
		public GClass49.GClass68 GClass68_0 { get; set; }

		public GClass69()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private string string_2;

		[CompilerGenerated]
		private string string_3;

		[CompilerGenerated]
		private IList<GClass49.GClass67> ilist_0;

		[CompilerGenerated]
		private int? nullable_0;

		[CompilerGenerated]
		private GClass49.GClass68 gclass68_0;
	}

	public class GClass70
	{
		[JsonProperty("uridium")]
		public long Int64_0 { get; set; }

		[JsonProperty("credits")]
		public long credits { get; set; }

		[JsonProperty("isPayment")]
		public int Int32_0 { get; set; }

		public GClass70()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private long long_0;

		[CompilerGenerated]
		private long long_1;

		[CompilerGenerated]
		private int int_0;
	}

	public class GClass71
	{
		[JsonProperty("lootId")]
		public string lootId { get; set; }

		[JsonProperty("owned")]
		public int Int32_0 { get; set; }

		[JsonProperty("fav")]
		public int Int32_1 { get; set; }

		[JsonProperty("price")]
		public GClass49.GClass70 GClass70_0 { get; set; }

		[JsonProperty("hangarId")]
		public object Object_0 { get; set; }

		[JsonProperty("factionBased")]
		public int Int32_2 { get; set; }

		[JsonProperty("eventItem")]
		public int Int32_3 { get; set; }

		[JsonProperty("eventActive")]
		public int Int32_4 { get; set; }

		public GClass71()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private GClass49.GClass70 gclass70_0;

		[CompilerGenerated]
		private object object_0;

		[CompilerGenerated]
		private int int_2;

		[CompilerGenerated]
		private int int_3;

		[CompilerGenerated]
		private int int_4;
	}

	public class GClass72
	{
		[JsonProperty("factionRelated")]
		public string String_0 { get; set; }

		public GClass72()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private string string_0;
	}

	public class GClass73
	{
		[JsonProperty("filters")]
		public GClass49.GClass50 GClass50_0 { get; set; }

		[JsonIgnore]
		public IList<GClass49.GClass54> hangars { get; set; }

		[JsonProperty("items")]
		public IList<GClass49.GClass56> items { get; set; }

		[JsonProperty("itemInfo")]
		public IList<GClass49.GClass69> IList_0 { get; set; }

		[JsonProperty("shipInfo")]
		public IList<GClass49.GClass71> IList_1 { get; set; }

		[JsonProperty("userInfo")]
		public GClass49.GClass72 GClass72_0 { get; set; }

		public GClass73()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private GClass49.GClass50 gclass50_0;

		[CompilerGenerated]
		private IList<GClass49.GClass54> ilist_0;

		[CompilerGenerated]
		private IList<GClass49.GClass56> ilist_1;

		[CompilerGenerated]
		private IList<GClass49.GClass69> ilist_2;

		[CompilerGenerated]
		private IList<GClass49.GClass71> ilist_3;

		[CompilerGenerated]
		private GClass49.GClass72 gclass72_0;
	}

	public class GClass74
	{
		[JsonProperty("uridium")]
		public string String_0 { get; set; }

		[JsonProperty("credits")]
		public string credits { get; set; }

		public GClass74()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;
	}

	public class Map
	{
		[JsonProperty("types")]
		public IList<string> IList_0 { get; set; }

		[JsonProperty("lootIds")]
		public IList<string> IList_1 { get; set; }

		public Map()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private IList<string> ilist_0;

		[CompilerGenerated]
		private IList<string> ilist_1;
	}

	public class GClass75
	{
		[JsonProperty("ret")]
		public GClass49.GClass73 ret { get; set; }

		[JsonProperty("money")]
		public GClass49.GClass74 GClass74_0 { get; set; }

		[JsonProperty("map")]
		public GClass49.Map Map_0 { get; set; }

		public GClass75()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private GClass49.GClass73 gclass73_0;

		[CompilerGenerated]
		private GClass49.GClass74 gclass74_0;

		[CompilerGenerated]
		private GClass49.Map map_0;
	}

	public class GClass76
	{
		[JsonProperty("isError")]
		public int Int32_0 { get; set; }

		[JsonProperty("data")]
		public GClass49.GClass75 data { get; set; }

		public void Fill()
		{
			if (this.Int32_0 != 0)
			{
				return;
			}
			Dictionary<int, GClass49.GClass69> dictionary = new Dictionary<int, GClass49.GClass69>();
			foreach (GClass49.GClass69 gclass in this.data.ret.IList_0)
			{
				gclass.String_0 = this.data.Map_0.IList_1[gclass.Int32_0];
				dictionary[gclass.Int32_0] = gclass;
			}
			foreach (GClass49.GClass56 gclass2 in this.data.ret.items)
			{
				gclass2.String_1 = this.data.Map_0.IList_1[gclass2.Int32_1];
				GClass49.GClass69 gclass3;
				gclass2.GClass69_0 = (dictionary.TryGetValue(gclass2.Int32_1, out gclass3) ? gclass3 : null);
			}
		}

		public List<GClass49.GClass56> method_0(string feAGBpCaC0xkFA1Lf3S)
		{
			List<GClass49.GClass56> list = new List<GClass49.GClass56>();
			foreach (GClass49.GClass56 gclass in this.data.ret.items)
			{
				if (gclass.String_1 == feAGBpCaC0xkFA1Lf3S)
				{
					list.Add(gclass);
				}
			}
			return list;
		}

		public GClass49.GClass56 method_1(string wJJLNbCGMKZ6xhkQ6xW)
		{
			foreach (GClass49.GClass56 gclass in this.data.ret.items)
			{
				if (gclass.String_1 == wJJLNbCGMKZ6xhkQ6xW)
				{
					return gclass;
				}
			}
			return null;
		}

		public long method_2(string SXY67NCpjtdtUQHDeoH)
		{
			GClass49.GClass56 gclass = this.method_1(SXY67NCpjtdtUQHDeoH);
			if (gclass == null)
			{
				return 0L;
			}
			return gclass.Count;
		}

		public GClass76()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private GClass49.GClass75 gclass75_0;
	}
}
