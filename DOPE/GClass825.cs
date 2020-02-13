using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using DarkorbitAPI.CommonStructures;
using DarkorbitAPI.Structures;
using DOPE.Common.Models.Spacemap;

public static class GClass825
{
	public static string smethod_0(Color color_0)
	{
		string result = string.Empty;
		if (color_0.IsEmpty)
		{
			return result;
		}
		if (color_0.IsNamedColor)
		{
			if (color_0 == Color.LightGray)
			{
				result = "LightGrey";
			}
			else
			{
				result = color_0.Name;
			}
		}
		else
		{
			result = "#" + color_0.R.ToString("X2", null) + color_0.G.ToString("X2", null) + color_0.B.ToString("X2", null);
		}
		return result;
	}

	public static RectangleF smethod_1(float float_0, float float_1, float float_2, float float_3)
	{
		return new RectangleF(float_0 - float_2 / 2f, float_1 - float_3 / 2f, float_2, float_3);
	}

	public static EntityDataRoot smethod_2(Map map_0, Entity entity_0)
	{
		DarkorbitAPI.CommonStructures.Size mapSize = map_0.MapSize;
		int num;
		int num2;
		int num3;
		int num4;
		int num5;
		entity_0.vmethod_0(out num, out num2, out num3, out num4, out num5);
		return new EntityDataRoot((float)num / (float)mapSize.Width, (float)num2 / (float)mapSize.Height, (float)num3 / (float)mapSize.Width, (float)num4 / (float)mapSize.Height, (float)num5);
	}

	public static EntityDataRoot smethod_3(Map map_0, Vector2 vector2_0)
	{
		DarkorbitAPI.CommonStructures.Size mapSize = map_0.MapSize;
		return new EntityDataRoot(vector2_0.X / (float)mapSize.Width, vector2_0.Y / (float)mapSize.Height);
	}

	private static EntityRenderFragment smethod_4(Color color_0, string string_0, Color? nullable_0 = null, params object[] args)
	{
		return GClass825.HdboNzMwfom(color_0, string_0, 0, 0, nullable_0, args);
	}

	private static EntityRenderFragment HdboNzMwfom(Color color_0, string string_0, int int_0, int int_1, Color? nullable_0 = null, params object[] args)
	{
		EntityRenderFragment entityRenderFragment = new EntityRenderFragment();
		entityRenderFragment.Fill = ((color_0 == Color.Transparent) ? "" : GClass825.smethod_0(color_0));
		entityRenderFragment.Stroke = ((nullable_0 != null) ? GClass825.smethod_0(nullable_0.Value) : "");
		entityRenderFragment.Shape = string_0;
		entityRenderFragment.Extra = args.Where(new Func<object, bool>(GClass825.<>c.<>c_0.method_0)).Select(new Func<object, string>(GClass825.<>c.<>c_0.method_1)).ToList<string>();
		entityRenderFragment.ExtraF = args.Where(new Func<object, bool>(GClass825.<>c.<>c_0.method_2)).Select(new Func<object, float>(GClass825.<>c.<>c_0.method_3)).ToList<float>();
		entityRenderFragment.OffsetX = (float)int_0;
		entityRenderFragment.OffsetY = (float)int_1;
		entityRenderFragment.Alpha = ((color_0 == Color.Transparent) ? 1f : ((float)color_0.A / 255f));
		return entityRenderFragment;
	}

	private static EntityRenderFragment NkXohnXgke9(Color color_0, int int_0, Color? nullable_0 = null)
	{
		return GClass825.smethod_5(color_0, int_0, int_0, nullable_0);
	}

	private static EntityRenderFragment smethod_5(Color color_0, int int_0, int int_1, Color? nullable_0 = null)
	{
		return GClass825.smethod_4(color_0, "rect", nullable_0, new object[]
		{
			(float)int_0,
			(float)int_1
		});
	}

	private static EntityRenderFragment smethod_6(Color color_0, float float_0, float float_1, Color? nullable_0 = null)
	{
		return GClass825.smethod_4(color_0, "rect", nullable_0, new object[]
		{
			-float_0,
			-float_1
		});
	}

