using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Threading;
using NLog;

namespace DarkorbitAPI.Structures
{
	public static class NpcUtils
	{
		public static List<NpcUtils.NpcClass> Classes { get; private set; }

		public static List<NpcUtils.NpcType> smethod_0(int int_0)
		{
			List<NpcUtils.NpcType> result;
			if (!NpcUtils.NpcsByMap.TryGetValue(int_0, out result))
			{
				return null;
			}
			return result;
		}

		public static void smethod_1(DarkOrbitWebAPI.NpcConstants npcConstants_0)
		{
			NpcUtils.<>c__DisplayClass124_0 CS$<>8__locals1;
			CS$<>8__locals1.uberPattern = "Uber([A-Z]\\S*)";
			Dictionary<int, string> xmlNpcs = NpcUtils.XmlNpcs;
			lock (xmlNpcs)
			{
				if (NpcUtils.XmlNpcs.Count == 0)
				{
					foreach (DarkOrbitWebAPI.resourceItem resourceItem in npcConstants_0.Npcs)
					{
						int num;
						if (int.TryParse(resourceItem.name.Replace("npc_name_", ""), out num))
						{
							string text = NpcUtils.smethod_2(resourceItem.Value, ref CS$<>8__locals1);
							NpcUtils.XmlNpcs[num] = text;
							NpcUtils.XmlNpcIds[text] = num;
						}
					}
				}
			}
		}

