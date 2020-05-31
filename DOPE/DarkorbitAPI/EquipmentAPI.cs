using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DarkorbitAPI
{
	public class EquipmentAPI
	{
		public GClass28.GClass48 Hangars { get; private set; }

		public GClass10.GClass27 ShipDetails { get; private set; }

		public GClass49.GClass76 Hangar { get; private set; }

		public string ActiveHangarName
		{
			get
			{
				if (this.Web.Game.Connection.Socket.method_2() && this.Web.Game.Hero.IsInitialized)
				{
					return this.Web.Game.Hero.TypeId;
				}
				GClass49.GClass76 hangar = this.Hangar;
				if (hangar == null)
				{
					return null;
				}
				GClass49.GClass75 data = hangar.data;
				if (data == null)
				{
					return null;
				}
				GClass49.GClass73 ret = data.ret;
				if (ret == null)
				{
					return null;
				}
				IList<GClass49.GClass54> hangars = ret.hangars;
				if (hangars == null)
				{
					return null;
				}
				GClass49.GClass54 gclass = hangars.FirstOrDefault<GClass49.GClass54>();
				if (gclass == null)
				{
					return null;
				}
				GClass49.GClass53 gclass53_ = gclass.GClass53_0;
				if (gclass53_ == null)
				{
					return null;
				}
				GClass49.GClass51 gclass51_ = gclass53_.GClass51_0;
				if (gclass51_ == null)
				{
					return null;
				}
				return gclass51_.String_0;
			}
		}

		public Dictionary<GClass49.GClass69, List<GClass49.GClass56>> Items { get; private set; }

		public DarkOrbitWebAPI Web { get; private set; }

		public EquipmentAPI(DarkOrbitWebAPI web)
		{
			Class13.NP5bWyNzLwONS();
			base..ctor();
			this.Web = web;
		}

		public GClass28.GClass48 GetHangarList()
		{
			string text = this.Web.Post(GClass829.smethod_8(this.Web.Server), new Dictionary<string, string>
			{
				{
					"params",
					"e30="
				},
				{
					"action",
					"getHangarList"
				}
			}, "https://darkorbit.com", null).Content.smethod_0();
			GClass28.GClass48 gclass = JsonConvert.DeserializeObject<GClass28.GClass48>(text);
			JToken value = JObject.Parse(text).Value<JObject>("data").Value<JObject>("ret").GetValue("hangars");
			IList<GClass28.GClass32> list = null;
			try
			{
				list = (List<GClass28.GClass32>)value.ToObject(typeof(List<GClass28.GClass32>));
			}
			catch
			{
			}
			GClass28.GClass48 result;
			try
			{
				if (list == null)
				{
					list = (from t in (Dictionary<int, GClass28.GClass32>)value.ToObject(typeof(Dictionary<int, GClass28.GClass32>))
					select t.Value).ToList<GClass28.GClass32>();
				}
				goto IL_E4;
			}
			catch
			{
				result = null;
			}
			return result;
			IL_E4:
			gclass.data.ret.hangars = list;
			return this.Hangars = gclass;
		}

		public GClass10.GClass27 GetDetails(GClass28.GClass32 hangar)
		{
			string string_ = string.Format("{{\"params\":{{\"lootId\":\"{0}\",\"hi\":{1},\"hangarId\":\"{2}\"}}}}", hangar.GClass31_0.GClass30_0, hangar.String_0, hangar.String_0);
			DarkOrbitWebAPI.Response response = this.Web.Post(GClass829.smethod_8(this.Web.Server), new Dictionary<string, string>
			{
				{
					"action",
					"getShipDetails"
				},
				{
					"params",
					string_.smethod_1()
				}
			}, "https://darkorbit.com", null);
			return this.ShipDetails = JsonConvert.DeserializeObject<GClass10.GClass27>(response.Content.smethod_0());
		}

		public GClass49.GClass76 GetHangar()
		{
			return this.Hangar = this.GetHangar(int.Parse(this.Hangars.data.ret.hangars.First((GClass28.GClass32 t) => t.Boolean_0).String_0));
		}

		public GClass49.GClass76 GetHangar(int id)
		{
			string string_ = string.Format("{{\"params\":{{\"hi\":{0}}}}}", id);
			string text = this.Web.Post(GClass829.smethod_8(this.Web.Server), new Dictionary<string, string>
			{
				{
					"action",
					"getHangar"
				},
				{
					"params",
					string_.smethod_1()
				}
			}, "https://darkorbit.com", null).Content.smethod_0();
			GClass49.GClass76 gclass = JsonConvert.DeserializeObject<GClass49.GClass76>(text);
			JToken value = JObject.Parse(text).Value<JObject>("data").Value<JObject>("ret").GetValue("hangars");
			IList<GClass49.GClass54> list = null;
			try
			{
				list = (List<GClass49.GClass54>)value.ToObject(typeof(List<GClass49.GClass54>));
			}
			catch (Exception)
			{
			}
			GClass49.GClass76 result;
			try
			{
				if (list == null)
				{
					list = (from t in (Dictionary<int, GClass49.GClass54>)value.ToObject(typeof(Dictionary<int, GClass49.GClass54>))
					select t.Value).ToList<GClass49.GClass54>();
				}
				goto IL_F8;
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
			IL_F8:
			gclass.data.ret.hangars = list;
			gclass.Fill();
			return gclass;
		}

		public Dictionary<GClass49.GClass69, List<GClass49.GClass56>> GetItemList(GClass49.GClass76 hangar)
		{
			if (this.Items == null)
			{
				this.Items = new Dictionary<GClass49.GClass69, List<GClass49.GClass56>>();
			}
			this.Items.Clear();
			List<GClass49.GClass56>[] array = new List<GClass49.GClass56>[this.Hangar.data.ret.IList_0.Count + 1];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new List<GClass49.GClass56>();
			}
			foreach (GClass49.GClass56 gclass in this.Hangar.data.ret.items)
			{
				array[gclass.Int32_1].Add(gclass);
			}
			foreach (GClass49.GClass69 gclass2 in this.Hangar.data.ret.IList_0)
			{
				this.Items.Add(gclass2, array[gclass2.Int32_0]);
			}
			return this.Items;
		}

		public static bool HasNoError(DarkOrbitWebAPI.Response response)
		{
			try
			{
				return response.Data.IsSuccessStatusCode && !response.Content.smethod_0().Contains("\"isError\":1");
			}
			catch
			{
			}
			return false;
		}

		public bool RepairDrone(GClass49.GClass75 hangar, GClass49.GClass52 drone)
		{
			GClass49.GClass54 gclass = hangar.ret.hangars.FirstOrDefault<GClass49.GClass54>();
			if (gclass == null)
			{
				return false;
			}
			string string_ = string.Format("{{\"params\":{{\"hi\":{0}}},\"repairCurrency\":\"{1}\",\"lootId\":\"{2}\",\"droneLevel\":{3},\"quantity\":1,\"itemId\":\"{4}\",\"action\":\"repairDrone\",\"repairPrice\":{5}}}", new object[]
			{
				gclass.Int32_0,
				drone.String_4,
				hangar.Map_0.IList_1[drone.Int32_0],
				drone.Int32_1,
				drone.String_0,
				drone.Int32_3
			});
			return EquipmentAPI.HasNoError(this.Web.Post(GClass829.smethod_8(this.Web.Server), new Dictionary<string, string>
			{
				{
					"action",
					"repairDrone"
				},
				{
					"params",
					string_.smethod_1()
				}
			}, "https://darkorbit.com", null));
		}

		public bool ChangeHangar(string target)
		{
			if (this.Hangars == null)
			{
				return false;
			}
			GClass28.GClass32 gclass = this.Hangars.data.ret.hangars.FirstOrDefault((GClass28.GClass32 t) => t.GClass31_0.GClass30_0.String_0 == target);
			if (gclass == null)
			{
				return false;
			}
			if (gclass.Boolean_0)
			{
				return true;
			}
			string string_ = gclass.String_0;
			string string_2 = string.Concat(new string[]
			{
				"{\"params\":{\"hi\":",
				string_,
				",\"hangarId\":",
				string_,
				"}}"
			});
			bool flag = EquipmentAPI.HasNoError(this.Web.Post(GClass829.smethod_8(this.Web.Server), new Dictionary<string, string>
			{
				{
					"action",
					"activateShip"
				},
				{
					"params",
					string_2.smethod_1()
				}
			}, "https://darkorbit.com", null));
			if (flag)
			{
				this.Hangars = null;
			}
			return flag;
		}

		public class EquipmentItem
		{
			public EquipmentItem(int L, string Name, string T, EquipmentAPI.EquipmentItemType Type, int Selling)
			{
				Class13.NP5bWyNzLwONS();
				base..ctor();
				this.L = L;
				this.Name = Name;
				this.T = T;
				this.Type = Type;
				this.Selling = Selling;
			}

			public string Name;

			public string T;

			public EquipmentAPI.EquipmentItemType Type;

			public int Selling;

			public int L;
		}

		public enum EquipmentItemType
		{
			special,
			drone,
			ship,
			laser,
			generator,
			module
		}

		public class ItemHeader
		{
			public ItemHeader(string I, int LV, int L, int S)
			{
				Class13.NP5bWyNzLwONS();
				base..ctor();
				this.I = I;
				this.LV = LV;
				this.L = L;
				this.S = S;
			}

			public string I;

			public int LV;

			public int L;

			public int S;
		}
	}
}
