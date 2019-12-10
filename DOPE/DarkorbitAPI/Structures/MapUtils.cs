﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;
using NLog;

namespace DarkorbitAPI.Structures
{
	public static class MapUtils
	{
		public static int smethod_0(string string_0, int int_0 = -1)
		{
			if (int_0 != -1)
			{
				string_0 = string_0.Replace("X", int_0.ToString());
			}
			int result;
			if (!MapUtils.MapIdByName.TryGetValue(string_0, out result))
			{
				return 0;
			}
			return result;
		}

		public static DarkorbitAPI.CommonStructures.Size smethod_1(int int_0)
		{
			if (int_0 <= 29)
			{
				if (int_0 == 16 || int_0 == 29)
				{
					goto IL_23;
				}
			}
			else
			{
				if (int_0 == 91)
				{
					goto IL_23;
				}
				if (int_0 == 93)
				{
					goto IL_23;
				}
			}
			return MapUtils.DefaultMapSize;
			IL_23:
			return MapUtils.LargeMapSize;
		}

		public static Vector2 smethod_2(int int_0)
		{
			DarkorbitAPI.CommonStructures.Size size = MapUtils.smethod_1(int_0);
			return new Vector2((float)(size.Width / 2), (float)(size.Height / 2));
		}

		public static string smethod_3(int int_0)
		{
			if (int_0 == 0)
			{
				return "?";
			}
			int num = int_0;
			if (num <= 4)
			{
				return string.Format("1-{0}", num);
			}
			int num2 = int_0;
			if (num2 <= 8)
			{
				return string.Format("2-{0}", num2 - 4);
			}
			int num3 = int_0;
			if (num3 <= 12)
			{
				return string.Format("3-{0}", num3 - 8);
			}
			int num4 = int_0;
			if (num4 <= 16)
			{
				return string.Format("4-{0}", num4 - 12);
			}
			if (int_0 == 29)
			{
				return "4-5";
			}
			int num5 = int_0;
			if (num5 <= 20)
			{
				return string.Format("1-{0}", num5 - 12);
			}
			int num6 = int_0;
			if (num6 <= 24)
			{
				return string.Format("2-{0}", num6 - 16);
			}
			int num7 = int_0;
			if (num7 <= 28)
			{
				return string.Format("3-{0}", num7 - 20);
			}
			int num8 = int_0;
			if (num8 >= 91 && num8 <= 93)
			{
				return string.Format("5-{0}", num8 - 90);
			}
			if (int_0 <= 200)
			{
				switch (int_0)
				{
				case 51:
					return "GG Alpha";
				case 52:
					return "GG Beta";
				case 53:
					return "GG Gamma";
				case 54:
					break;
				case 55:
					return "GG Delta";
				default:
					switch (int_0)
					{
					case 70:
						return "GG Epsilon";
					case 71:
					case 72:
					case 73:
						return "GG Zeta";
					case 74:
						return "GG Kappa";
					case 75:
						return "GG Lambda";
					case 76:
						return "GG Kronos";
					default:
						if (int_0 == 200)
						{
							return "GG LoW";
						}
						break;
					}
					break;
				}
			}
			else
			{
				if (int_0 == 203)
				{
					return "GG Hades";
				}
				switch (int_0)
				{
				case 227:
				case 230:
				case 231:
				case 232:
				case 233:
				case 234:
				case 235:
				case 236:
					return "GG VoT";
				case 228:
					break;
				case 229:
					return "GG QZ";
				default:
					if (int_0 - 300 <= 4)
					{
						return "GG Kuiper";
					}
					break;
				}
			}
			int num9 = int_0;
			if (num9 >= 306 && num9 <= 308)
			{
				return string.Format("BL-{0}", num9 - 305);
			}
			return int_0.ToString();
		}

		public static bool IsGG(int mapId)
		{
			return MapUtils.smethod_6(mapId) > GEnum5.None;
		}

		public static bool smethod_4(int int_0)
		{
			GEnum5 genum = MapUtils.smethod_6(int_0);
			return genum != GEnum5.None && genum != (GEnum5)227;
		}