		static NpcUtils()
		{
			Class13.F93tSdiz1aNIA();
			NpcUtils.Groups = new List<NpcUtils.NpcGroup>();
			NpcUtils.G_Regular = new NpcUtils.NpcGroup("Regular", "");
			NpcUtils.G_Boss = new NpcUtils.NpcGroup("Boss", null);
			NpcUtils.G_Uber = new NpcUtils.NpcGroup("Uber", null);
			NpcUtils.G_Recruit = new NpcUtils.NpcGroup("Recruit", null);
			NpcUtils.G_Aider = new NpcUtils.NpcGroup("Aider", null);
			NpcUtils.G_Blighted = new NpcUtils.NpcGroup("Blighted", null);
			NpcUtils.G_Plagued = new NpcUtils.NpcGroup("Plagued", null);
			NpcUtils.GG_Alpha = new NpcUtils.NpcGroup("GGAlpha", "GG α");
			NpcUtils.GG_Beta = new NpcUtils.NpcGroup("GGBeta", "GG β");
			NpcUtils.GG_Gamma = new NpcUtils.NpcGroup("GGGamma", "GG γ");
			NpcUtils.GG_Lambda = new NpcUtils.NpcGroup("GGLambda", "GG λ");
			NpcUtils.GG_Delta = new NpcUtils.NpcGroup("GGDelta", "GG δ");
			NpcUtils.GG_Epsilon = new NpcUtils.NpcGroup("GGEpsilon", "GG ε");
			NpcUtils.GG_Zeta = new NpcUtils.NpcGroup("GGZeta", "GG ζ");
			NpcUtils.GG_Kappa = new NpcUtils.NpcGroup("GGKappa", "GG κ");
			NpcUtils.GG_VoT = new NpcUtils.NpcGroup("GGVoT", "GG VoT");
			NpcUtils.G_Emperor = new NpcUtils.NpcGroup("Emperor", null);
			NpcUtils.GG_Kronos = new NpcUtils.NpcGroup("GGKronos", "GG Kronos");
			NpcUtils.GG_Kuiper = new NpcUtils.NpcGroup("GGKuiper", "GG ς");
			NpcUtils.GG_ColdWave = new NpcUtils.NpcGroup("GGColdWave", "GG Cold Wave");
			NpcUtils.G_Skolls = new NpcUtils.NpcGroup("Skolls", null);
			NpcUtils.G_Super = new NpcUtils.NpcGroup("Super", null);
			NpcUtils.G_Viral = new NpcUtils.NpcGroup("Viral", null);
			NpcUtils.GG_QZ = new NpcUtils.NpcGroup("GGQZ", "GG QZ");
			NpcUtils.Classes = new List<NpcUtils.NpcClass>();
			NpcUtils.N_Streuner = new NpcUtils.NpcClass("Streuner");
			NpcUtils.N_Lordakia = new NpcUtils.NpcClass("Lordakia");
			NpcUtils.N_Saimon = new NpcUtils.NpcClass("Saimon");
			NpcUtils.N_Mordon = new NpcUtils.NpcClass("Mordon");
			NpcUtils.N_Devolarium = new NpcUtils.NpcClass("Devolarium");
			NpcUtils.N_Sibelon = new NpcUtils.NpcClass("Sibelon");
			NpcUtils.N_Sibelonit = new NpcUtils.NpcClass("Sibelonit");
			NpcUtils.N_Lordakium = new NpcUtils.NpcClass("Lordakium");
			NpcUtils.N_Kristallin = new NpcUtils.NpcClass("Kristallin");
			NpcUtils.N_Kristallon = new NpcUtils.NpcClass("Kristallon");
			NpcUtils.N_Cubikon = new NpcUtils.NpcClass("Cubikon");
			NpcUtils.N_Protegit = new NpcUtils.NpcClass("Protegit");
			NpcUtils.N_StreuneR = new NpcUtils.NpcClass("StreuneR");
			NpcUtils.N_demaNeR = new NpcUtils.NpcClass("demaNeR");
			NpcUtils.N_Marauder = new NpcUtils.NpcClass("Marauder");
			NpcUtils.N_Vagrant = new NpcUtils.NpcClass("Vagrant");
			NpcUtils.N_Outcast = new NpcUtils.NpcClass("Outcast");
			NpcUtils.N_Hooligan = new NpcUtils.NpcClass("Hooligan");
			NpcUtils.N_Corsair = new NpcUtils.NpcClass("Corsair");
			NpcUtils.N_Convict = new NpcUtils.NpcClass("Convict");
			NpcUtils.N_Ravager = new NpcUtils.NpcClass("Ravager");
			NpcUtils.N_Infernal = new NpcUtils.NpcClass("Infernal");
			NpcUtils.N_Scorcher = new NpcUtils.NpcClass("Scorcher");
			NpcUtils.N_Saboteur = new NpcUtils.NpcClass("Saboteur");
			NpcUtils.N_Melter = new NpcUtils.NpcClass("Melter");
			NpcUtils.N_Devourer = new NpcUtils.NpcClass("Devourer");
			NpcUtils.N_IceMeteoroid = new NpcUtils.NpcClass("Ice Meteoroid");
			NpcUtils.N_Icy = new NpcUtils.NpcClass("Icy");
			NpcUtils.N_Interceptor = new NpcUtils.NpcClass("Interceptor");
			NpcUtils.N_Baracuda = new NpcUtils.NpcClass("Barracuda");
			NpcUtils.N_Annihilator = new NpcUtils.NpcClass("Annihilator");
			NpcUtils.N_Battleray = new NpcUtils.NpcClass("Battleray");
			NpcUtils.N_Kucurbium = new NpcUtils.NpcClass("Kucurbium");
			NpcUtils.N_CenturyFalcon = new NpcUtils.NpcClass("Century Falcon");
			NpcUtils.N_SeekerRocket = new NpcUtils.NpcClass("Seeker Rocket");
			NpcUtils.N_StreunerRocketeer = new NpcUtils.NpcClass("Streuner Rocketeer");
			NpcUtils.N_StreunerSoldier = new NpcUtils.NpcClass("Streuner Soldier");
			NpcUtils.N_StreunerTurret = new NpcUtils.NpcClass("Streuner Turret");
			NpcUtils.N_StreunerSpecialist = new NpcUtils.NpcClass("Streuner Specialist");
			NpcUtils.N_StreunerEmporer = new NpcUtils.NpcClass("Streuner Emporer");
			NpcUtils.N_Curcubitor = new NpcUtils.NpcClass("Curcubitor");
			NpcUtils.N_DemonDrone = new NpcUtils.NpcClass("Demon Drone");
			NpcUtils.N_UFO = new NpcUtils.NpcClass("UFO");
			NpcUtils.N_UFONIT = new NpcUtils.NpcClass("UFONIT");
			NpcUtils.N_IEgg = new NpcUtils.NpcClass("IEgg");
			NpcUtils.N_IGygerthrall = new NpcUtils.NpcClass("IGygerthrall");
			NpcUtils.N_Gygerthrall = new NpcUtils.NpcClass("Gygerthrall");
			NpcUtils.N_Hitac = new NpcUtils.NpcClass("Hitac");
			NpcUtils.N_DemanerCorsair = new NpcUtils.NpcClass("Demaner Corsair");
			NpcUtils.N_Impulse = new NpcUtils.NpcClass("Impulse II");
			NpcUtils.N_Attend = new NpcUtils.NpcClass("Attend IX");
			NpcUtils.N_Invoke = new NpcUtils.NpcClass("Invoke XVI");
			NpcUtils.N_MindfireBehemoth = new NpcUtils.NpcClass("Mindfire Behemoth");
			NpcUtils.N_Purpose = new NpcUtils.NpcClass("Purpose XXI");
			NpcUtils.N_Urge = new NpcUtils.NpcClass("Urge IV");
			NpcUtils.N_Attitude = new NpcUtils.NpcClass("Attitude XIII");
			NpcUtils.N_Capital = new NpcUtils.NpcClass("Capital I");
			NpcUtils.N_Regard = new NpcUtils.NpcClass("Regard CXI");
			NpcUtils.N_Observe = new NpcUtils.NpcClass("Observe X");
			NpcUtils.N_Find = new NpcUtils.NpcClass("Find VII");
			NpcUtils.N_Unknown = new NpcUtils.NpcClass("<UNKNOWN>");
			NpcUtils.N_LordakiumSpore = new NpcUtils.NpcClass("Lordakium Spore");
			NpcUtils.N_Skoll = new NpcUtils.NpcClass("Skoll");
			NpcUtils.N_Meteoroid = new NpcUtils.NpcClass("Meteoroid");
			NpcUtils.N_Synk = new NpcUtils.NpcClass("Synk");
			NpcUtils.N_PlagueRocket = new NpcUtils.NpcClass("Plague Rocket");
			NpcUtils.N_GygerimOverlord = new NpcUtils.NpcClass("Gygerim Overlord");
			NpcUtils.N_ChaosProtegit = new NpcUtils.NpcClass("Chaos Protegit");
			NpcUtils.N_Lanatum = new NpcUtils.NpcClass("Lanatum");
			NpcUtils.N_Styxus = new NpcUtils.NpcClass("Styxus");
			NpcUtils.N_Charopos = new NpcUtils.NpcClass("Charopos");
			NpcUtils.N_HexorMimesis = new NpcUtils.NpcClass("Hexor M1mesis");
			NpcUtils.N_RagingMimesis = new NpcUtils.NpcClass("Raging Mimes1s");
			NpcUtils.N_CloningMimesis = new NpcUtils.NpcClass("Cloning Mim3sis");
			NpcUtils.N_ClonedMimesis = new NpcUtils.NpcClass("Cloned Mim3sis");
			NpcUtils.N_TerrorMimesis = new NpcUtils.NpcClass("Terror Mime5is");
			NpcUtils.N_KamikazeMimesis = new NpcUtils.NpcClass("Kamikaze Mime5is");
			NpcUtils.N_ReflectorMimesis = new NpcUtils.NpcClass("Reflector Mimesi5");
			NpcUtils.N_EMFreighter = new NpcUtils.NpcClass("EM Freighter");
			NpcUtils.N_RaiderMimesis = new NpcUtils.NpcClass("Raider Mimes1s");
			NpcUtils.N_AssailantMimesis = new NpcUtils.NpcClass("Assailant M1mesis");
			NpcUtils.N_MedicMimesis = new NpcUtils.NpcClass("Medic Mim3sis");
			NpcUtils.N_HardyMimesis = new NpcUtils.NpcClass("Hardy Mime5is");
			NpcUtils.N_PiercingMimesis = new NpcUtils.NpcClass("Piercing Mimesi5");
			NpcUtils.N_ObscuredMimesis = new NpcUtils.NpcClass("Obscured M1mes1s");
			NpcUtils.N_HoundingMimesis = new NpcUtils.NpcClass("Hounding Mim3si5");
			NpcUtils.N_MirrorMimesis = new NpcUtils.NpcClass("Mirror M1m3si5");
			NpcUtils.N_SniperMimesis = new NpcUtils.NpcClass("Sniper M1mesi5");
			NpcUtils.N_MarkerMimesis = new NpcUtils.NpcClass("Marker Mim3si5");
			NpcUtils.Npcs = new ConcurrentDictionary<string, NpcUtils.NpcType>();
			NpcUtils.NpcsByMap = new Dictionary<int, List<NpcUtils.NpcType>>();
			NpcUtils.NpcById = new Dictionary<int, NpcUtils.NpcType>();
			NpcUtils.XmlNpcs = new Dictionary<int, string>();
			NpcUtils.XmlNpcIds = new Dictionary<string, int>();
			Dictionary<int, List<string>> dictionary = new Dictionary<int, List<string>>();
			dictionary[1] = new List<string>
			{
				"-=[ Streuner ]=-",
				"-=[ Recruit Streuner ]=-",
				"-=[ Aider Streuner ]=-"
			};
			dictionary[2] = new List<string>
			{
				"-=[ Streuner ]=-",
				"-=[ Lordakia ]=-",
				"..::{ Boss Streuner }::..",
				"..::{ Boss Lordakia }::..",
				"-=[ Recruit Streuner ]=-",
				"-=[ Aider Streuner ]=-"
			};
			dictionary[3] = new List<string>
			{
				"-=[ Lordakia ]=-",
				"-=[ Devolarium ]=-",
				"-=[ Mordon ]=-",
				"-=[ Saimon ]=-",
				"..::{ Boss Mordon }::..",
				"..::{ Boss Saimon }::..",
				"..::{ Boss Devolarium }::.."
			};
			dictionary[4] = new List<string>
			{
				"-=[ Lordakia ]=-",
				"-=[ Mordon ]=-",
				"-=[ Sibelon ]=-",
				"-=[ Saimon ]=-",
				"..::{ Boss Saimon }::..",
				"..::{ Boss Sibelon }::.."
			};
			dictionary[5] = dictionary[1];
			dictionary[6] = dictionary[2];
			dictionary[7] = dictionary[3];
			dictionary[8] = dictionary[4];
			dictionary[9] = dictionary[1];
			dictionary[10] = dictionary[2];
			dictionary[11] = dictionary[3];
			dictionary[12] = dictionary[4];
			dictionary[13] = new List<string>
			{
				"-=[ Deadly Battleray ]=-"
			};
			dictionary[14] = new List<string>
			{
				"-=[ Deadly Battleray ]=-"
			};
			dictionary[15] = new List<string>
			{
				"-=[ Deadly Battleray ]=-"
			};
			dictionary[16] = new List<string>
			{
				"-=[ Deadly Battleray ]=-"
			};
			dictionary[17] = new List<string>
			{
				"-=[ Lordakia ]=-",
				"Lordakium Spore",
				"-=[ Sibelonit ]=-",
				"-=[ Lordakium ]=-",
				"..::{ Boss Sibelonit }::..",
				"..::{ Boss Lordakium }::..."
			};
			dictionary[18] = new List<string>
			{
				"-=[ Kristallin ]=-",
				"-=[ Kristallon ]=-",
				"-=[ Protegit ]=-",
				"-=[ Cubikon ]=-",
				"..::{ Boss Kristallin }::..",
				"-=[ Plagued Kristallin ]=-",
				"Urge IV",
				"Regard CXI"
			};
			dictionary[19] = new List<string>
			{
				"-=[ Kristallin ]=-",
				"-=[ Kristallon ]=-",
				"..::{ Boss Kristallin }::..",
				"..::{ Boss Kristallon }::..",
				"Blighted Gygerthrall",
				"Blighted Kristallon",
				"Attitude XIII",
				"Observe X"
			};
			dictionary[20] = new List<string>
			{
				"-=[ StreuneR ]=-",
				"..::{ Boss StreuneR }::..",
				"\\\\ Purpose XXI //",
				"Capital I",
				"Find VII"
			};
			dictionary[21] = dictionary[17];
			dictionary[22] = dictionary[18];
			dictionary[23] = dictionary[19];
			dictionary[24] = dictionary[20];
			dictionary[25] = dictionary[17];
			dictionary[26] = dictionary[18];
			dictionary[27] = dictionary[19];
			dictionary[28] = dictionary[20];
			dictionary[29] = new List<string>
			{
				"..::{ Boss Streuner }::..",
				"..::{ Boss Lordakia }::..",
				"..::{ Boss Mordon }::..",
				"..::{ Boss Saimon }::..",
				"..::{ Boss Devolarium }::..",
				"..::{ Boss Sibelonit }::..",
				"..::{ Boss Sibelon }::..",
				"..::{ Boss Lordakium }::...",
				"..::{ Boss Kristallin }::..",
				"..::{ Boss Kristallon }::..",
				"..::{ Boss StreuneR }::..",
				"( UberStreuner )",
				"( UberLordakia )",
				"( UberMordon )",
				"( UberSaimon )",
				"( UberDevolarium )",
				"( UberSibelonit )",
				"( UberSibelon )",
				"( UberLordakium )",
				"( UberKristallin )",
				"( UberKristallon )",
				"( UberStreuneR )",
				"-=[ Deadly Battleray ]=-",
				"( Uber Interceptor )",
				"( Uber Barracuda )",
				"( Uber Saboteur )",
				"( Uber Annihilator )",
				"( Uber Battleray )"
			};
			dictionary[91] = new List<string>
			{
				"-=[ Interceptor ]=-",
				"-=[ Barracuda ]=-",
				"-=[ Saboteur ]=-",
				"-=[ Annihilator ]=-",
				"( Uber Interceptor )",
				"( Uber Barracuda )"
			};
			dictionary[92] = new List<string>
			{
				"-=[ Interceptor ]=-",
				"-=[ Barracuda ]=-",
				"-=[ Saboteur ]=-",
				"-=[ Annihilator ]=-",
				"( Uber Interceptor )",
				"( Uber Barracuda )",
				"( Uber Saboteur )",
				"( Uber Annihilator )"
			};
			dictionary[93] = new List<string>
			{
				"-=[ Interceptor ]=-",
				"-=[ Barracuda ]=-",
				"-=[ Saboteur ]=-",
				"-=[ Annihilator ]=-",
				"-=[ Battleray ]=-",
				"( Uber Interceptor )",
				"( Uber Barracuda )"
			};
			dictionary[306] = new List<string>
			{
				"\\\\ Impulse II //",
				"\\\\ Attend IX //",
				"\\\\ Invoke XVI //",
				"\\\\ Mindfire Behemoth //"
			};
			dictionary[307] = new List<string>
			{
				"\\\\ Impulse II //",
				"\\\\ Attend IX //",
				"\\\\ Invoke XVI //",
				"\\\\ Mindfire Behemoth //",
				"Urge IV",
				"Regard CXI"
			};
			dictionary[308] = new List<string>
			{
				"\\\\ Impulse II //",
				"\\\\ Attend IX //",
				"\\\\ Invoke XVI //",
				"\\\\ Mindfire Behemoth //",
				"Attitude XIII",
				"Observe X"
			};
			List<string> list = new List<string>();
			list.Add("Icy");
			list.Add("Kristallin");
			list.Add("Kristallon");
			list.Add("Boss Kristallin");
			list.Add("Boss Kristallon");
			list.Add("Synk");
			list.Add("Meteoroid");
			list.Add("Super Meteoroid");
			foreach (KeyValuePair<int, List<string>> keyValuePair in dictionary)
			{
				List<NpcUtils.NpcType> list2 = NpcUtils.NpcsByMap[keyValuePair.Key] = new List<NpcUtils.NpcType>();
				foreach (string string_ in keyValuePair.Value)
				{
					list2.Add(NpcUtils.NpcType.smethod_5(string_));
				}
			}
			Dictionary<int, List<NpcUtils.NpcType>> dictionary2 = new Dictionary<int, List<NpcUtils.NpcType>>();
			foreach (NpcUtils.NpcGroup npcGroup in new NpcUtils.NpcGroup[]
			{
				NpcUtils.GG_Alpha,
				NpcUtils.GG_Beta,
				NpcUtils.GG_Gamma
			})
			{
				dictionary2[(int)npcGroup.method_0()] = new List<NpcUtils.NpcType>
				{
					new NpcUtils.GGWaveType(NpcUtils.N_Streuner, npcGroup, 0, null),
					new NpcUtils.GGWaveType(NpcUtils.N_Lordakia, npcGroup, 4, null),
					new NpcUtils.GGWaveType(NpcUtils.N_Mordon, npcGroup, 8, null),
					new NpcUtils.GGWaveType(NpcUtils.N_Saimon, npcGroup, 12, null),
					new NpcUtils.GGWaveType(NpcUtils.N_Devolarium, npcGroup, 16, null),
					new NpcUtils.GGWaveType(NpcUtils.N_Kristallin, npcGroup, 20, null),
					new NpcUtils.GGWaveType(NpcUtils.N_Sibelon, npcGroup, 24, null),
					new NpcUtils.GGWaveType(NpcUtils.N_Sibelonit, npcGroup, 28, null),
					new NpcUtils.GGWaveType(NpcUtils.N_Kristallon, npcGroup, 32, null),
					new NpcUtils.GGWaveType(NpcUtils.N_Protegit, npcGroup, 36, null)
				};
			}
			dictionary2[(int)NpcUtils.GG_Lambda.method_0()] = new List<NpcUtils.NpcType>
			{
				new NpcUtils.GGWaveType(NpcUtils.N_Lordakia, NpcUtils.GG_Lambda, 0, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Saimon, NpcUtils.GG_Lambda, 3, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Devolarium, NpcUtils.GG_Lambda, 6, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Sibelonit, NpcUtils.GG_Lambda, 9, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Lordakium, NpcUtils.GG_Lambda, 12, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Kristallin, NpcUtils.GG_Lambda, 15, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Kristallin, NpcUtils.GG_Lambda, 18, null)
			};
			dictionary2[(int)NpcUtils.GG_Delta.method_0()] = new List<NpcUtils.NpcType>
			{
				new NpcUtils.GGWaveType(NpcUtils.N_Saimon, NpcUtils.GG_Delta, 0, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Streuner, NpcUtils.GG_Delta, 3, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Kristallin, NpcUtils.GG_Delta, 6, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Lordakium, NpcUtils.GG_Delta, 9, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Mordon, NpcUtils.GG_Delta, 12, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Sibelon, NpcUtils.GG_Delta, 15, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Sibelonit, NpcUtils.GG_Delta, 18, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Kristallon, NpcUtils.GG_Delta, 21, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Protegit, NpcUtils.GG_Delta, 24, null),
				new NpcUtils.GGWaveType(NpcUtils.N_demaNeR, NpcUtils.GG_Delta, 27, null)
			};
			dictionary2[(int)NpcUtils.GG_Epsilon.method_0()] = new List<NpcUtils.NpcType>
			{
				new NpcUtils.GGWaveType(NpcUtils.N_Vagrant, NpcUtils.GG_Epsilon, 0, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Marauder, NpcUtils.GG_Epsilon, 3, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Outcast, NpcUtils.GG_Epsilon, 6, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Outcast, NpcUtils.GG_Epsilon, 9, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Corsair, NpcUtils.GG_Epsilon, 12, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Hooligan, NpcUtils.GG_Epsilon, 15, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Hooligan, NpcUtils.GG_Epsilon, 18, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Ravager, NpcUtils.GG_Epsilon, 21, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Convict, NpcUtils.GG_Epsilon, 24, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Convict, NpcUtils.GG_Epsilon, 27, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Ravager, NpcUtils.GG_Epsilon, 28, null)
			};
			dictionary2[(int)NpcUtils.GG_Zeta.method_0()] = new List<NpcUtils.NpcType>
			{
				new NpcUtils.GGWaveType(NpcUtils.N_Infernal, NpcUtils.GG_Zeta, 0, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Scorcher, NpcUtils.GG_Zeta, 3, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Scorcher, NpcUtils.GG_Zeta, 6, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Scorcher, NpcUtils.GG_Zeta, 9, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Melter, NpcUtils.GG_Zeta, 12, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Melter, NpcUtils.GG_Zeta, 15, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Melter, NpcUtils.GG_Zeta, 18, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Melter, NpcUtils.GG_Zeta, 21, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Devourer, NpcUtils.GG_Zeta, 24, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Devourer, NpcUtils.GG_Zeta, 26, null)
			};
			dictionary2[(int)NpcUtils.GG_Kappa.method_0()] = new List<NpcUtils.NpcType>
			{
				new NpcUtils.GGWaveType(NpcUtils.N_Infernal, NpcUtils.GG_Kappa, 0, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Scorcher, NpcUtils.GG_Kappa, 3, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Icy, NpcUtils.GG_Kappa, 6, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Corsair, NpcUtils.GG_Kappa, 9, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Melter, NpcUtils.GG_Kappa, 12, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Annihilator, NpcUtils.GG_Kappa, 15, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Lordakium, NpcUtils.GG_Kappa, 18, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Saimon, NpcUtils.GG_Kappa, 21, null),
				new NpcUtils.GGWaveType(NpcUtils.N_demaNeR, NpcUtils.GG_Kappa, 24, null),
				new NpcUtils.GGWaveType(NpcUtils.N_Kucurbium, NpcUtils.GG_Kappa, 27, null),
				new NpcUtils.GGWaveType(NpcUtils.N_CenturyFalcon, NpcUtils.GG_Kappa, 28, null)
			};
			List<string> source = new List<string>
			{
				"Lordakia",
				"Boss Lordakia",
				"Uber Lordakia",
				"Saimon",
				"Uber Sibelon",
				"Boss Devolarium",
				"Mordon",
				"UFONIT",
				"Uber Saimon",
				"Uber Lordakium",
				"Uber Kristallon",
				"Boss Sibelon",
				"Boss Mordon",
				"Uber Saimon",
				"Demon Drone",
				"Melter",
				"Boss Kristallon",
				"Devourer",
				"Uber Sibelonit",
				"UFO",
				"Cubikon",
				"Streuner",
				"Uber Kristallin"
			};
			dictionary2[(int)NpcUtils.GG_VoT.method_0()] = source.Select(new Func<string, NpcUtils.NpcType>(NpcUtils.<>c.<>9.method_0)).ToList<NpcUtils.NpcType>();
			dictionary2[(int)NpcUtils.GG_Kronos.method_0()] = new List<NpcUtils.NpcType>
			{
				new NpcUtils.GGWaveType(null, NpcUtils.GG_Kronos, 0, "Phoenix/Yamato"),
				new NpcUtils.GGWaveType(null, NpcUtils.GG_Kronos, 3, "Defcom/Liberator"),
				new NpcUtils.GGWaveType(null, NpcUtils.GG_Kronos, 7, "Nostromo/Piranha"),
				new NpcUtils.GGWaveType(null, NpcUtils.GG_Kronos, 11, "BigBoy"),
				new NpcUtils.GGWaveType(null, NpcUtils.GG_Kronos, 15, "Vengeance"),
				new NpcUtils.GGWaveType(null, NpcUtils.GG_Kronos, 19, "Leonov"),
				new NpcUtils.GGWaveType(null, NpcUtils.GG_Kronos, 23, "Goliath"),
				new NpcUtils.GGWaveType(null, NpcUtils.GG_Kronos, 28, "Vengeance/Goliath"),
				new NpcUtils.GGWaveType(null, NpcUtils.GG_Kronos, 33, "Vengeance"),
				new NpcUtils.GGWaveType(null, NpcUtils.GG_Kronos, 38, "Goliath"),
				new NpcUtils.GGWaveType(null, NpcUtils.GG_Kronos, 41, "Goliath"),
				new NpcUtils.GGWaveType(null, NpcUtils.GG_Kronos, 45, "Goliath"),
				new NpcUtils.GGWaveType(null, NpcUtils.GG_Kronos, 48, "Clone/Iris"),
				new NpcUtils.GGWaveType(null, NpcUtils.GG_Kronos, 50, "Rewards")
			};
			dictionary2[(int)NpcUtils.GG_Kuiper.method_0()] = new List<NpcUtils.NpcType>
			{
				new NpcUtils.GGWaveType(NpcUtils.N_StreuneR, NpcUtils.GG_Kuiper, 0, null),
				new NpcUtils.GGWaveType(NpcUtils.N_StreuneR, NpcUtils.GG_Kuiper, 3, null),
				new NpcUtils.GGWaveType(NpcUtils.N_StreunerSoldier, NpcUtils.GG_Kuiper, 9, null),
				new NpcUtils.GGWaveType(NpcUtils.N_StreunerTurret, NpcUtils.GG_Kuiper, 19, null),
				new NpcUtils.GGWaveType(NpcUtils.N_StreuneR, NpcUtils.GG_Kuiper, 39, null)
			};
			List<string> source2 = new List<string>
			{
				"Ice Meteoroid",
				"Icy",
				"Super Ice Meteoroid",
				"Skolls Icy",
				"Skoll"
			};
			dictionary2[(int)NpcUtils.GG_ColdWave.method_0()] = source2.Select(new Func<string, NpcUtils.NpcType>(NpcUtils.NpcType.smethod_5)).ToList<NpcUtils.NpcType>();
			List<string> source3 = new List<string>
			{
				"Viral Kristallon",
				"Plague Rocket",
				"Viral Gygerthrall",
				"Gygerim Overlord"
			};
			dictionary2[(int)NpcUtils.GG_QZ.method_0()] = source3.Select(new Func<string, NpcUtils.NpcType>(NpcUtils.NpcType.smethod_5)).ToList<NpcUtils.NpcType>();
			foreach (KeyValuePair<int, List<NpcUtils.NpcType>> keyValuePair2 in dictionary2)
			{
				NpcUtils.NpcsByMap[keyValuePair2.Key] = keyValuePair2.Value;
			}
		}