	private static EntityRenderFragment smethod_7(Color color_0, int int_0, int int_1, Color? nullable_0 = null)
	{
		return GClass825.smethod_4(color_0, "circle", nullable_0, new object[]
		{
			(float)int_0,
			(float)int_1
		});
	}

	private static EntityRenderFragment UdVohJjgnfW(Color color_0, int int_0, float float_0, float float_1, Color? nullable_0 = null)
	{
		return GClass825.smethod_4(color_0, "path", nullable_0, new object[]
		{
			(float)int_0,
			float_0,
			float_1
		});
	}

	private static EntityRenderFragment smethod_8(Color color_0, string string_0, string string_1, string string_2, Color? nullable_0 = null)
	{
		return GClass825.smethod_4(color_0, "text", nullable_0, new object[]
		{
			string_0,
			string_1,
			string_2
		});
	}

	private static EntityDataRoot AxmoheoZuUD(GClass824 gclass824_0, Map map_0, Ship ship_0)
	{
		EntityDataRoot entityDataRoot = GClass825.smethod_2(map_0, ship_0);
		Color color_ = MapUtils.smethod_14(map_0, ship_0);
		NpcShip npcShip = ship_0 as NpcShip;
		if (npcShip != null && (!(gclass824_0.Behavior ?? gclass824_0.gclass837_0).vmethod_8(npcShip) || npcShip.LeashedBy > 0))
		{
			color_ = Color.Gray;
		}
		Color? nullable_ = null;
		entityDataRoot.Data = new List<EntityRenderFragment>
		{
			GClass825.NkXohnXgke9(color_, 4, nullable_)
		};
		return entityDataRoot;
	}

	private static EntityDataRoot smethod_9(Map map_0, Collectible collectible_0)
	{
		EntityDataRoot entityDataRoot = GClass825.smethod_2(map_0, collectible_0);
		Color color_ = MapUtils.smethod_14(map_0, collectible_0);
		entityDataRoot.Data = new List<EntityRenderFragment>
		{
			GClass825.NkXohnXgke9(color_, 3, null)
		};
		return entityDataRoot;
	}

	private static EntityDataRoot smethod_10(Map map_0, Gate gate_0)
	{
		EntityDataRoot entityDataRoot = GClass825.smethod_2(map_0, gate_0);
		Color color = MapUtils.smethod_14(map_0, gate_0);
		entityDataRoot.Data = new List<EntityRenderFragment>
		{
			GClass825.NkXohnXgke9(color, 3, null),
			GClass825.smethod_7(Color.Transparent, 12, 3, new Color?(color))
		};
		return entityDataRoot;
	}

	private static EntityDataRoot smethod_11(Map map_0, float float_0, float float_1, params EntityRenderFragment[] args)
	{
		DarkorbitAPI.CommonStructures.Size mapSize = map_0.MapSize;
		return new EntityDataRoot(float_0 / (float)mapSize.Width, float_1 / (float)mapSize.Height)
		{
			Data = new List<EntityRenderFragment>(args)
		};
	}

	private static EntityDataRoot smethod_12(float float_0, float float_1, params EntityRenderFragment[] args)
	{
		return new EntityDataRoot(float_0, float_1)
		{
			Data = new List<EntityRenderFragment>(args)
		};
	}

	private static EntityDataRoot smethod_13(Map map_0)
	{
		return GClass825.smethod_12(0.5f, 0.5f, new EntityRenderFragment[]
		{
			GClass825.smethod_8(Color.Gray, "60px Arial", "center", map_0.MapName, null)
		});
	}

	private static EntityDataRoot smethod_14(GClass824 gclass824_0, Map map_0)
	{
		string text = string.Join("\r\n", gclass824_0.fcDoZzaqUxq());
		if (string.IsNullOrWhiteSpace(text))
		{
			return null;
		}
		return GClass825.smethod_12(0.98f, 0.1f, new EntityRenderFragment[]
		{
			GClass825.smethod_8(Color.Red, "30px Arial", "right", text, null)
		});
	}