		internal static void smethod_5(DarkOrbitWebAPI.spacemap spacemap_0)
		{
			if (MapUtils._init)
			{
				return;
			}
			MapUtils._init = true;
			MapUtils.smethod_7(spacemap_0.jumpgates.Select(new Func<DarkOrbitWebAPI.spacemapJumpgate, MapUtils.PortalEdge>(MapUtils.<>c.<>9.method_0)).ToList<MapUtils.PortalEdge>());
		}

		public static GEnum5 smethod_6(int int_0)
		{
			if (int_0 <= 76)
			{
				switch (int_0)
				{
				case 51:
					return (GEnum5)51;
				case 52:
					return (GEnum5)52;
				case 53:
					return (GEnum5)53;
				case 54:
					break;
				case 55:
					return (GEnum5)55;
				default:
					switch (int_0)
					{
					case 70:
						return (GEnum5)70;
					case 71:
					case 72:
					case 73:
						return (GEnum5)71;
					case 74:
						return (GEnum5)74;
					case 75:
						return (GEnum5)75;
					case 76:
						return (GEnum5)76;
					}
					break;
				}
			}
			else
			{
				switch (int_0)
				{
				case 227:
				case 230:
				case 231:
				case 232:
				case 233:
				case 234:
				case 235:
				case 236:
					return (GEnum5)227;
				case 228:
					break;
				case 229:
					return (GEnum5)229;
				default:
					if (int_0 - 300 <= 4)
					{
						return (GEnum5)300;
					}
					break;
				}
			}
			return GEnum5.None;
		}

		private static void smethod_7(List<MapUtils.PortalEdge> list_0)
		{
			MapUtils.SpaceGraph.Clear();
			foreach (MapUtils.PortalEdge portalEdge in list_0)
			{
				MapUtils.Portals[portalEdge.Id] = portalEdge;
				List<MapUtils.PortalEdge> list;
				if (!MapUtils.SpaceGraph.TryGetValue(portalEdge.FromMapId, out list))
				{
					list = (MapUtils.SpaceGraph[portalEdge.FromMapId] = new List<MapUtils.PortalEdge>());
				}
				list.Add(portalEdge);
			}
			foreach (KeyValuePair<int, MapUtils.PortalEdge> keyValuePair in MapUtils.Portals)
			{
				MapUtils.<>c__DisplayClass13_0 CS$<>8__locals1 = new MapUtils.<>c__DisplayClass13_0();
				CS$<>8__locals1.p = keyValuePair.Value;
				if (CS$<>8__locals1.p.OtherSide == null)
				{
					MapUtils.PortalEdge portalEdge2 = MapUtils.SpaceGraph[CS$<>8__locals1.p.ToMapId].Where(new Func<MapUtils.PortalEdge, bool>(CS$<>8__locals1.method_0)).OrderBy(new Func<MapUtils.PortalEdge, int>(CS$<>8__locals1.method_1)).FirstOrDefault<MapUtils.PortalEdge>();
					if (portalEdge2 != null)
					{
						CS$<>8__locals1.p.OtherSide = portalEdge2;
						portalEdge2.OtherSide = CS$<>8__locals1.p;
					}
				}
			}
		}

		static MapUtils()
		{
			Class8.xDph7tozmh5WD();
			MapUtils.LargeMapSize = new DarkorbitAPI.CommonStructures.Size(42000, 27000);
			MapUtils.DefaultMapSize = new DarkorbitAPI.CommonStructures.Size(21000, 13500);
			MapUtils._init = false;
			MapUtils.DefaultMapCheckpointComparer = Comparer<MapUtils.MapCheckpoint>.Create(new Comparison<MapUtils.MapCheckpoint>(MapUtils.<>c.<>9.method_1));
			MapUtils.Portals = new Dictionary<int, MapUtils.PortalEdge>();
			MapUtils.MapIdByName = new Dictionary<string, int>();
			MapUtils.Maps = new List<string>();
			MapUtils.SpaceGraph = new Dictionary<int, List<MapUtils.PortalEdge>>();
			List<string> list = new List<string>();
			MapUtils.Maps = list;
			for (int i = 1; i < 400; i++)
			{
				string text = MapUtils.smethod_3(i);
				int num;
				if (!int.TryParse(text, out num) && !MapUtils.MapIdByName.ContainsKey(text))
				{
					MapUtils.MapIdByName[text] = i;
					list.Add(text);
				}
			}
			list.Sort();
		}