		[CompilerGenerated]
		internal static string smethod_2(string string_0, ref NpcUtils.<>c__DisplayClass124_0 <>c__DisplayClass124_0_0)
		{
			return Regex.Replace(string_0, <>c__DisplayClass124_0_0.uberPattern, "Uber $1");
		}

		public static readonly List<NpcUtils.NpcGroup> Groups;

		public static readonly NpcUtils.NpcGroup G_Regular;

		public static readonly NpcUtils.NpcGroup G_Boss;

		public static readonly NpcUtils.NpcGroup G_Uber;

		public static readonly NpcUtils.NpcGroup G_Recruit;

		public static readonly NpcUtils.NpcGroup G_Aider;

		public static readonly NpcUtils.NpcGroup G_Blighted;

		public static readonly NpcUtils.NpcGroup G_Plagued;

		public static readonly NpcUtils.NpcGroup GG_Alpha;

		public static readonly NpcUtils.NpcGroup GG_Beta;

		public static readonly NpcUtils.NpcGroup GG_Gamma;

		public static readonly NpcUtils.NpcGroup GG_Lambda;

		public static readonly NpcUtils.NpcGroup GG_Delta;

		public static readonly NpcUtils.NpcGroup GG_Epsilon;

		public static readonly NpcUtils.NpcGroup GG_Zeta;