	private static EntityDataRoot hjyohmhKtYg(GClass824 gclass824_0)
	{
		string text = string.Format("{0} | CFG: {1} | FRM: {2}", gclass824_0.State.ToString(), gclass824_0.Hero.Config, gclass824_0.Hero.Formation.ToString());
		HeroPet pet = gclass824_0.Hero.Pet;
		if (pet != null && pet.IsAvailable)
		{
			text += " | PET: ";
			if (gclass824_0.Hero.Pet.IsEnabled)
			{
				text += gclass824_0.Hero.Pet.Mode.ToString();
			}
			else
			{
				text += "Off";
			}
		}
		return GClass825.smethod_12(0.02f, 0.95f, new EntityRenderFragment[]
		{
			GClass825.smethod_8(Color.Red, "16px Arial", "left", text, null)
		});
	}

	private static EntityDataRoot smethod_15(Map map_0, Ship ship_0)
	{
		EntityDataRoot entityDataRoot = new EntityDataRoot((ship_0 is Hero) ? 0.8333333f : 0.166666672f, 0.8f);
		float hpPercentage = ship_0.HpPercentage;
		float shieldPercentage = ship_0.ShieldPercentage;
		string hpDisplay = ship_0.HpDisplay;
		string shieldDisplay = ship_0.ShieldDisplay;
		int num = (int)(Math.Ceiling((double)(116f * hpPercentage / 200f)) * 2.0);
		int num2 = (int)(Math.Ceiling((double)(116f * shieldPercentage / 200f)) * 2.0);
		entityDataRoot.Data = new List<EntityRenderFragment>
		{
			GClass825.smethod_5(Color.FromArgb(150, Color.LightSlateGray), 120, 20, null),
			GClass825.smethod_5(Color.FromArgb(150, Color.LawnGreen), num, 16, null),
			GClass825.smethod_8(Color.FromArgb(150, Color.White), "12px Arial", "center", hpDisplay, null),
			GClass825.smethod_5(Color.FromArgb(150, Color.LightSlateGray), 120, 20, null),
			GClass825.smethod_5(Color.FromArgb(150, Color.DodgerBlue), num2, 16, null),
			GClass825.smethod_8(Color.FromArgb(150, Color.White), "12px Arial", "center", shieldDisplay, null)
		};
		entityDataRoot.Data[1].OffsetX = (float)(num / 2 - 58);
		entityDataRoot.Data[2].OffsetY = 4f;
		entityDataRoot.Data[3].OffsetY = 24f;
		entityDataRoot.Data[4].OffsetX = (float)(num2 / 2 - 58);
		entityDataRoot.Data[4].OffsetY = 24f;
		entityDataRoot.Data[5].OffsetY = 24f + entityDataRoot.Data[2].OffsetY;
		string string_ = ship_0.Name;
		Hero hero = ship_0 as Hero;
		if (hero != null)
		{
			string_ = "";
			if (hero.Cloaked)
			{
				string_ = "Cloaked";
			}
		}
		entityDataRoot.Data.Add(GClass825.smethod_8(Color.DarkRed, "13px Arial", "center", string_, null));
		entityDataRoot.Data.Last<EntityRenderFragment>().OffsetY = entityDataRoot.Data[2].OffsetY - 24f;
		return entityDataRoot;
	}

	private static EntityDataRoot smethod_16(Map map_0)
	{
		EntityDataRoot entityDataRoot = GClass825.smethod_2(map_0, map_0.Hero);
		Color color_ = MapUtils.smethod_14(map_0, map_0.Hero);
		entityDataRoot.Data = new List<EntityRenderFragment>();
		if (map_0.Hero.MovementDestination != null)
		{
			Vector2 value = map_0.Hero.MovementDestination.Value;
			float float_ = value.X / (float)map_0.MapSize.Width;
			float float_2 = value.Y / (float)map_0.MapSize.Height;
			entityDataRoot.Data.Add(GClass825.UdVohJjgnfW(Color.Transparent, 2, float_, float_2, new Color?(Color.RoyalBlue)));
		}
		entityDataRoot.Data.Add(GClass825.NkXohnXgke9(color_, 8, null));
		return entityDataRoot;
	}