		public static bool IsX1(Map map)
		{
			return map.MapId == MapUtils.smethod_8(1, map.Hero.FactionId);
		}

		public static int smethod_8(int int_0, int int_1)
		{
			int result;
			if (!MapUtils.MapIdByName.TryGetValue(string.Format("{0}-{1}", int_1, int_0), out result))
			{
				return 0;
			}
			return result;
		}

		public static bool IsX1(int faction, int mapId)
		{
			return MapUtils.smethod_8(1, faction) == mapId;
		}

		public static int smethod_9(GEnum5 genum5_0)
		{
			if (genum5_0 <= (GEnum5)76)
			{
				if (genum5_0 == GEnum5.None)
				{
					return 1;
				}
				switch (genum5_0)
				{
				case (GEnum5)51:
					return 2;
				case (GEnum5)52:
					return 3;
				case (GEnum5)53:
					return 4;
				case (GEnum5)54:
					break;
				case (GEnum5)55:
					return 5;
				default:
					switch (genum5_0)
					{
					case (GEnum5)70:
						return 53;
					case (GEnum5)71:
						return 54;
					case (GEnum5)74:
						return 70;
					case (GEnum5)75:
						return 71;
					case (GEnum5)76:
						return 72;
					}
					break;
				}
			}
			else
			{
				if (genum5_0 == (GEnum5)227)
				{
					return 81;
				}
				if (genum5_0 == (GEnum5)300)
				{
					return 82;
				}
				if (genum5_0 == (GEnum5)2048)
				{
					return 74;
				}
			}
			return 1;
		}

		public static int smethod_10(GEnum5 genum5_0, int int_0)
		{
			if (genum5_0 == (GEnum5)227)
			{
				return MapUtils.smethod_8(4, int_0);
			}
			if (genum5_0 != GEnum5.None)
			{
				return MapUtils.smethod_8(1, int_0);
			}
			return 0;
		}