		public static readonly NpcUtils.NpcGroup GG_Kappa;

		public static readonly NpcUtils.NpcGroup GG_VoT;

		public static readonly NpcUtils.NpcGroup G_Emperor;

		public static readonly NpcUtils.NpcGroup GG_Kronos;

		public static readonly NpcUtils.NpcGroup GG_Kuiper;

		public static readonly NpcUtils.NpcGroup GG_ColdWave;

		public static readonly NpcUtils.NpcGroup G_Skolls;

		public static readonly NpcUtils.NpcGroup G_Super;

		public static readonly NpcUtils.NpcGroup G_Viral;

		public static readonly NpcUtils.NpcGroup GG_QZ;

		public static readonly NpcUtils.NpcClass N_Streuner;

		public static readonly NpcUtils.NpcClass N_Lordakia;

		public static readonly NpcUtils.NpcClass N_Saimon;

		public static readonly NpcUtils.NpcClass N_Mordon;

		public static readonly NpcUtils.NpcClass N_Devolarium;

		public static readonly NpcUtils.NpcClass N_Sibelon;

		public static readonly NpcUtils.NpcClass N_Sibelonit;

		public static readonly NpcUtils.NpcClass N_Lordakium;

		public static readonly NpcUtils.NpcClass N_Kristallin;

