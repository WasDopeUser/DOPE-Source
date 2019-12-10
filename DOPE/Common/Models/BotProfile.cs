using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using DarkorbitAPI.Structures;
using DOPE.UI.Models;

namespace DOPE.Common.Models
{
	[Guid("7122A7DC-8FD9-47B7-97FA-6170F257094D")]
	[DataContract]
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
				this.<>OnPropertyChanged(Class3.Name);
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
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_55);
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
					bool flag = MapUtils.IsGG(map);
					MapProfile mapProfile = this.Maps.FirstOrDefault((MapProfile t) => t.TargetMap == (TargetMap)map);
					if (mapProfile == null)
					{
						List<MapProfile> maps = this.Maps;
						MapProfile mapProfile2 = new MapProfile();
						mapProfile2.TargetMap = (TargetMap)map;
						mapProfile2.Priority = (flag ? 999 : 0);
						mapProfile = mapProfile2;
						maps.Add(mapProfile2);
						if (map == 92)
						{
							mapProfile.FleeFromEnemySeen = false;
						}
					}
					mapProfile.Fill(null);
				}
			}
			this.AddPalladiumModule();
			this.AddCubikonsModule();
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
			int battlerayId = NpcUtils.NpcType.smethod_1("Battleray").Id;
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
			int cubikonId = NpcUtils.NpcType.smethod_1("Cubikon").Id;
			mapProfile.Fill(delegate(SelectedNpcModel npc)
			{
				npc.Enabled = true;
				npc.Priority = -1;
				if (npc.NpcId == cubikonId)
				{
					npc.Priority = 10;
				}
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