		public static Gate smethod_11(Map map_0, Vector2 vector2_0, int int_0)
		{
			MapUtils.<>c__DisplayClass22_0 CS$<>8__locals1 = new MapUtils.<>c__DisplayClass22_0();
			CS$<>8__locals1.map = map_0;
			CS$<>8__locals1.curGg = MapUtils.smethod_6(CS$<>8__locals1.map.MapId);
			GEnum5 genum = MapUtils.smethod_6(int_0);
			CS$<>8__locals1.gateType = MapUtils.smethod_9(genum);
			if (CS$<>8__locals1.curGg != GEnum5.None)
			{
				bool flag = false;
				if (genum != GEnum5.None && CS$<>8__locals1.curGg == genum)
				{
					flag = true;
				}
				if (flag)
				{
					Gate value = CS$<>8__locals1.map.Gates.FirstOrDefault(new Func<KeyValuePair<int, Gate>, bool>(CS$<>8__locals1.method_0)).Value;
					if (value != null)
					{
						return value;
					}
				}
				return CS$<>8__locals1.map.Gates.FirstOrDefault(new Func<KeyValuePair<int, Gate>, bool>(CS$<>8__locals1.method_1)).Value;
			}
			if (genum != GEnum5.None && MapUtils.smethod_10(genum, CS$<>8__locals1.map.Hero.FactionId) == CS$<>8__locals1.map.MapId)
			{
				return CS$<>8__locals1.map.Gates.FirstOrDefault(new Func<KeyValuePair<int, Gate>, bool>(CS$<>8__locals1.method_2)).Value;
			}
			if (CS$<>8__locals1.map.MapId != int_0 && CS$<>8__locals1.map.MapId != 0 && MapUtils.SpaceGraph.ContainsKey(CS$<>8__locals1.map.MapId))
			{
				HashSet<int> hashSet = new HashSet<int>();
				new Dictionary<MapUtils.PortalEdge, MapUtils.MapCheckpoint>();
				MinHeap<MapUtils.MapCheckpoint> minHeap = new MinHeap<MapUtils.MapCheckpoint>(MapUtils.DefaultMapCheckpointComparer);
				bool flag2 = false;
				MapUtils.MapCheckpoint mapCheckpoint = null;
				if (genum != GEnum5.None)
				{
					int_0 = MapUtils.smethod_10(genum, CS$<>8__locals1.map.Hero.FactionId);
				}
				int mapId = CS$<>8__locals1.map.MapId;
				minHeap.method_0(new MapUtils.MapCheckpoint
				{
					Distance = 0f,
					MapId = (short)mapId,
					Position = vector2_0
				});
				int num = 0;
				while (minHeap.Any<MapUtils.MapCheckpoint>())
				{
					num++;
					MapUtils.MapCheckpoint mapCheckpoint2 = minHeap.method_3();
					int mapId2 = (int)mapCheckpoint2.MapId;
					if (mapCheckpoint2.Edge != null)
					{
						if (mapCheckpoint2.Edge.OtherSide != null)
						{
							hashSet.Add(mapCheckpoint2.Edge.OtherSide.Id);
						}
						if (!hashSet.Add(mapCheckpoint2.Edge.Id))
						{
							continue;
						}
					}
					if (mapId2 == int_0)
					{
						flag2 = true;
						mapCheckpoint = mapCheckpoint2;
						IL_3DF:
						if (!flag2)
						{
							return null;
						}
						LogManager.GetLogger("Base-Map-GetGate").Info("Found path from {from} to {to} in {distance:0.0} ({jumps} njumps, {its} its)", new object[]
						{
							mapId,
							int_0,
							mapCheckpoint.Distance,
							mapCheckpoint.NeutralJumps,
							num
						});
						MapUtils.MapCheckpoint mapCheckpoint3 = mapCheckpoint;
						while (mapCheckpoint3.Parent != null && mapCheckpoint3.Parent.Edge != null)
						{
							mapCheckpoint3 = mapCheckpoint3.Parent;
						}
						Gate result;
						if (!CS$<>8__locals1.map.Gates.TryGetValue(mapCheckpoint3.Edge.Id, out result))
						{
							return null;
						}
						return result;
					}
					else
					{
						using (List<MapUtils.PortalEdge>.Enumerator enumerator = MapUtils.SpaceGraph[mapId2].GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								MapUtils.<>c__DisplayClass22_1 CS$<>8__locals2 = new MapUtils.<>c__DisplayClass22_1();
								CS$<>8__locals2.port = enumerator.Current;
								if (!hashSet.Contains(CS$<>8__locals2.port.Id))
								{
									Gate gate = (mapId2 == mapId) ? CS$<>8__locals1.map.Gates.FirstOrDefault(new Func<KeyValuePair<int, Gate>, bool>(CS$<>8__locals2.method_0)).Value : null;
									if (CS$<>8__locals1.map.Hero.method_26(CS$<>8__locals2.port, gate) && (gate == null || !CS$<>8__locals1.map.Grid.method_7(gate.Position)))
									{
										bool flag3 = !CS$<>8__locals1.map.Hero.method_27(CS$<>8__locals2.port, gate);
										if (mapId2 != mapId || gate != null)
										{
											Vector2 value2 = (gate != null) ? gate.Position : CS$<>8__locals2.port.Position;
											Vector2 position = (CS$<>8__locals2.port.OtherSide != null) ? CS$<>8__locals2.port.OtherSide.Position : MapUtils.smethod_2(CS$<>8__locals2.port.ToMapId);
											MapUtils.MapCheckpoint giJNWPqd8aSPGd64pYV = new MapUtils.MapCheckpoint
											{
												Parent = mapCheckpoint2,
												Distance = mapCheckpoint2.Distance + Vector2.Distance(mapCheckpoint2.Position, value2) + 1200f,
												Position = position,
												NeutralJumps = mapCheckpoint2.NeutralJumps + (flag3 ? 1 : 0),
												Edge = CS$<>8__locals2.port,
												MapId = (short)CS$<>8__locals2.port.ToMapId
											};
											minHeap.method_0(giJNWPqd8aSPGd64pYV);
										}
									}
								}
							}
						}
					}
				}
				goto IL_3DF;
			}
			return null;
		}