		public static readonly NpcUtils.NpcClass N_Kristallon;

		public static readonly NpcUtils.NpcClass N_Cubikon;

		public static readonly NpcUtils.NpcClass N_Protegit;

		public static readonly NpcUtils.NpcClass N_StreuneR;

		public static readonly NpcUtils.NpcClass N_demaNeR;

		public static readonly NpcUtils.NpcClass N_Marauder;

		public static readonly NpcUtils.NpcClass N_Vagrant;

		public static readonly NpcUtils.NpcClass N_Outcast;

		public static readonly NpcUtils.NpcClass N_Hooligan;

		public static readonly NpcUtils.NpcClass N_Corsair;

		public static readonly NpcUtils.NpcClass N_Convict;

		public static readonly NpcUtils.NpcClass N_Ravager;

		public static readonly NpcUtils.NpcClass N_Infernal;

		public static readonly NpcUtils.NpcClass N_Scorcher;

		public static readonly NpcUtils.NpcClass N_Saboteur;

		public static readonly NpcUtils.NpcClass N_Melter;

		public static readonly NpcUtils.NpcClass N_Devourer;

		public static readonly NpcUtils.NpcClass N_IceMeteoroid;

		public static readonly NpcUtils.NpcClass N_Icy;

		public static readonly NpcUtils.NpcClass N_Interceptor;

