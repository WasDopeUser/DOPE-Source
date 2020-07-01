using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using DarkorbitAPI.Structures;
using DOPE.UI.Models;

namespace DOPE.Common.Models
{
	[DataContract]
	[Guid("7122A7DC-8FD9-47B7-97FA-6170F257094D")]
	public class BotProfile : INotifyPropertyChanged
	{
		[DataMember(Order = 1)]
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Name>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Name>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.Name);
			}
		}

		[DataMember(Order = 20)]
		public List<MapProfile> Maps
		{
			[CompilerGenerated]
			get
			{
				return this.<Maps>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Maps>k__BackingField, value))
				{
					return;
				}
				this.<Maps>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_60);
			}
		}

		private void OnMapAdded(MapProfile map)
		{
			if (map.TargetMap == TargetMap.P52)
			{
				map.FleeFromEnemySeen = false;
			}
		}

		public BotProfile Fill()
		{
			typeof(TargetMap).GetEnumValues();
			HashSet<int> mapSet = new HashSet<int>();
			FieldInfo[] fields = typeof(TargetMap).GetFields(BindingFlags.Static | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			{
				FieldInfo fieldInfo = fields[i];
				int map = (int)fieldInfo.GetRawConstantValue();
				if (map != 0 && fieldInfo.GetCustomAttribute<NotMappedAttribute>() == null)
				{
					mapSet.Add(map);
					bool flag = MapUtils.smethod_6(map);
					MapProfile mapProfile = this.Maps.FirstOrDefault((MapProfile t) => t.TargetMap == (TargetMap)map);
					if (mapProfile == null)
					{
						List<MapProfile> maps = this.Maps;
						MapProfile mapProfile2 = new MapProfile();
						mapProfile2.TargetMap = (TargetMap)map;
						mapProfile2.Priority = (flag ? 999 : 0);
						mapProfile = mapProfile2;
						maps.Add(mapProfile2);
						this.OnMapAdded(mapProfile);
					}
					mapProfile.Fill(null);
				}
			}
			this.AddPalladiumModule();
			this.AddCubikonsModule();
			this.AddFrozenLabirynthModule();
			this.AddPayloadEscort();
			this.AddQuarantineZone();
			this.Maps = (from t in this.Maps
			where mapSet.Contains((int)t.TargetMap) || t.ModuleType > ModuleType.Default
			orderby t.ModuleType, t.TargetMap
			select t).ToList<MapProfile>();
			return this;
		}

		private void AddPalladiumModule()
		{
			MapProfile mapProfile = this.Maps.FirstOrDefault((MapProfile t) => t.ModuleType == ModuleType.Palladium);
			if (mapProfile == null)
			{
				List<MapProfile> maps = this.Maps;
				MapProfile mapProfile2 = new MapProfile();
				mapProfile2.ModuleType = ModuleType.Palladium;
				mapProfile2.ReviveAtPortal = true;
				mapProfile2.FleeFromEnemySeen = false;
				mapProfile2.Hunter = true;
				mapProfile2.SecondaryCircleNpcs = false;
				mapProfile = mapProfile2;
				maps.Add(mapProfile2);
			}
			mapProfile.TargetMap = TargetMap.P53;
			mapProfile.Cloak = false;
			mapProfile.MinHp = 0;
			mapProfile.Fill(delegate(SelectedNpcModel npc)
			{
				npc.Enabled = true;
				npc.Priority = -1;
			});
			int battlerayId = NpcUtils.NpcType.smethod_5("Battleray").Id;
			mapProfile.NpcWhitelist.First((SelectedNpcModel t) => t.NpcId == battlerayId).Enabled = false;
		}

		private void AddCubikonsModule()
		{
			MapProfile mapProfile = this.Maps.FirstOrDefault((MapProfile t) => t.ModuleType == ModuleType.Cubikons);
			if (mapProfile == null)
			{
				List<MapProfile> maps = this.Maps;
				MapProfile mapProfile2 = new MapProfile();
				mapProfile2.ModuleType = ModuleType.Cubikons;
				mapProfile = mapProfile2;
				maps.Add(mapProfile2);
			}
			mapProfile.TargetMap = TargetMap.X6;
			int cubikonId = NpcUtils.NpcType.smethod_5("Cubikon").Id;
			mapProfile.Fill(delegate(SelectedNpcModel npc)
			{
				npc.Enabled = true;
				npc.Priority = -1;
				if (npc.NpcId == cubikonId)
				{
					npc.Priority = 10;
					npc.IgnoreOwnership = true;
				}
			});
		}

		private void AddFrozenLabirynthModule()
		{
			bool frozenLabirynthEnabled = Constants.FrozenLabirynthEnabled;
			MapProfile mapProfile = this.Maps.FirstOrDefault((MapProfile t) => t.ModuleType == ModuleType.FrozenLabirynth);
			if (!frozenLabirynthEnabled)
			{
				if (mapProfile != null)
				{
					this.Maps.Remove(mapProfile);
				}
				return;
			}
			if (mapProfile == null)
			{
				List<MapProfile> maps = this.Maps;
				MapProfile mapProfile2 = new MapProfile();
				mapProfile2.ModuleType = ModuleType.FrozenLabirynth;
				mapProfile2.FleeFromEnemySeen = false;
				mapProfile = mapProfile2;
				maps.Add(mapProfile2);
			}
			mapProfile.TargetMap = TargetMap.FL_ATLAS_A;
			mapProfile.Fill(delegate(SelectedNpcModel npc)
			{
				npc.Enabled = true;
			});
		}

		private void AddPayloadEscort()
		{
			bool payloadEscortEnabled = Constants.PayloadEscortEnabled;
			MapProfile mapProfile = this.Maps.FirstOrDefault((MapProfile t) => t.ModuleType == ModuleType.PayloadEscort);
			if (!payloadEscortEnabled)
			{
				if (mapProfile != null)
				{
					this.Maps.Remove(mapProfile);
				}
				return;
			}
			if (mapProfile == null)
			{
				List<MapProfile> maps = this.Maps;
				MapProfile mapProfile2 = new MapProfile();
				mapProfile2.ModuleType = ModuleType.PayloadEscort;
				mapProfile2.FleeFromEnemySeen = false;
				mapProfile2.ReviveAtPortal = true;
				mapProfile2.Priority = 10;
				mapProfile = mapProfile2;
				maps.Add(mapProfile2);
			}
			mapProfile.FleeFromEnemyAttacker = false;
			mapProfile.TargetMap = TargetMap.PayloadEscort;
			IEnumerable<NpcUtils.NpcType> worthy = NpcUtils.NpcType.smethod_4(new NpcUtils.NpcClass[]
			{
				NpcUtils.N_PiercingMimesis,
				NpcUtils.N_ObscuredMimesis
			});
			mapProfile.Fill(delegate(SelectedNpcModel npc)
			{
				npc.Enabled = true;
				npc.IgnoreOwnership = true;
				npc.CircleRange = 545;
				if (worthy.Any((NpcUtils.NpcType t) => t.Id == npc.NpcId))
				{
					npc.Priority = Math.Max(1, npc.Priority);
				}
			});
		}

		private void AddQuarantineZone()
		{
			MapProfile mapProfile = this.Maps.FirstOrDefault((MapProfile t) => t.ModuleType == ModuleType.QuarantineZone);
			if (mapProfile == null)
			{
				List<MapProfile> maps = this.Maps;
				MapProfile mapProfile2 = new MapProfile();
				mapProfile2.ModuleType = ModuleType.QuarantineZone;
				mapProfile2.MinHp = 15;
				mapProfile = mapProfile2;
				maps.Add(mapProfile2);
			}
			mapProfile.TargetMap = TargetMap.GG_QZ;
			mapProfile.FleeFromEnemySeen = false;
			int kristallonId = NpcUtils.NpcType.smethod_2(NpcUtils.G_Viral, NpcUtils.N_Kristallon).Id;
			int bossId = NpcUtils.NpcType.smethod_2(NpcUtils.G_Regular, NpcUtils.N_GygerimOverlord).Id;
			int rocketId = NpcUtils.NpcType.smethod_2(NpcUtils.G_Regular, NpcUtils.N_PlagueRocket).Id;
			mapProfile.Fill(delegate(SelectedNpcModel npc)
			{
				npc.Enabled = true;
				if (npc.NpcId == kristallonId || npc.NpcId == bossId)
				{
					npc.GroupAttackMode = GroupAttackMode.Assist;
				}
				if (npc.NpcId == rocketId)
				{
					npc.Priority = 80;
					return;
				}
				if (npc.NpcId == kristallonId)
				{
					npc.Priority = 40;
					npc.CircleRange = 580;
					return;
				}
				if (npc.NpcId == bossId)
				{
					npc.Priority = 0;
					return;
				}
				npc.Priority = 60;
			});
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public BotProfile()
		{
			this.<Maps>k__BackingField = new List<MapProfile>();
			this.PropertyChanged = delegate(object sender, PropertyChangedEventArgs e)
			{
			};
			base..ctor();
		}

		[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
		[DebuggerNonUserCode]
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