	private static EntityDataRoot smethod_17(Map map_0, CollidableRect collidableRect_0)
	{
		Rectangle rectangle = collidableRect_0.imethod_1();
		DarkorbitAPI.CommonStructures.Size mapSize = map_0.MapSize;
		Color cyan = Color.Cyan;
		Color color_ = Color.FromArgb(60, (int)cyan.R, (int)cyan.G, (int)cyan.B);
		return GClass825.smethod_11(map_0, (float)rectangle.X, (float)rectangle.Y, new EntityRenderFragment[]
		{
			GClass825.smethod_6(color_, (float)rectangle.Width / (float)mapSize.Width, (float)rectangle.Height / (float)mapSize.Height, null)
		});
	}

	private static EntityDataRoot smethod_18(Map map_0, Asset asset_0)
	{
		Color color_ = MapUtils.smethod_14(map_0, asset_0);
		EntityDataRoot entityDataRoot = GClass825.smethod_2(map_0, asset_0);
		entityDataRoot.Data.Add(GClass825.smethod_7(color_, 3, 1, new Color?(Color.DarkGray)));
		return entityDataRoot;
	}

	public static MapViewData smethod_19(GClass824 gclass824_0, bool bool_0)
	{
		Map map = gclass824_0.Map;
		MapViewData mapViewData = new MapViewData();
		mapViewData.Background = GClass825.smethod_0(Color.Black);
		mapViewData.MapId = map.MapId;
		List<EntityDataRoot> entities = mapViewData.Entities;
		entities.Add(GClass825.smethod_13(map));
		if (bool_0)
		{
			List<EntityDataRoot> list = mapViewData.CachableEntities = new List<EntityDataRoot>();
			mapViewData.IncludesCache = true;
			foreach (KeyValuePair<string, ICollidable> keyValuePair in map.Collidables)
			{
				CollidableRect collidableRect = keyValuePair.Value as CollidableRect;
				if (collidableRect != null && collidableRect.imethod_0(map) != CollidableType.None)
				{
					list.Add(GClass825.smethod_17(map, collidableRect));
				}
			}
			foreach (KeyValuePair<int, Asset> keyValuePair2 in map.Assets)
			{
				list.Add(GClass825.smethod_18(map, keyValuePair2.Value));
			}
		}
		foreach (KeyValuePair<int, Gate> keyValuePair3 in map.Gates)
		{
			entities.Add(GClass825.smethod_10(map, keyValuePair3.Value));
		}
		foreach (KeyValuePair<string, Collectible> keyValuePair4 in map.Collectibles)
		{
			entities.Add(GClass825.smethod_9(map, keyValuePair4.Value));
		}
		Ship selectedShip = map.SelectedShip;
		foreach (KeyValuePair<int, Ship> keyValuePair5 in map.Ships)
		{
			if (keyValuePair5.Value != selectedShip)
			{
				entities.Add(GClass825.AxmoheoZuUD(gclass824_0, map, keyValuePair5.Value));
			}
		}
		if (selectedShip != null)
		{
			entities.Add(GClass825.AxmoheoZuUD(gclass824_0, map, selectedShip));
		}
		entities.Add(GClass825.smethod_16(map));
		EntityDataRoot entityDataRoot = GClass825.smethod_14(gclass824_0, map);
		if (entityDataRoot != null)
		{
			entities.Add(entityDataRoot);
		}
		entities.Add(GClass825.smethod_15(map, map.Hero));
		if (selectedShip != null)
		{
			entities.Add(GClass825.smethod_15(map, selectedShip));
		}
		entities.Add(GClass825.hjyohmhKtYg(gclass824_0));
		return mapViewData;
	}
}
