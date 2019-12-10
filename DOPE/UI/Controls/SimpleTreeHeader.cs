using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DarkorbitAPI;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;

namespace DOPE.UI.Controls
{
	public class SimpleTreeHeader : SimpleTreeNode, INotifyPropertyChanged
	{
		public SimpleTreeHeader()
		{
			Class8.xDph7tozmh5WD();
			base..ctor();
		}

		private static SimpleTreeNode smethod_0(string string_0, object object_0)
		{
			SimpleTreeNode simpleTreeNode = new SimpleTreeNode();
			simpleTreeNode.Name = string_0;
			string value;
			if (object_0 != null)
			{
				if ((value = object_0.ToString()) != null)
				{
					goto IL_22;
				}
			}
			value = "null";
			IL_22:
			simpleTreeNode.Value = value;
			return simpleTreeNode;
		}

		public static SimpleTreeHeader smethod_1(Hero hero_0)
		{
			return new SimpleTreeHeader
			{
				Name = "Hero",
				Children = new List<SimpleTreeNode>
				{
					SimpleTreeHeader.smethod_0("IsInitialized", hero_0.IsInitialized),
					SimpleTreeHeader.smethod_0("Name", hero_0.Name),
					SimpleTreeHeader.smethod_0("Credits", hero_0.Credits),
					SimpleTreeHeader.smethod_0("Uridium", hero_0.Uridium),
					SimpleTreeHeader.smethod_0("Level", hero_0.Level),
					SimpleTreeHeader.smethod_0("Experience", hero_0.Experience),
					SimpleTreeHeader.smethod_0("Honor", hero_0.Honor),
					SimpleTreeHeader.smethod_0("BootyKeys", hero_0.BootyKeys)
				}
			};
		}

		public static SimpleTreeHeader smethod_2(Hero hero_0)
		{
			return new SimpleTreeHeader
			{
				Name = "Ship",
				Children = new List<SimpleTreeNode>
				{
					SimpleTreeHeader.smethod_0("TypeId", hero_0.TypeId),
					SimpleTreeHeader.smethod_0("Cloaked", hero_0.Cloaked),
					SimpleTreeHeader.smethod_0("Speed", hero_0.Speed),
					SimpleTreeHeader.smethod_0("HpDisplay", hero_0.HpDisplay),
					SimpleTreeHeader.smethod_0("ShieldDisplay", hero_0.ShieldDisplay),
					SimpleTreeHeader.smethod_0("Config", hero_0.Config)
				}
			};
		}

		private static SimpleTreeHeader smethod_3(HeroPet heroPet_0)
		{
			List<SimpleTreeNode> list = new List<SimpleTreeNode>();
			foreach (KeyValuePair<PetMode, GClass243> keyValuePair in heroPet_0.Modes)
			{
				string text = string.Format("Lv. {0}", keyValuePair.Value.int_1);
				if (!keyValuePair.Value.Enabled)
				{
					text += " (Cooldown)";
				}
				list.Add(new SimpleTreeNode
				{
					Name = keyValuePair.Key.ToString(),
					Value = text
				});
			}
			return new SimpleTreeHeader
			{
				Name = "Gears",
				Children = list
			};
		}

		public static SimpleTreeHeader smethod_4(HeroPet heroPet_0)
		{
			List<SimpleTreeNode> children = new List<SimpleTreeNode>
			{
				SimpleTreeHeader.smethod_0("Available", "false")
			};
			if (heroPet_0.IsAvailable)
			{
				children = new List<SimpleTreeNode>
				{
					SimpleTreeHeader.smethod_0("IsEnabled", heroPet_0.IsEnabled),
					SimpleTreeHeader.smethod_0("Name", heroPet_0.Name),
					SimpleTreeHeader.smethod_0("Level", heroPet_0.Level),
					SimpleTreeHeader.smethod_0("Fuel", heroPet_0.Fuel),
					SimpleTreeHeader.smethod_0("IsRepairNeeded", heroPet_0.IsRepairNeeded),
					SimpleTreeHeader.smethod_0("Mode", heroPet_0.Mode),
					SimpleTreeHeader.smethod_0("Experience", heroPet_0.Experience),
					SimpleTreeHeader.smethod_0("HpDisplay", heroPet_0.HpDisplay),
					SimpleTreeHeader.smethod_0("ShieldDisplay", heroPet_0.ShieldDisplay),
					SimpleTreeHeader.smethod_3(heroPet_0)
				};
			}
			return new SimpleTreeHeader
			{
				Name = "P.E.T.",
				Children = children
			};
		}

		public static SimpleTreeHeader smethod_5(Hero hero_0)
		{
			SimpleTreeHeader simpleTreeHeader = new SimpleTreeHeader();
			simpleTreeHeader.Name = "Ammo";
			simpleTreeHeader.Children = hero_0.Ammo.Select(new Func<KeyValuePair<string, double>, SimpleTreeNode>(SimpleTreeHeader.<>c.<>9.method_0)).ToList<SimpleTreeNode>();
			return simpleTreeHeader;
		}

		public static SimpleTreeHeader smethod_6(Hero hero_0)
		{
			return new SimpleTreeHeader
			{
				Name = "Cargo",
				Children = new List<SimpleTreeNode>
				{
					SimpleTreeHeader.smethod_0("Capacity", string.Format("{0}/{1}", hero_0.CargoCapacity - hero_0.FreeCargo, hero_0.CargoCapacity)),
					SimpleTreeHeader.smethod_0("Prometium", hero_0.ResourcePrometium),
					SimpleTreeHeader.smethod_0("Endurium", hero_0.ResourceEndurium),
					SimpleTreeHeader.smethod_0("Terbium", hero_0.ResourceTerbium),
					SimpleTreeHeader.smethod_0("Prometid", hero_0.ResourcePrometid),
					SimpleTreeHeader.smethod_0("Duranium", hero_0.ResourceDuranium),
					SimpleTreeHeader.smethod_0("Promerium", hero_0.ResourcePromerium),
					SimpleTreeHeader.smethod_0("Seprom", hero_0.ResourceSeprom),
					SimpleTreeHeader.smethod_0("Xenomit", hero_0.ResourceXenomit),
					SimpleTreeHeader.smethod_0("Palladium", hero_0.ResourcePalladium)
				}
			};
		}

		public static SimpleTreeHeader smethod_7(GClass810 gclass810_0)
		{
			DarkOrbitWebAPI.GalaxyGatesInfo ggInfo = gclass810_0.Game.Web.GgInfo;
			if (ggInfo == null)
			{
				return new SimpleTreeHeader
				{
					Name = "Gates",
					Children = new List<SimpleTreeNode>()
				};
			}
			List<SimpleTreeNode> list = new List<SimpleTreeNode>
			{
				SimpleTreeHeader.smethod_0("Free energy", ggInfo.samples)
			};
			foreach (DarkOrbitWebAPI.jumpgateGate jumpgateGate in ggInfo.gates)
			{
				string text;
				if (GClass832.dictionary_0.TryGetValue(jumpgateGate.id, out text))
				{
					string text2 = string.Format("{0} {1}/{2}", text, jumpgateGate.current, jumpgateGate.total);
					if (jumpgateGate.prepared)
					{
						text2 += string.Format(" (wave {0}/{1})", jumpgateGate.currentWave, jumpgateGate.totalWave);
					}
					list.Add(SimpleTreeHeader.smethod_0(text, text2));
				}
			}
			return new SimpleTreeHeader
			{
				Name = "Gates",
				Children = list
			};
		}
	}
}
