using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

public static class GClass28
{
	public class GClass29
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
		public IList<int> IList_6 { get; set; }

		[JsonProperty("pet_related")]
		public IList<int> IList_7 { get; set; }

		public GClass29()
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}

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

		[CompilerGenerated]
		private IList<int> lTxfInDuJk;
	}

	public class GClass30
	{
		[JsonProperty("I")]
		public int Int32_0 { get; set; }

		[JsonProperty("HP")]
		public int HP { get; set; }

		[JsonProperty("L")]
		public int Int32_1 { get; set; }

		[JsonProperty("SM")]
		public string String_0 { get; set; }

		[JsonProperty("M")]
		public IList<string> IList_0 { get; set; }

		public GClass30()
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private int int_2;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private IList<string> ilist_0;
	}

	public class GClass31
	{
		[JsonProperty("ship")]
		public GClass28.GClass30 GClass30_0 { get; set; }

		public GClass31()
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}

		[CompilerGenerated]
		private GClass28.GClass30 gclass30_0;
	}

	public class GClass32
	{
		[JsonProperty("hangarID")]
		public string String_0 { get; set; }

		[JsonProperty("hangar_is_active")]
		public bool Boolean_0 { get; set; }

		[JsonProperty("general")]
		public GClass28.GClass31 GClass31_0 { get; set; }

		public GClass32()
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}

		[CompilerGenerated]
		private string kZiBlMnamx;

		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private GClass28.GClass31 gclass31_0;
	}

	public class GClass33
	{
		[JsonProperty("T")]
		public IList<int> IList_0 { get; set; }

		[JsonProperty("Q")]
		public long Int64_0 { get; set; }

		public GClass33()
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}

		[CompilerGenerated]
		private IList<int> ilist_0;

		[CompilerGenerated]
		private long long_0;
	}

	public class GClass34
	{
		[JsonProperty("T")]
		public IList<int> IList_0 { get; set; }

		[JsonProperty("Q")]
		public long Int64_0 { get; set; }

		public GClass34()
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}

		[CompilerGenerated]
		private IList<int> ilist_0;

		[CompilerGenerated]
		private long long_0;
	}

	public class GClass35
	{
		[JsonProperty("T")]
		public IList<int> IList_0 { get; set; }

		[JsonProperty("Q")]
		public long Int64_0 { get; set; }

		public GClass35()
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}

		[CompilerGenerated]
		private IList<int> ilist_0;

		[CompilerGenerated]
		private long long_0;
	}

	public class GClass36
	{
		[JsonProperty("T")]
		public IList<int> IList_0 { get; set; }

		[JsonProperty("Q")]
		public long Int64_0 { get; set; }

		public GClass36()
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}

		[CompilerGenerated]
		private IList<int> ilist_0;

		[CompilerGenerated]
		private long long_0;
	}

	public class GClass37
	{
		[JsonProperty("lasers")]
		public GClass28.GClass33 ThcrtktaPC { get; set; }

		[JsonProperty("generators")]
		public GClass28.GClass34 GClass34_0 { get; set; }

		[JsonProperty("heavy_guns")]
		public GClass28.GClass35 GClass35_0 { get; set; }

		[JsonProperty("extras")]
		public GClass28.GClass36 GClass36_0 { get; set; }

		public GClass37()
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}

		[CompilerGenerated]
		private GClass28.GClass33 gclass33_0;

		[CompilerGenerated]
		private GClass28.GClass34 gclass34_0;

		[CompilerGenerated]
		private GClass28.GClass35 gclass35_0;

		[CompilerGenerated]
		private GClass28.GClass36 gclass36_0;
	}

	public class GClass38
	{
		[JsonProperty("credits")]
		public long credits { get; set; }

		public GClass38()
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}

		[CompilerGenerated]
		private long long_0;
	}

	public class GClass39
	{
		[JsonProperty("30x30")]
		public string String_0 { get; set; }

		[JsonProperty("63x63")]
		public string String_1 { get; set; }

		[JsonProperty("100x100")]
		public string String_2 { get; set; }

		[JsonProperty("top")]
		public string String_3 { get; set; }

		public GClass39()
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private string string_2;

		[CompilerGenerated]
		private string string_3;
	}

	public class GClass40
	{
		[JsonProperty("slotsets")]
		public GClass28.GClass37 GClass37_0 { get; set; }

		[JsonProperty("selling")]
		public GClass28.GClass38 GClass38_0 { get; set; }

		[JsonProperty("cdn")]
		public GClass28.GClass39 GClass39_0 { get; set; }

		public GClass40()
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}

		[CompilerGenerated]
		private GClass28.GClass37 gclass37_0;

		[CompilerGenerated]
		private GClass28.GClass38 gclass38_0;

		[CompilerGenerated]
		private GClass28.GClass39 gclass39_0;
	}

	public class GClass41
	{
		[JsonProperty("L")]
		public int Int32_0 { get; set; }

		[JsonProperty("name")]
		public string String_0 { get; set; }

		[JsonProperty("T")]
		public int Int32_1 { get; set; }

		[JsonProperty("C")]
		public string C { get; set; }

		public GClass41()
		{
			Class13.xnk8ImWzpOt04();
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
	}

	public class GClass42
	{
		[JsonProperty("uridium")]
		public long Int64_0 { get; set; }

		[JsonProperty("credits")]
		public long credits { get; set; }

		[JsonProperty("isPayment")]
		public int Int32_0 { get; set; }

		public GClass42()
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}

		[CompilerGenerated]
		private long long_0;

		[CompilerGenerated]
		private long long_1;

		[CompilerGenerated]
		private int int_0;
	}

	public class GClass43
	{
		[JsonProperty("lootId")]
		public string lootId { get; set; }

		[JsonProperty("owned")]
		public int Int32_0 { get; set; }

		[JsonProperty("fav")]
		public int Int32_1 { get; set; }

		[JsonProperty("price")]
		public GClass28.GClass42 GClass42_0 { get; set; }

		[JsonProperty("hangarId")]
		public object Object_0 { get; set; }

		[JsonProperty("factionBased")]
		public int Int32_2 { get; set; }

		[JsonProperty("eventItem")]
		public int Int32_3 { get; set; }

		[JsonProperty("eventActive")]
		public int uwsLooJhVL { get; set; }

		public GClass43()
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private GClass28.GClass42 gclass42_0;

		[CompilerGenerated]
		private object object_0;

		[CompilerGenerated]
		private int int_2;

		[CompilerGenerated]
		private int int_3;

		[CompilerGenerated]
		private int int_4;
	}

	public class GClass44
	{
		[JsonProperty("factionRelated")]
		public string String_0 { get; set; }

		public GClass44()
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}

		[CompilerGenerated]
		private string string_0;
	}

	public class GClass45
	{
		[JsonProperty("filters")]
		public GClass28.GClass29 GClass29_0 { get; set; }

		[JsonIgnore]
		public IList<GClass28.GClass32> hangars { get; set; }

		[JsonProperty("userInfo")]
		public GClass28.GClass44 GClass44_0 { get; set; }

		public GClass45()
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}

		[CompilerGenerated]
		private GClass28.GClass29 gclass29_0;

		[CompilerGenerated]
		private IList<GClass28.GClass32> ilist_0;

		[CompilerGenerated]
		private GClass28.GClass44 gclass44_0;
	}

	public class GClass46
	{
		[JsonProperty("uridium")]
		public string String_0 { get; set; }

		[JsonProperty("credits")]
		public string credits { get; set; }

		public GClass46()
		{
			Class13.xnk8ImWzpOt04();
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
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}

		[CompilerGenerated]
		private IList<string> ilist_0;

		[CompilerGenerated]
		private IList<string> ilist_1;
	}

	public class GClass47
	{
		[JsonProperty("ret")]
		public GClass28.GClass45 ret { get; set; }

		[JsonProperty("money")]
		public GClass28.GClass46 GClass46_0 { get; set; }

		[JsonProperty("map")]
		public GClass28.Map Map_0 { get; set; }

		public GClass47()
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}

		[CompilerGenerated]
		private GClass28.GClass45 gclass45_0;

		[CompilerGenerated]
		private GClass28.GClass46 gclass46_0;

		[CompilerGenerated]
		private GClass28.Map map_0;
	}

	public class GClass48
	{
		[JsonProperty("isError")]
		public int Int32_0 { get; set; }

		[JsonProperty("data")]
		public GClass28.GClass47 data { get; set; }

		public GClass48()
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private GClass28.GClass47 gclass47_0;
	}
}
