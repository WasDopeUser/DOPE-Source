using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using DarkorbitAPI.CommonStructures;
using DarkorbitAPI.Structures;

namespace DarkorbitAPI
{
	public class SecurityManager
	{
		public static int smethod_0(Ship ship_0)
		{
			NpcShip npcShip = ship_0 as NpcShip;
			if (npcShip != null && npcShip.Type != null && npcShip.Type.Class != null)
			{
				return SecurityManager.smethod_1(npcShip.Type);
			}
			return 540;
		}

		public static int smethod_1(NpcUtils.NpcType npcType_0)
		{
			if (npcType_0 == null || npcType_0.Class == null)
			{
				return 540;
			}
			NpcUtils.NpcClass @class = npcType_0.Class;
			int num = (npcType_0.Group == NpcUtils.G_Boss) ? 15 : ((npcType_0.Group == NpcUtils.G_Uber) ? 30 : 0);
			int num2;
			if (SecurityManager.NpcRangesRegular.TryGetValue(@class, out num2))
			{
				return num2 + Math.Min(num, Math.Max(0, 610 - num2));
			}
			return 540 + num;
		}

		public static int smethod_2(NpcUtils.NpcClass npcClass_0)
		{
			int result;
			if (npcClass_0 != null && SecurityManager.NpcRangesRegular.TryGetValue(npcClass_0, out result))
			{
				return result;
			}
			return 540;
		}

		public bool method_0(Map map_0, Entity entity_0)
		{
			return entity_0.PosX >= 0 && entity_0.PosX <= map_0.MapSize.Width && entity_0.PosY >= 0 && entity_0.PosY <= map_0.MapSize.Height;
		}

		public static int smethod_3(Ship ship_0)
		{
			return SecurityManager.smethod_0(ship_0);
		}

		public string method_1()
		{
			string text = this.Game.Settings.Use3D ? "3D" : "2D";
			return string.Format("{0} {1}x{2} {3}", new object[]
			{
				text,
				1920,
				1080,
				this.Game.Settings.UIString ?? ".root1.instance466.MainClientApplication0.ApplicationSkin2.Group3.Group4._-R42_5.instance25043 root1 false -1"
			});
		}

		public SecurityManager(GameManager gameManager_0)
		{
			Class13.F93tSdiz1aNIA();
			this.HashBlockList = new CooldownTracker<string>();
			this.Random = new Random();
			base..ctor();
			this.Game = gameManager_0;
		}

		public GameManager Game { get; }

		public bool method_2(Vector2 vector2_0, int int_0, int int_1, int int_2 = 0)
		{
			int num = (int)vector2_0.X;
			int num2 = (int)vector2_0.Y;
			return Math.Abs(num - int_0) < 960 - (75 + int_2) && Math.Abs(num2 - int_1) < 540 - (50 + int_2);
		}

		public bool method_3(Vector2 vector2_0, Vector2 vector2_1, int int_0 = 0)
		{
			return this.method_2(vector2_0, (int)vector2_1.X, (int)vector2_1.Y, 0);
		}

		public int LastChunkX { get; set; }

		public int LastChunkY { get; set; }

		public Vector2 method_4(Map map_0, Rectangle rectangle_0)
		{
			return this.method_6(map_0, this.LastChunkX = (this.LastChunkX + this.Random.Next(1, 5)) % 5, this.LastChunkY = (this.LastChunkY + this.Random.Next(0, 4)) % 4, rectangle_0);
		}

		public Vector2 method_5(Map map_0, List<Rectangle> list_0)
		{
			return this.method_4(map_0, list_0[this.Random.Next(0, list_0.Count)]);
		}

		public Vector2 method_6(Map map_0, int int_0, int int_1, Rectangle rectangle_0)
		{
			SecurityManager.<>c__DisplayClass32_0 CS$<>8__locals1 = new SecurityManager.<>c__DisplayClass32_0();
			CS$<>8__locals1.int_1 = int_0;
			CS$<>8__locals1.int_3 = int_1;
			CS$<>8__locals1.int_0 = rectangle_0.Width / 5;
			CS$<>8__locals1.int_2 = rectangle_0.Height / 4;
			if (map_0.Gates.Any(new Func<KeyValuePair<int, Gate>, bool>(CS$<>8__locals1.method_0)))
			{
				return this.method_4(map_0, rectangle_0);
			}
			int num = this.Random.Next(0, CS$<>8__locals1.int_0) + rectangle_0.X;
			int num2 = this.Random.Next(0, CS$<>8__locals1.int_2) + rectangle_0.Y;
			int num3 = CS$<>8__locals1.int_1 * CS$<>8__locals1.int_0 + num;
			int num4 = CS$<>8__locals1.int_3 * CS$<>8__locals1.int_2 + num2;
			Vector2 vector = new Vector2((float)num3, (float)num4);
			if (map_0.Grid.method_7(vector))
			{
				return this.method_4(map_0, rectangle_0);
			}
			return vector;
		}