		public static readonly NpcUtils.NpcClass N_Baracuda;

		public static readonly NpcUtils.NpcClass N_Annihilator;

		public static readonly NpcUtils.NpcClass N_Battleray;

		public static readonly NpcUtils.NpcClass N_Kucurbium;

		public static readonly NpcUtils.NpcClass N_CenturyFalcon;

		public static readonly NpcUtils.NpcClass N_SeekerRocket;

		public static readonly NpcUtils.NpcClass N_StreunerRocketeer;

		public static readonly NpcUtils.NpcClass N_StreunerSoldier;

		public static readonly NpcUtils.NpcClass N_StreunerTurret;

		public static readonly NpcUtils.NpcClass N_StreunerSpecialist;

		public static readonly NpcUtils.NpcClass N_StreunerEmporer;

		public static readonly NpcUtils.NpcClass N_Curcubitor;

		public static readonly NpcUtils.NpcClass N_DemonDrone;

		public static readonly NpcUtils.NpcClass N_UFO;

		public static readonly NpcUtils.NpcClass N_UFONIT;

		public static readonly NpcUtils.NpcClass N_IEgg;

		public static readonly NpcUtils.NpcClass N_IGygerthrall;

		public static readonly NpcUtils.NpcClass N_Gygerthrall;

		public static readonly NpcUtils.NpcClass N_Hitac;

		public static readonly NpcUtils.NpcClass N_DemanerCorsair;

		public static readonly NpcUtils.NpcClass N_Impulse;

		public static readonly NpcUtils.NpcClass N_Attend;

		public static readonly NpcUtils.NpcClass N_Invoke;

		public static readonly NpcUtils.NpcClass N_MindfireBehemoth;

		public static readonly NpcUtils.NpcClass N_Purpose;

		public static readonly NpcUtils.NpcClass N_Urge;

		public static readonly NpcUtils.NpcClass N_Attitude;

		public static readonly NpcUtils.NpcClass N_Capital;

		public static readonly NpcUtils.NpcClass N_Regard;

		public static readonly NpcUtils.NpcClass N_Observe;

		public static readonly NpcUtils.NpcClass N_Find;

		public static readonly NpcUtils.NpcClass N_Unknown;

		public static readonly NpcUtils.NpcClass N_LordakiumSpore;

		public static readonly NpcUtils.NpcClass N_Skoll;

		public static readonly NpcUtils.NpcClass N_Meteoroid;

		public static readonly NpcUtils.NpcClass N_Synk;

		public static readonly NpcUtils.NpcClass N_PlagueRocket;

		public static readonly NpcUtils.NpcClass N_GygerimOverlord;

		public static readonly NpcUtils.NpcClass N_ChaosProtegit;

		public static readonly NpcUtils.NpcClass N_Lanatum;

		public static readonly NpcUtils.NpcClass N_Styxus;

		public static readonly NpcUtils.NpcClass N_Charopos;

		public static readonly NpcUtils.NpcClass N_HexorMimesis;