		public static Color smethod_12(Map map_0, Entity entity_0)
		{
			Ship ship = entity_0 as Ship;
			if (ship != null)
			{
				if (entity_0 is Hero)
				{
					return Color.DarkCyan;
				}
				if (map_0.SelectedShip == ship)
				{
					return Color.Violet;
				}
				if (ship.IsNpc)
				{
					NpcShip npcShip = ship as NpcShip;
					if (npcShip != null)
					{
						if (npcShip.LeashedBy > 0)
						{
							return Color.Gray;
						}
						return Color.DarkRed;
					}
				}
				if (ship is HeroPet)
				{
					return Color.Coral;
				}
				if (ship.FactionId != map_0.Hero.FactionId)
				{
					return Color.Red;
				}
				if (ship.FactionId == map_0.Hero.FactionId)
				{
					return Color.DodgerBlue;
				}
				return Color.White;
			}
			else
			{
				Collectible collectible = entity_0 as Collectible;
				if (collectible != null)
				{
					if (collectible.CollectibleType == (GEnum6)1)
					{
						return Color.RosyBrown;
					}
					if (collectible.CollectibleType == (GEnum6)256)
					{
						return Color.Gold;
					}
					if (collectible.CollectibleType != (GEnum6)4)
					{
						if (collectible.CollectibleType != (GEnum6)2048)
						{
							if (collectible.CollectibleType == (GEnum6)2)
							{
								return Color.Aqua;
							}
							return Color.ForestGreen;
						}
					}
					return Color.Lime;
				}
				else
				{
					Gate gate = entity_0 as Gate;
					if (gate != null)
					{
						if (map_0.Hero.method_27(gate.Edge, gate))
						{
							return Color.Lime;
						}
						return Color.White;
					}
					else
					{
						Asset asset = entity_0 as Asset;
						if (asset == null)
						{
							return Color.Black;
						}
						if (asset.FactionId == 0)
						{
							return Color.Gray;
						}
						if (asset.FactionId == map_0.Hero.FactionId)
						{
							return Color.LimeGreen;
						}
						return Color.DarkRed;
					}
				}
			}
		}

		public static IReadOnlyList<string> Maps { get; private set; }

		[CompilerGenerated]
		internal static int skZvzdpkRe(string string_0)
		{
			string text = string_0.ToLowerInvariant();
			if (text != null)
			{
				if (text == "mmo")
				{
					return 1;
				}
				if (text == "eic")
				{
					return 2;
				}
				if (text == "vru")
				{
					return 3;
				}
			}
			return 0;
		}

		public static readonly DarkorbitAPI.CommonStructures.Size LargeMapSize;

		public static readonly DarkorbitAPI.CommonStructures.Size DefaultMapSize;

		private static volatile bool _init;

		public static Comparer<MapUtils.MapCheckpoint> DefaultMapCheckpointComparer;

		public static readonly Dictionary<int, MapUtils.PortalEdge> Portals;

		public static readonly Dictionary<string, int> MapIdByName;

		public static readonly Dictionary<int, List<MapUtils.PortalEdge>> SpaceGraph;

		public class PortalEdge
		{
			public int Id { get; set; }

			public int FromMapId { get; set; }

			public int ToMapId { get; set; }

			public int FactionId { get; set; }

			public bool SelfFactionOnly { get; set; }

			public Vector2 Position { get; set; }

			public MapUtils.PortalEdge OtherSide { get; set; }

			public PortalEdge(int int_0, int int_1, int int_2, int int_3, bool bool_0, int int_4, int int_5)
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
				this.Id = int_0;
				this.FromMapId = int_1;
				this.ToMapId = int_2;
				this.FactionId = int_3;
				this.SelfFactionOnly = bool_0;
				this.Position = new Vector2((float)int_4 / 315f * (float)MapUtils.DefaultMapSize.Width, (float)int_4 / 210f * (float)MapUtils.DefaultMapSize.Height);
			}
		}

		public class MapCheckpoint
		{
			public MapCheckpoint()
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
			}

			public MapUtils.MapCheckpoint Parent;

			public short MapId;

			public Vector2 Position;

			public float Distance;

			public short NeutralJumps;

			public MapUtils.PortalEdge Edge;
		}
	}
}