		public static HashSet<string> BlackBoxes { get; private set; }

		static SecurityManager()
		{
			Class13.F93tSdiz1aNIA();
			SecurityManager.NpcRangesRegular = new Dictionary<NpcUtils.NpcClass, int>
			{
				{
					NpcUtils.N_Streuner,
					450
				},
				{
					NpcUtils.N_Lordakia,
					450
				},
				{
					NpcUtils.N_Saimon,
					515
				},
				{
					NpcUtils.N_Mordon,
					470
				},
				{
					NpcUtils.N_Devolarium,
					530
				},
				{
					NpcUtils.N_Sibelon,
					550
				},
				{
					NpcUtils.N_Sibelonit,
					505
				},
				{
					NpcUtils.N_Lordakium,
					575
				},
				{
					NpcUtils.N_Kristallin,
					505
				},
				{
					NpcUtils.N_Kristallon,
					580
				},
				{
					NpcUtils.N_StreuneR,
					550
				},
				{
					NpcUtils.N_Protegit,
					565
				},
				{
					NpcUtils.N_Attend,
					555
				},
				{
					NpcUtils.N_Impulse,
					555
				},
				{
					NpcUtils.N_Melter,
					555
				},
				{
					NpcUtils.N_Annihilator,
					610
				},
				{
					NpcUtils.N_Interceptor,
					610
				},
				{
					NpcUtils.N_Baracuda,
					610
				},
				{
					NpcUtils.N_Saboteur,
					610
				},
				{
					NpcUtils.N_Kucurbium,
					565
				},
				{
					NpcUtils.N_CenturyFalcon,
					580
				},
				{
					NpcUtils.N_UFONIT,
					560
				},
				{
					NpcUtils.N_UFO,
					600
				},
				{
					NpcUtils.N_Cubikon,
					450
				},
				{
					NpcUtils.N_StreunerSoldier,
					570
				},
				{
					NpcUtils.N_StreunerTurret,
					570
				},
				{
					NpcUtils.N_Icy,
					580
				},
				{
					NpcUtils.N_Skoll,
					580
				},
				{
					NpcUtils.N_IceMeteoroid,
					580
				},
				{
					NpcUtils.N_HexorMimesis,
					570
				},
				{
					NpcUtils.N_RagingMimesis,
					570
				},
				{
					NpcUtils.N_AssailantMimesis,
					570
				},
				{
					NpcUtils.N_ReflectorMimesis,
					570
				},
				{
					NpcUtils.N_CloningMimesis,
					570
				},
				{
					NpcUtils.N_ClonedMimesis,
					570
				},
				{
					NpcUtils.N_SniperMimesis,
					570
				},
				{
					NpcUtils.N_HoundingMimesis,
					570
				},
				{
					NpcUtils.N_MedicMimesis,
					570
				},
				{
					NpcUtils.N_PiercingMimesis,
					570
				},
				{
					NpcUtils.N_HardyMimesis,
					570
				},
				{
					NpcUtils.N_KamikazeMimesis,
					570
				}
			};
			SecurityManager.BlackBoxes = new HashSet<string>
			{
				"ozims",
				"1604u",
				"znmjs",
				"bu9m9",
				"zel71",
				"q4knx",
				"ci7m0",
				"1ukl6",
				"1gtlm",
				"180fk",
				"13b44",
				"ntr63",
				"1lmf1",
				"1r78f",
				"1oloo",
				"xixzz",
				"13jaa",
				"6dge9",
				"m79jj",
				"h0rbx",
				"n5cwr",
				"1hviz",
				"1g4pv",
				"1ss4t",
				"1c2tu",
				"100vp",
				"rku9c",
				"1hd2h",
				"416n4",
				"1t5p4",
				"6ovbk",
				"3k2hr",
				"48chq",
				"lnkdf",
				"1usjy",
				"1scn2",
				"usc1j",
				"qj4o9",
				"yyr28",
				"3mtlo",
				"hkw3g",
				"a2abg",
				"1fnxl",
				"1kjds",
				"9icg0",
				"13umf",
				"qtqry",
				"1ucay",
				"puvoe",
				"1c3oi",
				"1nesl",
				"wl0wr",
				"sn8n9",
				"1v20m",
				"1g568",
				"1malf",
				"w27x1",
				"ov57p",
				"1ecek",
				"1my80",
				"1srvg",
				"2u942",
				"103wa",
				"1srrl",
				"109xs",
				"6x1u8",
				"152g8",
				"5naot",
				"oeoud",
				"tbeuu",
				"13p97",
				"rckbt",
				"1trob",
				"1fsi3",
				"v2qxb",
				"1szeq",
				"87k2a",
				"1bfcm",
				"fc9f7",
				"1g7du",
				"lqzp9",
				"wbku5",
				"1ts89",
				"1ag6n",
				"10tv0",
				"49ol8",
				"1isk4",
				"1jyqj",
				"1e5au",
				"8v03f",
				"uy62u",
				"mk797",
				"1g65j",
				"hm27v",
				"hs940",
				"q0e4a",
				"bv8wq",
				"1nad0",
				"1mc48",
				"1801q"
			};
		}