		public static readonly NpcUtils.NpcClass N_RagingMimesis;

		public static readonly NpcUtils.NpcClass N_CloningMimesis;

		public static readonly NpcUtils.NpcClass N_ClonedMimesis;

		public static readonly NpcUtils.NpcClass N_TerrorMimesis;

		public static readonly NpcUtils.NpcClass N_KamikazeMimesis;

		public static readonly NpcUtils.NpcClass N_ReflectorMimesis;

		public static readonly NpcUtils.NpcClass N_EMFreighter;

		public static readonly NpcUtils.NpcClass N_RaiderMimesis;

		public static readonly NpcUtils.NpcClass N_AssailantMimesis;

		public static readonly NpcUtils.NpcClass N_MedicMimesis;

		public static readonly NpcUtils.NpcClass N_HardyMimesis;

		public static readonly NpcUtils.NpcClass N_PiercingMimesis;

		public static readonly NpcUtils.NpcClass N_ObscuredMimesis;

		public static readonly NpcUtils.NpcClass N_HoundingMimesis;

		public static readonly NpcUtils.NpcClass N_MirrorMimesis;

		public static readonly NpcUtils.NpcClass N_SniperMimesis;

		public static readonly NpcUtils.NpcClass N_MarkerMimesis;

		private static readonly ConcurrentDictionary<string, NpcUtils.NpcType> Npcs;

		public static readonly Dictionary<int, List<NpcUtils.NpcType>> NpcsByMap;

		public static readonly Dictionary<int, NpcUtils.NpcType> NpcById;

		public static readonly Dictionary<int, string> XmlNpcs;

		public static readonly Dictionary<string, int> XmlNpcIds;

		public class GGWaveType : NpcUtils.NpcType
		{
			public int WaveNumber { get; set; }

			public string Description { get; set; }

			public GGWaveType(NpcUtils.NpcClass npcClass_0, NpcUtils.NpcGroup npcGroup_0, int int_0, string string_0 = null)
			{
				Class13.F93tSdiz1aNIA();
				base..ctor(npcClass_0, npcGroup_0, false);
				this.WaveNumber = int_0;
				this.Description = string_0;
				base.Id = Interlocked.Increment(ref NpcUtils.GGWaveType.LastGGId);
				NpcUtils.NpcById[base.Id] = this;
			}

			public override string ToString()
			{
				string format = "{0}{1} {2} {3}";
				object[] array = new object[4];
				int num = 0;
				NpcUtils.NpcGroup group = base.Group;
				array[num] = ((group != null) ? group.DisplayName : null);
				array[1] = this.WaveNumber;
				int num2 = 2;
				NpcUtils.NpcClass @class = base.Class;
				array[num2] = ((@class != null) ? @class.Name : null);
				array[3] = this.Description;
				return string.Format(format, array);
			}

			// Note: this type is marked as 'beforefieldinit'.
			static GGWaveType()
			{
				Class13.F93tSdiz1aNIA();
				NpcUtils.GGWaveType.LastGGId = 2146483647;
			}

			public static int LastGGId;
		}

		public class NpcType
		{
			[DataMember(Order = 1)]
			public int Id { get; set; }

			[DataMember(Order = 2)]
			public NpcUtils.NpcClass Class { get; private set; }

			[DataMember(Order = 3)]
			public NpcUtils.NpcGroup Group { get; private set; }

			protected NpcType(NpcUtils.NpcClass npcClass_0, NpcUtils.NpcGroup npcGroup_0, bool bool_0 = true)
			{
				Class13.F93tSdiz1aNIA();
				base..ctor();
				this.Class = npcClass_0;
				this.Group = npcGroup_0;
				if (bool_0)
				{
					this.Id = ((int)this.Group.Id << 16 | (int)this.Class.Id);
					NpcUtils.NpcById[this.Id] = this;
				}
			}

			public static string smethod_0(string string_0)
			{
				NpcUtils.NpcType.<>c__DisplayClass14_0 CS$<>8__locals1 = new NpcUtils.NpcType.<>c__DisplayClass14_0();
				string_0 = string_0.Replace("-x-", "").Replace("xX[", "").Replace("]Xx", "");
				CS$<>8__locals1.includeNumbers = Regex.IsMatch(string_0, "(.+)\\sM[1i]m[3e][5s][1i][5s]");
				return new string(string_0.Where(new Func<char, bool>(CS$<>8__locals1.method_0)).ToArray<char>()).Trim();
			}

			public static NpcUtils.NpcType smethod_1(int int_0)
			{
				string string_;
				if (NpcUtils.XmlNpcs.TryGetValue(int_0, out string_))
				{
					return NpcUtils.NpcType.smethod_5(string_);
				}
				return null;
			}

			public static NpcUtils.NpcType smethod_2(NpcUtils.NpcGroup npcGroup_0, NpcUtils.NpcClass npcClass_0)
			{
				return NpcUtils.NpcType.smethod_5(npcGroup_0.ToString() + " " + npcClass_0.ToString());
			}

			public static NpcUtils.NpcType smethod_3(NpcUtils.NpcClass npcClass_0)
			{
				return NpcUtils.NpcType.smethod_2(NpcUtils.G_Regular, npcClass_0);
			}

			public static IEnumerable<NpcUtils.NpcType> smethod_4(params NpcUtils.NpcClass[] cls)
			{
				NpcUtils.NpcType.<GetList>d__18 <GetList>d__ = new NpcUtils.NpcType.<GetList>d__18(-2);
				<GetList>d__.<>3__cls = cls;
				return <GetList>d__;
			}

