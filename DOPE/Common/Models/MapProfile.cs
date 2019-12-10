using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using DarkorbitAPI;
using DarkorbitAPI.Structures;
using DOPE.UI.Models;

namespace DOPE.Common.Models
{
	[DataContract]
	[Guid("2625FEDE-9CCE-40B7-BC31-2AB07A1B2D62")]
	public class MapProfile : INotifyPropertyChanged
	{
		[DataMember(Order = 1)]
		[Layout(GroupName = "Main", Description = "Enable map profile")]
		public bool Enabled
		{
			[CompilerGenerated]
			get
			{
				return this.<Enabled>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Enabled>k__BackingField == value)
				{
					return;
				}
				this.<Enabled>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.Enabled);
			}
		}

		[Range(0, 9999999)]
		[DataMember(Order = 25)]
		[Layout(GroupName = "Main", Description = "Priority", RightDescription = "Higher number -> higher priority")]
		public int Priority
		{
			[CompilerGenerated]
			get
			{
				return this.<Priority>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Priority>k__BackingField == value)
				{
					return;
				}
				this.<Priority>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_68);
			}
		}

		[DataMember(Order = 2)]
		public string Name
		{
			get
			{
				return this.GetProfileName();
			}
			set
			{
				if (string.Equals(this.Name, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<>OnPropertyChanged(Class3.Name);
			}
		}

		[DataMember(Order = 4)]
		[Layout(GroupName = "Collector", Description = "Enable box collector")]
		[DefaultValue(true)]
		public bool Collector
		{
			[CompilerGenerated]
			get
			{
				return this.<Collector>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Collector>k__BackingField == value)
				{
					return;
				}
				this.<Collector>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_15);
			}
		}

		[DefaultValue(true)]
		[DataMember(Order = 5)]
		[Layout(GroupName = "Hunter", Description = "Enable NPC hunter")]
		public bool Hunter
		{
			[CompilerGenerated]
			get
			{
				return this.<Hunter>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Hunter>k__BackingField == value)
				{
					return;
				}
				this.<Hunter>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_48);
			}
		}

		[DataMember(Order = 6)]
		[Layout(GroupName = "Collector", Description = "Stay cloaked", RightDescription = "Works only if NPC hunter is disabled", CustomVisibility = "obj => obj.ModuleType == 0 && !obj.Name.startsWith('GG ')")]
		public bool Cloak
		{
			[CompilerGenerated]
			get
			{
				return this.<Cloak>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Cloak>k__BackingField == value)
				{
					return;
				}
				this.<Cloak>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_9);
			}
		}

		[DefaultValue(true)]
		[DataMember(Order = 7)]
		[Layout(GroupName = "Collector", Description = "Collect bonus boxes")]
		public bool CollectBonus
		{
			[CompilerGenerated]
			get
			{
				return this.<CollectBonus>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CollectBonus>k__BackingField == value)
				{
					return;
				}
				this.<CollectBonus>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_10);
			}
		}

		[DataMember(Order = 8)]
		[Layout(GroupName = "Collector", Description = "Collect cargo boxes")]
		public bool CollectCargo
		{
			[CompilerGenerated]
			get
			{
				return this.<CollectCargo>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CollectCargo>k__BackingField == value)
				{
					return;
				}
				this.<CollectCargo>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_11);
			}
		}

		[DataMember(Order = 9)]
		[Layout(GroupName = "Collector", Description = "Collect materials")]
		public bool CollectMaterials
		{
			[CompilerGenerated]
			get
			{
				return this.<CollectMaterials>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CollectMaterials>k__BackingField == value)
				{
					return;
				}
				this.<CollectMaterials>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_14);
			}
		}

		[DefaultValue(true)]
		[Layout(GroupName = "Main_Safety", Description = "Flee from enemies seen")]
		[DataMember(Order = 10)]
		public bool FleeFromEnemySeen
		{
			[CompilerGenerated]
			get
			{
				return this.<FleeFromEnemySeen>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<FleeFromEnemySeen>k__BackingField == value)
				{
					return;
				}
				this.<FleeFromEnemySeen>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_32);
			}
		}

		[DefaultValue(false)]
		[DataMember(Order = 29)]
		[Layout(GroupName = "Main_Safety", Description = "Flee only from known enemies", RightDescription = "DOPE remembers all aggressors reported by its users in the last 24 hours")]
		public bool FleeOnlyFromKnownEnemySeen
		{
			[CompilerGenerated]
			get
			{
				return this.<FleeOnlyFromKnownEnemySeen>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<FleeOnlyFromKnownEnemySeen>k__BackingField == value)
				{
					return;
				}
				this.<FleeOnlyFromKnownEnemySeen>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_33);
			}
		}

		[DataMember(Order = 11)]
		[DefaultValue(true)]
		[Layout(GroupName = "Main_Safety", Description = "Flee from enemy on attack")]
		public bool FleeFromEnemyAttacker
		{
			[CompilerGenerated]
			get
			{
				return this.<FleeFromEnemyAttacker>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<FleeFromEnemyAttacker>k__BackingField == value)
				{
					return;
				}
				this.<FleeFromEnemyAttacker>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_31);
			}
		}

		[Layout(GroupName = "Main_Safety", Description = "Stop fleeing on enemy lost")]
		[DataMember(Order = 34)]
		public bool FleeStopOnEnemyLost
		{
			[CompilerGenerated]
			get
			{
				return this.<FleeStopOnEnemyLost>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<FleeStopOnEnemyLost>k__BackingField == value)
				{
					return;
				}
				this.<FleeStopOnEnemyLost>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_34);
			}
		}

		[DefaultValue(40)]
		[Layout(GroupName = "Main_Safety", Description = "Repair below % HP", CustomVisibility = "obj => obj.ModuleType != 1")]
		[DataMember(Order = 12)]
		[Range(0, 100)]
		public int MinHp
		{
			[CompilerGenerated]
			get
			{
				return this.<MinHp>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<MinHp>k__BackingField == value)
				{
					return;
				}
				this.<MinHp>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_58);
			}
		}

		[DefaultValue(60)]
		[Layout(GroupName = "Main_Safety", Description = "Use heal ability below % HP")]
		[DataMember(Order = 37)]
		public int MinHealHp
		{
			[CompilerGenerated]
			get
			{
				return this.<MinHealHp>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<MinHealHp>k__BackingField == value)
				{
					return;
				}
				this.<MinHealHp>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_57);
			}
		}

		[DataMember(Order = 13)]
		[DefaultValue(TargetMap.X1)]
		public TargetMap TargetMap
		{
			[CompilerGenerated]
			get
			{
				return this.<TargetMap>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<TargetMap>k__BackingField == value)
				{
					return;
				}
				this.<TargetMap>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.Name);
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_92);
			}
		}

		[DataMember(Order = 14)]
		[Layout(GroupName = "Main_Safety", Description = "Wait X seconds after fleeing")]
		[DefaultValue(60)]
		public int FleeTimeout
		{
			[CompilerGenerated]
			get
			{
				return this.<FleeTimeout>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<FleeTimeout>k__BackingField == value)
				{
					return;
				}
				this.<FleeTimeout>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_35);
			}
		}

		[DataMember(Order = 30)]
		[Layout(GroupName = "Main", Description = "Revive at nearest portal")]
		public bool ReviveAtPortal
		{
			[CompilerGenerated]
			get
			{
				return this.<ReviveAtPortal>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ReviveAtPortal>k__BackingField == value)
				{
					return;
				}
				this.<ReviveAtPortal>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.BcZiyZsfvUq);
			}
		}

		[DataMember(Order = 15)]
		[Layout(GroupName = "Main_Config", Description = "Flying config")]
		[DefaultValue(1)]
		[Range(1, 2)]
		public int FlyingConfig
		{
			[CompilerGenerated]
			get
			{
				return this.<FlyingConfig>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<FlyingConfig>k__BackingField == value)
				{
					return;
				}
				this.<FlyingConfig>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_36);
			}
		}

		[DataMember(Order = 16)]
		[Layout(GroupName = "Main_Config", Description = "Flying config formation")]
		public GEnum4 FlyingFormation
		{
			[CompilerGenerated]
			get
			{
				return this.<FlyingFormation>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<FlyingFormation>k__BackingField == value)
				{
					return;
				}
				this.<FlyingFormation>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_37);
			}
		}

		[DefaultValue(1)]
		[DataMember(Order = 31)]
		[Range(1, 2)]
		[Layout(GroupName = "Main_Config", Description = "Flee config")]
		public int FleeConfig
		{
			[CompilerGenerated]
			get
			{
				return this.<FleeConfig>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<FleeConfig>k__BackingField == value)
				{
					return;
				}
				this.<FleeConfig>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_29);
			}
		}

		[DataMember(Order = 32)]
		[Layout(GroupName = "Main_Config", Description = "Flee config formation")]
		public GEnum4 FleeFormation
		{
			[CompilerGenerated]
			get
			{
				return this.<FleeFormation>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<FleeFormation>k__BackingField == value)
				{
					return;
				}
				this.<FleeFormation>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_30);
			}
		}

		[DataMember(Order = 17)]
		[DefaultValue(2)]
		[Layout(GroupName = "Main_Config", Description = "Attack config")]
		[Range(1, 2)]
		public int AttackConfig
		{
			[CompilerGenerated]
			get
			{
				return this.<AttackConfig>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<AttackConfig>k__BackingField == value)
				{
					return;
				}
				this.<AttackConfig>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_0);
			}
		}

		[Layout(GroupName = "Main_Config", Description = "Attack config formation")]
		[DataMember(Order = 18)]
		public GEnum4 AttackFormation
		{
			[CompilerGenerated]
			get
			{
				return this.<AttackFormation>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<AttackFormation>k__BackingField == value)
				{
					return;
				}
				this.<AttackFormation>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_1);
			}
		}

		[Layout(GroupName = "Main_Config", Description = "Use Moth formation to kill corner NPCs", CustomVisibility = "obj => obj.Name.startsWith('GG ')")]
		[DataMember(Order = 36)]
		public bool UseMothToKillCorners
		{
			[CompilerGenerated]
			get
			{
				return this.<UseMothToKillCorners>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<UseMothToKillCorners>k__BackingField == value)
				{
					return;
				}
				this.<UseMothToKillCorners>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_98);
			}
		}

		[DataMember(Order = 19)]
		[DefaultValue(true)]
		[Layout(GroupName = "Hunter", Description = "Circle NPCs", CustomVisibility = "obj => !obj.Name.startsWith('GG ')")]
		public bool CircleNpcs
		{
			[CompilerGenerated]
			get
			{
				return this.<CircleNpcs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CircleNpcs>k__BackingField == value)
				{
					return;
				}
				this.<CircleNpcs>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_7);
			}
		}

		[DataMember(Order = 39)]
		[Layout(GroupName = "Hunter", Description = "Drag NPCs instead of circling", CustomVisibility = "obj => obj.Name.startsWith('GG ')")]
		[DefaultValue(true)]
		public bool GG_DragNpcs
		{
			[CompilerGenerated]
			get
			{
				return this.<GG_DragNpcs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<GG_DragNpcs>k__BackingField == value)
				{
					return;
				}
				this.<GG_DragNpcs>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_38);
			}
		}

		[DefaultValue(true)]
		[DataMember(Order = 33)]
		[Layout(GroupName = "Hunter", Description = "Collect boxes while circling", CustomVisibility = "obj => !obj.Name.startsWith('GG ')")]
		public bool SecondaryCircleNpcs
		{
			[CompilerGenerated]
			get
			{
				return this.<SecondaryCircleNpcs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SecondaryCircleNpcs>k__BackingField == value)
				{
					return;
				}
				this.<SecondaryCircleNpcs>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_72);
			}
		}

		[Layout(GroupName = "Hunter_Ammo", Description = "Default laser")]
		[DefaultValue(LaserType.LCB_10)]
		[DataMember(Order = 20)]
		public LaserType DefaultLaser
		{
			[CompilerGenerated]
			get
			{
				return this.<DefaultLaser>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<DefaultLaser>k__BackingField == value)
				{
					return;
				}
				this.<DefaultLaser>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_18);
			}
		}

		[DefaultValue(RocketType.None)]
		[DataMember(Order = 21)]
		[Layout(GroupName = "Hunter_Ammo", Description = "Default rockets")]
		public RocketType DefaultRocket
		{
			[CompilerGenerated]
			get
			{
				return this.<DefaultRocket>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<DefaultRocket>k__BackingField == value)
				{
					return;
				}
				this.<DefaultRocket>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_19);
			}
		}

		[DefaultValue(HellstormType.None)]
		[Layout(GroupName = "Hunter_Ammo", Description = "Default hellstorm")]
		[DataMember(Order = 22)]
		public HellstormType DefaultHellstorm
		{
			[CompilerGenerated]
			get
			{
				return this.<DefaultHellstorm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<DefaultHellstorm>k__BackingField == value)
				{
					return;
				}
				this.<DefaultHellstorm>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_17);
			}
		}

		[DefaultValue(60)]
		[Layout(GroupName = "Hunter_Ammo", Description = "Allow SAB-50 when shield below X%")]
		[Range(0, 100)]
		[DataMember(Order = 38)]
		public int MinSabShield
		{
			[CompilerGenerated]
			get
			{
				return this.<MinSabShield>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<MinSabShield>k__BackingField == value)
				{
					return;
				}
				this.<MinSabShield>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_59);
			}
		}

		[DataMember(Order = 41)]
		[Layout(GroupName = "Hunter_Ammo", Description = "Use rocket precision tech")]
		public bool UseRocketPrecision
		{
			[CompilerGenerated]
			get
			{
				return this.<UseRocketPrecision>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<UseRocketPrecision>k__BackingField == value)
				{
					return;
				}
				this.<UseRocketPrecision>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_103);
			}
		}

		[Layout(GroupName = "Hunter_Whitelist", CustomType = "collection")]
		[DataMember(Order = 23)]
		public ObservableCollection<SelectedNpcModel> NpcWhitelist
		{
			[CompilerGenerated]
			get
			{
				return this.<NpcWhitelist>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<NpcWhitelist>k__BackingField, value))
				{
					return;
				}
				this.<NpcWhitelist>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_62);
			}
		}

		[DataMember(Order = 26)]
		[Layout(GroupName = "Main", Description = "Use P.E.T.")]
		public PetModeSelection PetMode
		{
			[CompilerGenerated]
			get
			{
				return this.<PetMode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PetMode>k__BackingField == value)
				{
					return;
				}
				this.<PetMode>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_67);
			}
		}

		[DataMember(Order = 40)]
		[Layout(GroupName = "Main", Description = "Use kamikaze on corner NPCs", CustomVisibility = "obj => obj.Name.startsWith('GG ')")]
		public bool GG_UseKamikazeCorner
		{
			[CompilerGenerated]
			get
			{
				return this.<GG_UseKamikazeCorner>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<GG_UseKamikazeCorner>k__BackingField == value)
				{
					return;
				}
				this.<GG_UseKamikazeCorner>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_39);
			}
		}

		[Layout(GroupName = "Schedule", Description = "Change map after X deaths", RightDescription = "Leave 0 to disable")]
		[DataMember(Order = 3)]
		[Range(0, 2147483647)]
		[DefaultValue(0)]
		public int MaxDeaths
		{
			[CompilerGenerated]
			get
			{
				return this.<MaxDeaths>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<MaxDeaths>k__BackingField == value)
				{
					return;
				}
				this.<MaxDeaths>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_56);
			}
		}

		[DataMember(Order = 27)]
		[Layout(GroupName = "Schedule", Description = "Switch to another map profile after X minutes", RightDescription = "Leave 0 to disable")]
		[Range(0, 1440)]
		public int MapDuration
		{
			[CompilerGenerated]
			get
			{
				return this.<MapDuration>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<MapDuration>k__BackingField == value)
				{
					return;
				}
				this.<MapDuration>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_54);
			}
		}

		[DataMember(Order = 28)]
		[Range(0, 1440)]
		[Layout(GroupName = "Schedule", Description = "Map cooldown in minutes")]
		public int MapCooldown
		{
			[CompilerGenerated]
			get
			{
				return this.<MapCooldown>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<MapCooldown>k__BackingField == value)
				{
					return;
				}
				this.<MapCooldown>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_53);
			}
		}

		[DataMember(Order = 35)]
		public ModuleType ModuleType
		{
			[CompilerGenerated]
			get
			{
				return this.<ModuleType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ModuleType>k__BackingField == value)
				{
					return;
				}
				this.<ModuleType>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.Name);
				this.<>OnPropertyChanged(Class3.uhoiyUhsfEG);
			}
		}

		[IgnoreDataMember]
		public bool CollectPalladium
		{
			[CompilerGenerated]
			get
			{
				return this.<CollectPalladium>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CollectPalladium>k__BackingField == value)
				{
					return;
				}
				this.<CollectPalladium>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_16);
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public SelectedNpcModel GetModel(Ship ship, Map map = null, int? targetMap = null, int offsetWave = 0)
		{
			if (ship == null)
			{
				return null;
			}
			if (map != null)
			{
				int int_ = targetMap ?? map.MapId;
				if (MapUtils.smethod_6(int_) != GEnum5.None)
				{
					if (this.NpcWhitelist.Any((SelectedNpcModel t) => NpcUtils.NpcById[t.NpcId] is NpcUtils.GGWaveType))
					{
						GEnum5 type = MapUtils.smethod_6(int_);
						DarkOrbitWebAPI.GalaxyGatesInfo ggInfo = map.Game.Web.GgInfo;
						DarkOrbitWebAPI.jumpgateGate jumpgateGate = (ggInfo != null) ? ggInfo.GetGate(type) : null;
						if (jumpgateGate == null)
						{
							return null;
						}
						SelectedNpcModel result = null;
						int num = 0;
						foreach (KeyValuePair<SelectedNpcModel, NpcUtils.GGWaveType> keyValuePair in (from t in this.NpcWhitelist
						where NpcUtils.NpcById[t.NpcId] is NpcUtils.GGWaveType
						select t).ToDictionary((SelectedNpcModel t) => t, (SelectedNpcModel t) => (NpcUtils.GGWaveType)NpcUtils.NpcById[t.NpcId]))
						{
							if (jumpgateGate.currentWave >= keyValuePair.Value.WaveNumber)
							{
								if (offsetWave == 0)
								{
									result = keyValuePair.Key;
								}
							}
							else
							{
								num++;
								if (num == offsetWave)
								{
									result = keyValuePair.Key;
								}
							}
						}
						return result;
					}
				}
			}
			if (ship == Ship.Default)
			{
				return null;
			}
			string name = ship.Name;
			NpcUtils.NpcType npc = NpcUtils.NpcType.smethod_1(name);
			return this.NpcWhitelist.FirstOrDefault((SelectedNpcModel t) => t.NpcId == npc.Id);
		}

		public bool IsValidTarget(Ship ship)
		{
			SelectedNpcModel model = this.GetModel(ship, null, null, 0);
			return model != null && model.Enabled;
		}

		public bool GetAmmo(Ship ship, Map map, out LaserType a, out RocketType r, out HellstormType h)
		{
			a = ((this.DefaultLaser == LaserType.Default) ? LaserType.LCB_10 : this.DefaultLaser);
			r = this.DefaultRocket;
			h = this.DefaultHellstorm;
			if (!ship.IsNpc && !map.IsGG)
			{
				return false;
			}
			SelectedNpcModel model = this.GetModel(ship, map, null, 0);
			if (model == null)
			{
				if (!map.IsGG)
				{
					return false;
				}
			}
			else
			{
				a = ((model.Laser == LaserType.Default) ? a : model.Laser);
				r = ((model.Rocket == RocketType.Default) ? r : model.Rocket);
				h = ((model.Hellstorm == HellstormType.Default) ? h : model.Hellstorm);
				bool flag;
				if (map.method_7(ship, out flag) && model.GgCornerLaser != LaserType.Default)
				{
					a = model.GgCornerLaser;
				}
				else if (model.UseSab && ship.Shield >= 2000 && map.Hero.ShieldPercentage <= (float)this.MinSabShield && map.Hero.method_20("ammunition_laser_sab-50") > 100.0 && map.Hero.Formation != GEnum4.Moth)
				{
					a = LaserType.SAB_50;
				}
			}
			return true;
		}

		public void GetConfig(Ship attacking, Map map, out int attack, out int fly, out GEnum4 attackFormation, out GEnum4 flyFormation)
		{
			attack = this.AttackConfig;
			fly = this.FlyingConfig;
			attackFormation = this.AttackFormation;
			flyFormation = this.FlyingFormation;
			SelectedNpcModel model = this.GetModel(attacking, map, null, 0);
			if (model == null)
			{
				return;
			}
			if (model.Config != 0)
			{
				attack = model.Config;
			}
			if (model.DroneFormation != GEnum4.Default)
			{
				attackFormation = model.DroneFormation;
			}
		}

		public void Fill(Action<SelectedNpcModel> newModel = null)
		{
			MapProfile.<>c__DisplayClass175_0 CS$<>8__locals1 = new MapProfile.<>c__DisplayClass175_0();
			List<NpcUtils.NpcType> list = NpcUtils.smethod_0((int)this.TargetMap);
			MapProfile.<>c__DisplayClass175_0 CS$<>8__locals2 = CS$<>8__locals1;
			IEnumerable<int> collection;
			if (list != null)
			{
				collection = from t in list
				select t.Id;
			}
			else
			{
				IEnumerable<int> enumerable = new int[0];
				collection = enumerable;
			}
			CS$<>8__locals2.all = new HashSet<int>(collection);
			bool enabled = MapUtils.IsGG((int)this.TargetMap);
			if (list == null)
			{
				return;
			}
			HashSet<int> hashSet = new HashSet<int>(from t in list
			select t.Id);
			foreach (SelectedNpcModel selectedNpcModel in this.NpcWhitelist)
			{
				NpcUtils.NpcType npcType;
				if (NpcUtils.NpcById.TryGetValue(selectedNpcModel.NpcId, out npcType))
				{
					selectedNpcModel.Name = npcType.ToString();
					hashSet.Remove(selectedNpcModel.NpcId);
				}
			}
			foreach (int num in hashSet)
			{
				SelectedNpcModel selectedNpcModel2 = new SelectedNpcModel
				{
					Enabled = enabled,
					NpcId = num,
					Name = NpcUtils.NpcById[num].ToString()
				};
				if (newModel != null)
				{
					newModel(selectedNpcModel2);
				}
				this.NpcWhitelist.Add(selectedNpcModel2);
			}
			List<SelectedNpcModel> list2 = (from t in this.NpcWhitelist
			where CS$<>8__locals1.all.Contains(t.NpcId)
			orderby t.NpcId
			select t).ToList<SelectedNpcModel>();
			this.NpcWhitelist.Clear();
			foreach (SelectedNpcModel selectedNpcModel3 in list2)
			{
				this.NpcWhitelist.Add(selectedNpcModel3);
				selectedNpcModel3.Fill();
			}
			foreach (SelectedNpcModel selectedNpcModel4 in this.NpcWhitelist)
			{
				if (this.ModuleType == ModuleType.Default && !MapUtils.IsGG((int)this.TargetMap))
				{
					selectedNpcModel4.UseKamikaze = false;
				}
			}
			if (this.Priority < 0)
			{
				this.Priority = 0;
			}
		}

		public string GetProfileName()
		{
			if (this.ModuleType == ModuleType.Default)
			{
				return this.TargetMap.GetName();
			}
			if (this.ModuleType == ModuleType.Palladium)
			{
				return "Palladium";
			}
			if (this.ModuleType == ModuleType.Cubikons)
			{
				return "Cubikons";
			}
			return "Unknown";
		}

		public MapProfile()
		{
			this.<Collector>k__BackingField = true;
			this.<Hunter>k__BackingField = true;
			this.<CollectBonus>k__BackingField = true;
			this.<FleeFromEnemySeen>k__BackingField = true;
			this.<FleeFromEnemyAttacker>k__BackingField = true;
			this.<MinHp>k__BackingField = 40;
			this.<MinHealHp>k__BackingField = 60;
			this.<TargetMap>k__BackingField = TargetMap.X1;
			this.<FleeTimeout>k__BackingField = 60;
			this.<FlyingConfig>k__BackingField = 1;
			this.<FleeConfig>k__BackingField = 1;
			this.<AttackConfig>k__BackingField = 2;
			this.<CircleNpcs>k__BackingField = true;
			this.<GG_DragNpcs>k__BackingField = true;
			this.<SecondaryCircleNpcs>k__BackingField = true;
			this.<DefaultLaser>k__BackingField = LaserType.LCB_10;
			this.<DefaultRocket>k__BackingField = RocketType.None;
			this.<DefaultHellstorm>k__BackingField = HellstormType.None;
			this.<MinSabShield>k__BackingField = 60;
			this.<NpcWhitelist>k__BackingField = new ObservableCollection<SelectedNpcModel>();
			this.PropertyChanged = delegate(object sender, PropertyChangedEventArgs e)
			{
			};
			base..ctor();
		}

		protected void <>OnPropertyChanged(PropertyChangedEventArgs eventArgs)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, eventArgs);
			}
		}
	}
}