		public bool method_7(Collectible collectible_0, bool bool_0 = false)
		{
			DateTime now = DateTime.Now;
			string hash = collectible_0.Hash;
			if (!string.IsNullOrWhiteSpace(hash))
			{
				if (collectible_0 is Resource || hash.Length != 5)
				{
					return bool_0 || this.HashBlockList.method_0(collectible_0.Hash);
				}
			}
			return false;
		}

		public bool method_8(int int_0)
		{
			return this.Random.Next(0, int_0) == 0;
		}

		public Vector2 method_9(Vector2 vector2_0, int int_0, int int_1, int int_2 = 640, int int_3 = 360, int int_4 = 25, int int_5 = 25, int int_6 = 7)
		{
			Vector2 vector = new Vector2((float)int_0, (float)int_1);
			if (!this.method_2(vector2_0, int_0, int_1, 0))
			{
				int num = (int)((float)int_0 - vector2_0.X);
				int num2 = (int)((float)int_1 - vector2_0.Y);
				int num3 = (num >= 0) ? 1 : -1;
				int num4 = (num2 >= 0) ? 1 : -1;
				int num5 = Math.Min(Math.Abs(num), int_2);
				int num6 = Math.Min(Math.Abs(num2), int_3);
				if (Math.Abs(num2) < int_3)
				{
					num6 = Math.Abs(num2);
				}
				else
				{
					num5 = (int)(Math.Abs((float)num / (float)num2) * (float)num6);
				}
				if (num5 > int_2)
				{
					num6 = (int)((float)num6 * ((float)int_2 / (float)num5));
					num5 = int_2;
				}
				return this.method_11(new Vector2(vector2_0.X + (float)(num5 * num3), vector2_0.Y + (float)(num6 * num4)), int_4, int_5);
			}
			if (int_6 > 0 && this.method_8(int_6))
			{
				return this.method_11(vector, int_4, int_5);
			}
			return vector;
		}

		public Vector2 method_10(Vector2 vector2_0, int int_0, int int_1)
		{
			Vector2 vector = new Vector2((float)int_0, (float)int_1);
			if (!this.method_2(vector2_0, int_0, int_1, 0))
			{
				int num = (int)((float)int_0 - vector2_0.X);
				int num2 = (int)((float)int_1 - vector2_0.Y);
				int num3 = Math.Min(Math.Abs(num), 640) * ((num >= 0) ? 1 : -1);
				int num4 = Math.Min(Math.Abs(num2), 360) * ((num2 >= 0) ? 1 : -1);
				return this.method_11(new Vector2(vector2_0.X + (float)num3, vector2_0.Y + (float)num4), 25, 25);
			}
			if (this.method_8(15))
			{
				return this.method_11(vector, 50, 50);
			}
			return vector;
		}

		public Vector2 method_11(Vector2 vector2_0, int int_0 = 50, int int_1 = 50)
		{
			return this.method_12((int)vector2_0.X, (int)vector2_0.Y, int_0, int_1);
		}

		public Vector2 method_12(int int_0, int int_1, int int_2 = 50, int int_3 = 50)
		{
			int num;
			int num2;
			if (this.Game.Map.Grid.method_1((float)int_0, (float)int_1, out num, out num2))
			{
				int scaleX = this.Game.Map.Grid.ScaleX;
				int scaleY = this.Game.Map.Grid.ScaleY;
				int_2 = Math.Min(int_2, Math.Min(int_0 - num * scaleX, Math.Max(0, (num + 1) * scaleX - 1 - int_0)));
				int_3 = Math.Min(int_3, Math.Min(int_1 - num2 * scaleY, Math.Max(0, (num2 + 1) * scaleY - 1 - int_1)));
			}
			return new Vector2((float)(int_0 + ((int_2 == 0) ? 0 : this.Random.Next(-int_2, int_2))), (float)(int_1 + ((int_3 == 0) ? 0 : this.Random.Next(-int_3, int_3))));
		}

		public readonly CooldownTracker<string> HashBlockList;

		public readonly Random Random;

		public static readonly Dictionary<NpcUtils.NpcClass, int> NpcRangesRegular;
	}
}