			public static NpcUtils.NpcType smethod_5(string string_0)
			{
				NpcUtils.NpcType.<>c__DisplayClass19_0 CS$<>8__locals1 = new NpcUtils.NpcType.<>c__DisplayClass19_0();
				CS$<>8__locals1.sanitized = NpcUtils.NpcType.smethod_0(string_0);
				NpcUtils.NpcType result;
				if (NpcUtils.Npcs.TryGetValue(CS$<>8__locals1.sanitized, out result))
				{
					return result;
				}
				if (CS$<>8__locals1.sanitized.StartsWith("Frozen"))
				{
					CS$<>8__locals1.sanitized = CS$<>8__locals1.sanitized.Substring(6).Trim();
				}
				NpcUtils.NpcGroup npcGroup_ = NpcUtils.G_Regular;
				if (CS$<>8__locals1.sanitized.StartsWith(NpcUtils.G_Boss.Name))
				{
					npcGroup_ = NpcUtils.G_Boss;
				}
				else if (CS$<>8__locals1.sanitized.StartsWith(NpcUtils.G_Uber.Name))
				{
					npcGroup_ = NpcUtils.G_Uber;
				}
				else if (CS$<>8__locals1.sanitized.StartsWith(NpcUtils.G_Recruit.Name))
				{
					npcGroup_ = NpcUtils.G_Recruit;
				}
				else if (CS$<>8__locals1.sanitized.StartsWith(NpcUtils.G_Aider.Name))
				{
					npcGroup_ = NpcUtils.G_Aider;
				}
				else if (CS$<>8__locals1.sanitized.StartsWith(NpcUtils.G_Blighted.Name))
				{
					npcGroup_ = NpcUtils.G_Blighted;
				}
				else if (CS$<>8__locals1.sanitized.StartsWith(NpcUtils.G_Plagued.Name))
				{
					npcGroup_ = NpcUtils.G_Plagued;
				}
				else if (CS$<>8__locals1.sanitized.StartsWith(NpcUtils.G_Emperor.Name))
				{
					npcGroup_ = NpcUtils.G_Emperor;
				}
				else if (CS$<>8__locals1.sanitized.StartsWith(NpcUtils.G_Super.Name))
				{
					npcGroup_ = NpcUtils.G_Super;
				}
				else if (CS$<>8__locals1.sanitized.StartsWith(NpcUtils.G_Skolls.Name))
				{
					npcGroup_ = NpcUtils.G_Skolls;
				}
				else if (CS$<>8__locals1.sanitized.StartsWith(NpcUtils.G_Viral.Name))
				{
					npcGroup_ = NpcUtils.G_Viral;
				}
				NpcUtils.NpcType npcType = NpcUtils.Npcs[CS$<>8__locals1.sanitized] = new NpcUtils.NpcType(NpcUtils.Classes.OrderByDescending(new Func<NpcUtils.NpcClass, int>(NpcUtils.NpcType.<>c.<>9.method_0)).FirstOrDefault(new Func<NpcUtils.NpcClass, bool>(CS$<>8__locals1.method_0)) ?? NpcUtils.N_Unknown, npcGroup_, true);
				if (npcType.Class == NpcUtils.N_Unknown)
				{
					LogManager.GetLogger("Base-Net-Handlers").Warn("Unknown npc: " + string_0);
				}
				return npcType;
			}

			public override string ToString()
			{
				NpcUtils.NpcGroup group = this.Group;
				string str = (group != null) ? group.DisplayName : null;
				string str2 = " ";
				NpcUtils.NpcClass @class = this.Class;
				return (str + str2 + ((@class != null) ? @class.Name : null)).Trim();
			}

			// Note: this type is marked as 'beforefieldinit'.
			static NpcType()
			{
				Class13.F93tSdiz1aNIA();
			}

			public static int LastId;
		}

		public class NpcClass
		{
			[DataMember(Order = 1)]
			public string Name { get; private set; }

			public short Id { get; private set; }

			internal NpcClass(string string_0)
			{
				Class13.F93tSdiz1aNIA();
				base..ctor();
				this.Name = string_0;
				NpcUtils.Classes.Add(this);
				this.Id = (short)Interlocked.Increment(ref NpcUtils.NpcClass.LastId);
			}

			public override int GetHashCode()
			{
				string name = this.Name;
				if (name == null)
				{
					return 0;
				}
				return name.GetHashCode();
			}

			public override string ToString()
			{
				return this.Name;
			}

			// Note: this type is marked as 'beforefieldinit'.
			static NpcClass()
			{
				Class13.F93tSdiz1aNIA();
				NpcUtils.NpcClass.LastId = 1;
			}

			public static int LastId;
		}

		public class NpcGroup
		{
			[DataMember(Order = 1)]
			public string Name { get; private set; }

			[DataMember(Order = 2)]
			public string DisplayName { get; private set; }

			public short Id { get; private set; }

			internal NpcGroup(string string_0, string string_1 = null)
			{
				Class13.F93tSdiz1aNIA();
				base..ctor();
				if (string_1 == null)
				{
					string_1 = string_0;
				}
				this.Name = string_0;
				this.DisplayName = string_1;
				NpcUtils.Groups.Add(this);
				this.Id = (short)Interlocked.Increment(ref NpcUtils.NpcGroup.LastId);
			}

			public GEnum5 method_0()
			{
				if (this == NpcUtils.GG_Alpha)
				{
					return (GEnum5)51;
				}
				if (this == NpcUtils.GG_Beta)
				{
					return (GEnum5)52;
				}
				if (this == NpcUtils.GG_Gamma)
				{
					return (GEnum5)53;
				}
				if (this == NpcUtils.GG_Lambda)
				{
					return (GEnum5)75;
				}
				if (this == NpcUtils.GG_Delta)
				{
					return (GEnum5)55;
				}
				if (this == NpcUtils.GG_Epsilon)
				{
					return (GEnum5)70;
				}
				if (this == NpcUtils.GG_Zeta)
				{
					return (GEnum5)71;
				}
				if (this == NpcUtils.GG_Kappa)
				{
					return (GEnum5)74;
				}
				if (this == NpcUtils.GG_VoT)
				{
					return (GEnum5)227;
				}
				if (this == NpcUtils.GG_Kronos)
				{
					return (GEnum5)76;
				}
				if (this == NpcUtils.GG_Kuiper)
				{
					return (GEnum5)300;
				}
				if (this == NpcUtils.GG_ColdWave)
				{
					return (GEnum5)77;
				}
				if (this == NpcUtils.GG_QZ)
				{
					return (GEnum5)229;
				}
				return GEnum5.None;
			}

			public override string ToString()
			{
				return this.DisplayName ?? this.Name;
			}

			// Note: this type is marked as 'beforefieldinit'.
			static NpcGroup()
			{
				Class13.F93tSdiz1aNIA();
				NpcUtils.NpcGroup.LastId = 1;
			}

			public static int LastId;
		}
	}
}
