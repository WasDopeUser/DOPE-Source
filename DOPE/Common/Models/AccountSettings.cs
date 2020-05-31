using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using DarkorbitAPI.CommonStructures;

namespace DOPE.Common.Models
{
	[Guid("A095ED63-D742-424A-83EB-2575A985AB60")]
	[DataContract]
	public class AccountSettings : INotifyPropertyChanged
	{
		[DataMember(Order = 1)]
		public bool Autostart
		{
			[CompilerGenerated]
			get
			{
				return this.<Autostart>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Autostart>k__BackingField == value)
				{
					return;
				}
				this.<Autostart>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_3);
			}
		}

		[Layout(GroupName = "Account", Description = "Stop after X deaths", RightDescription = "Leave 0 to disable")]
		[DataMember(Order = 37)]
		[Range(0, 999999999)]
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
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_61);
			}
		}

		[DefaultValue(true)]
		[DataMember(Order = 15)]
		[Layout(GroupName = "Account", Description = "Repair drones at >90% damage")]
		public bool RepairDrones
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairDrones>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<RepairDrones>k__BackingField == value)
				{
					return;
				}
				this.<RepairDrones>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_78);
			}
		}

		[Layout(Description = "Default hangar", GroupName = "Account_Hangars")]
		[DataMember(Order = 34)]
		[ComboBox("$Volatile.Hangars", "$Volatile.Hangars")]
		public string HangarDefault
		{
			[CompilerGenerated]
			get
			{
				return this.<HangarDefault>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<HangarDefault>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<HangarDefault>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_44);
			}
		}

		[Layout(Description = "5-3 Palladium collector hangar", GroupName = "Account_Hangars")]
		[DataMember(Order = 35)]
		[ComboBox("$Volatile.Hangars", "$Volatile.Hangars")]
		public string HangarPalladiumCollect
		{
			[CompilerGenerated]
			get
			{
				return this.<HangarPalladiumCollect>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<HangarPalladiumCollect>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<HangarPalladiumCollect>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_45);
			}
		}

		[Layout(Description = "5-2 Palladium seller hangar", GroupName = "Account_Hangars")]
		[DataMember(Order = 36)]
		[ComboBox("$Volatile.Hangars", "$Volatile.Hangars")]
		public string HangarPalladiumSell
		{
			[CompilerGenerated]
			get
			{
				return this.<HangarPalladiumSell>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<HangarPalladiumSell>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<HangarPalladiumSell>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_46);
			}
		}

		[DataMember(Order = 13)]
		[Layout(GroupName = "Account_Credentials", Description = "Username", Style = "readonly")]
		[Category("Credentials")]
		public string Username
		{
			[CompilerGenerated]
			get
			{
				return this.<Username>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Username>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Username>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.BotName);
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_113);
			}
		}

		[Category("Credentials")]
		[DataMember(Order = 3)]
		[Layout(GroupName = "Account_Credentials", Style = "password", Description = "Password")]
		public string Password
		{
			[CompilerGenerated]
			get
			{
				return this.<Password>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Password>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Password>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_71);
			}
		}

		[DataMember(Order = 4)]
		[Category("Credentials")]
		[Layout(GroupName = "Account_Credentials", Description = "Server (eg. int1)", Style = "readonly")]
		public string Server
		{
			[CompilerGenerated]
			get
			{
				return this.<Server>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Server>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Server>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.BotName);
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_83);
			}
		}

		[DataMember(Order = 5, EmitDefaultValue = true)]
		[Layout(GroupName = "Account_Credentials", Description = "Browser UserAgent", Style = "readonly")]
		public string UserAgent
		{
			[CompilerGenerated]
			get
			{
				return this.<UserAgent>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<UserAgent>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<UserAgent>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_111);
			}
		}

		[DataMember(Order = 45)]
		[Layout(GroupName = "Account_Credentials", Description = "Proxy", RightDescription = "SOCKS5 connection string\n[user:pass@]host:port\nLeave empty to disable")]
		public string ProxyString
		{
			[CompilerGenerated]
			get
			{
				return this.<ProxyString>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<ProxyString>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<ProxyString>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_76);
			}
		}

		[DataMember(Order = 6)]
		public bool Use3D
		{
			[CompilerGenerated]
			get
			{
				return this.<Use3D>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Use3D>k__BackingField == value)
				{
					return;
				}
				this.<Use3D>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_106);
			}
		}

		[Layout(GroupName = "Account_Resources", Description = "Collect green pirate booty")]
		[DataMember(Order = 7)]
		public bool CollectGreenBooty
		{
			[CompilerGenerated]
			get
			{
				return this.<CollectGreenBooty>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CollectGreenBooty>k__BackingField == value)
				{
					return;
				}
				this.<CollectGreenBooty>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_13);
			}
		}

		[Layout(GroupName = "Account_Resources", Description = "Collect golden pirate booty")]
		[DataMember(Order = 8)]
		public bool CollectGoldBooty
		{
			[CompilerGenerated]
			get
			{
				return this.<CollectGoldBooty>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CollectGoldBooty>k__BackingField == value)
				{
					return;
				}
				this.<CollectGoldBooty>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_12);
			}
		}

		[DefaultValue(true)]
		[DataMember(Order = 14, EmitDefaultValue = true)]
		[Layout(GroupName = "Account_Resources", Description = "Automatically refine resources")]
		public bool AutoRefine
		{
			[CompilerGenerated]
			get
			{
				return this.<AutoRefine>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<AutoRefine>k__BackingField == value)
				{
					return;
				}
				this.<AutoRefine>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_2);
			}
		}

		[Layout(GroupName = "Account_Resources", Description = "Palladium collection area width", RightDescription = "By default 60%. Increasing this number might result in your ship respawning on the left-side portal on 5-3")]
		[DataMember(Order = 38, EmitDefaultValue = true)]
		[DefaultValue(60)]
		[Range(10, 100)]
		public int PalladiumCollectionAreaWidth
		{
			[CompilerGenerated]
			get
			{
				return this.<PalladiumCollectionAreaWidth>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PalladiumCollectionAreaWidth>k__BackingField == value)
				{
					return;
				}
				this.<PalladiumCollectionAreaWidth>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_70);
			}
		}

		[DataMember(Order = 41)]
		[Layout(GroupName = "Account_Skylab", Description = "Keep X Promerium on ship")]
		[Range(0, 3000)]
		public int Skylab_KeepPromerium
		{
			[CompilerGenerated]
			get
			{
				return this.<Skylab_KeepPromerium>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Skylab_KeepPromerium>k__BackingField == value)
				{
					return;
				}
				this.<Skylab_KeepPromerium>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_85);
			}
		}

		[Range(0, 3000)]
		[DataMember(Order = 42)]
		[Layout(GroupName = "Account_Skylab", Description = "Keep X Seprom on ship")]
		public int Skylab_KeepSeprom
		{
			[CompilerGenerated]
			get
			{
				return this.<Skylab_KeepSeprom>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Skylab_KeepSeprom>k__BackingField == value)
				{
					return;
				}
				this.<Skylab_KeepSeprom>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_86);
			}
		}

		[DataMember(Order = 17)]
		[Layout(GroupName = "Account", Description = "Jump into GG if 1 life left")]
		public bool JumpGGLastLife
		{
			[CompilerGenerated]
			get
			{
				return this.<JumpGGLastLife>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<JumpGGLastLife>k__BackingField == value)
				{
					return;
				}
				this.<JumpGGLastLife>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_52);
			}
		}

		[Layout(GroupName = "Account_GG Spinner", Description = "Enable GG builder")]
		[DataMember(Order = 18)]
		public bool Spinner_Enabled
		{
			[CompilerGenerated]
			get
			{
				return this.<Spinner_Enabled>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Spinner_Enabled>k__BackingField == value)
				{
					return;
				}
				this.<Spinner_Enabled>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_90);
			}
		}

		[Layout(GroupName = "Account_GG Spinner", Description = "Spin delay (ms)")]
		[DataMember(Order = 40)]
		[Range(0, 2000)]
		[DefaultValue(250)]
		public int Spinner_SpinDelay
		{
			[CompilerGenerated]
			get
			{
				return this.<Spinner_SpinDelay>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Spinner_SpinDelay>k__BackingField == value)
				{
					return;
				}
				this.<Spinner_SpinDelay>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.wpvHvJgIcWy);
			}
		}

		[DataMember(Order = 44)]
		[Layout(GroupName = "Account_GG Spinner", Description = "Spin size")]
		public SpinnerModeSelection Spinner_SpinSize
		{
			[CompilerGenerated]
			get
			{
				return this.<Spinner_SpinSize>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Spinner_SpinSize>k__BackingField == value)
				{
					return;
				}
				this.<Spinner_SpinSize>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_97);
			}
		}

		[Layout(GroupName = "Account_GG Spinner", Description = "Spin only using Phoenix (requires the bot to be Idle)", RightDescription = "Requires set 'Default hangar'")]
		[DataMember(Order = 39)]
		public bool Spinner_UsePhoenix
		{
			[CompilerGenerated]
			get
			{
				return this.<Spinner_UsePhoenix>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Spinner_UsePhoenix>k__BackingField == value)
				{
					return;
				}
				this.<Spinner_UsePhoenix>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_99);
			}
		}

		[Layout(GroupName = "Account_GG Spinner", Description = "Minimum Uridium", RightDescription = "Leave 0 to only use Free Energy")]
		[DataMember(Order = 19)]
		public int Spinner_UseUridium
		{
			[CompilerGenerated]
			get
			{
				return this.<Spinner_UseUridium>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Spinner_UseUridium>k__BackingField == value)
				{
					return;
				}
				this.<Spinner_UseUridium>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_100);
			}
		}

		[Layout(GroupName = "Account_GG Spinner", Description = "Place gates on X-1")]
		[DataMember(Order = 20)]
		public bool Spinner_PlaceGates
		{
			[CompilerGenerated]
			get
			{
				return this.<Spinner_PlaceGates>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Spinner_PlaceGates>k__BackingField == value)
				{
					return;
				}
				this.<Spinner_PlaceGates>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_96);
			}
		}

		[Layout(GroupName = "Account_GG Spinner", Description = "Build GG Alpha")]
		[DataMember(Order = 21)]
		public bool Spinner_Alpha
		{
			[CompilerGenerated]
			get
			{
				return this.<Spinner_Alpha>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Spinner_Alpha>k__BackingField == value)
				{
					return;
				}
				this.<Spinner_Alpha>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_87);
			}
		}

		[DataMember(Order = 29)]
		[Layout(GroupName = "Account_GG Spinner", Description = "Build GG Beta")]
		public bool Spinner_Beta
		{
			[CompilerGenerated]
			get
			{
				return this.<Spinner_Beta>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Spinner_Beta>k__BackingField == value)
				{
					return;
				}
				this.<Spinner_Beta>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_88);
			}
		}

		[DataMember(Order = 30)]
		[Layout(GroupName = "Account_GG Spinner", Description = "Build GG Gamma")]
		public bool Spinner_Gamma
		{
			[CompilerGenerated]
			get
			{
				return this.<Spinner_Gamma>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Spinner_Gamma>k__BackingField == value)
				{
					return;
				}
				this.<Spinner_Gamma>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_92);
			}
		}

		[DataMember(Order = 32)]
		[Layout(GroupName = "Account_GG Spinner", Description = "Stop when either of ABG is built")]
		public bool Spinner_StopABG
		{
			[CompilerGenerated]
			get
			{
				return this.<Spinner_StopABG>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Spinner_StopABG>k__BackingField == value)
				{
					return;
				}
				this.<Spinner_StopABG>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_98);
			}
		}

		[DataMember(Order = 22)]
		[Layout(GroupName = "Account_GG Spinner", Description = "Build GG Delta")]
		public bool Spinner_Delta
		{
			[CompilerGenerated]
			get
			{
				return this.<Spinner_Delta>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Spinner_Delta>k__BackingField == value)
				{
					return;
				}
				this.<Spinner_Delta>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_89);
			}
		}

		[Layout(GroupName = "Account_GG Spinner", Description = "Build GG Epsilon")]
		[DataMember(Order = 23)]
		public bool Spinner_Epsilon
		{
			[CompilerGenerated]
			get
			{
				return this.<Spinner_Epsilon>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Spinner_Epsilon>k__BackingField == value)
				{
					return;
				}
				this.<Spinner_Epsilon>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_91);
			}
		}

		[Layout(GroupName = "Account_GG Spinner", Description = "Build GG Zeta")]
		[DataMember(Order = 24)]
		public bool Spinner_Zeta
		{
			[CompilerGenerated]
			get
			{
				return this.<Spinner_Zeta>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Spinner_Zeta>k__BackingField == value)
				{
					return;
				}
				this.<Spinner_Zeta>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_101);
			}
		}

		[Layout(GroupName = "Account_GG Spinner", Description = "Build GG Kappa")]
		[DataMember(Order = 25)]
		public bool Spinner_Kappa
		{
			[CompilerGenerated]
			get
			{
				return this.<Spinner_Kappa>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Spinner_Kappa>k__BackingField == value)
				{
					return;
				}
				this.<Spinner_Kappa>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_93);
			}
		}

		[DataMember(Order = 26)]
		[Layout(GroupName = "Account_GG Spinner", Description = "Build GG Lambda")]
		public bool Spinner_Lambda
		{
			[CompilerGenerated]
			get
			{
				return this.<Spinner_Lambda>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Spinner_Lambda>k__BackingField == value)
				{
					return;
				}
				this.<Spinner_Lambda>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_95);
			}
		}

		[Layout(GroupName = "Account_GG Spinner", Description = "Build GG Kuiper")]
		[DataMember(Order = 43)]
		public bool Spinner_Kuiper
		{
			[CompilerGenerated]
			get
			{
				return this.<Spinner_Kuiper>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Spinner_Kuiper>k__BackingField == value)
				{
					return;
				}
				this.<Spinner_Kuiper>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_94);
			}
		}

		[DataMember(Order = 27)]
		public bool EnableTimeTable
		{
			[CompilerGenerated]
			get
			{
				return this.<EnableTimeTable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<EnableTimeTable>k__BackingField == value)
				{
					return;
				}
				this.<EnableTimeTable>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_27);
			}
		}

		[DataMember(Order = 28)]
		public List<TimeTableDayEntry> TimeTable
		{
			[CompilerGenerated]
			get
			{
				return this.<TimeTable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<TimeTable>k__BackingField, value))
				{
					return;
				}
				this.<TimeTable>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_103);
			}
		}

		[DataMember(Order = 31)]
		public bool TimeTableUseUtc
		{
			[CompilerGenerated]
			get
			{
				return this.<TimeTableUseUtc>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<TimeTableUseUtc>k__BackingField == value)
				{
					return;
				}
				this.<TimeTableUseUtc>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_105);
			}
		}

		[DataMember(Order = 9)]
		public string ProfileName
		{
			[CompilerGenerated]
			get
			{
				return this.<ProfileName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<ProfileName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<ProfileName>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_75);
			}
		}

		[DataMember(Order = 10)]
		public string UserId
		{
			[CompilerGenerated]
			get
			{
				return this.<UserId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<UserId>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<UserId>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_112);
			}
		}

		[Browsable(false)]
		public event PropertyChangedEventHandler PropertyChanged;

		[DataMember(Order = 11)]
		public string BotName
		{
			[CompilerGenerated]
			get
			{
				return this.<BotName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<BotName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<BotName>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.BotName);
			}
		}

		[DataMember(Order = 12)]
		public string BotId
		{
			[CompilerGenerated]
			get
			{
				return this.<BotId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<BotId>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<BotId>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_5);
			}
		}

		[DataMember(Order = 33)]
		public VolatileData Volatile
		{
			[CompilerGenerated]
			get
			{
				return this.<Volatile>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Volatile>k__BackingField, value))
				{
					return;
				}
				this.<Volatile>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_116);
			}
		}

		public override string ToString()
		{
			return this.BotName;
		}

		[OnSerializing]
		internal void HidePassword(StreamingContext c)
		{
			if (string.IsNullOrEmpty(this.Password))
			{
				this.Password = string.Empty;
			}
			this.Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(this.Password));
		}

		public void RestorePassword()
		{
			if (string.IsNullOrEmpty(this.Password))
			{
				this.Password = string.Empty;
				return;
			}
			this.Password = Encoding.UTF8.GetString(Convert.FromBase64String(this.Password));
		}

		[OnSerialized]
		internal void OnSerialized(StreamingContext c)
		{
			this.RestorePassword();
		}

		[OnDeserialized]
		internal void OnDeserialized(StreamingContext c)
		{
			this.RestorePassword();
		}

		public void FillVolatile()
		{
			if (this.Volatile == null)
			{
				this.Volatile = new VolatileData();
			}
			this.Volatile.Fill();
		}

		public ProxySettings GetProxySettings()
		{
			return ProxySettings.smethod_0(this.ProxyString);
		}

		public AccountSettings Fill()
		{
			this.BotName = this.Username.ToLowerInvariant() + "_" + this.Server.ToLowerInvariant();
			this.BotId = this.UserId + "_" + this.Server.ToLowerInvariant();
			if (this.TimeTable == null)
			{
				this.TimeTable = new List<TimeTableDayEntry>();
			}
			for (int i = 0; i < 7; i++)
			{
				if (this.TimeTable.Count <= i)
				{
					this.TimeTable.Add(new TimeTableDayEntry());
				}
				this.TimeTable[i].Fill();
				for (int j = 0; j < 24; j++)
				{
					string text = this.TimeTable[i].Schedule[j];
					if (string.IsNullOrWhiteSpace(text) || text.Length > 32)
					{
						this.TimeTable[i].Schedule[j] = null;
					}
				}
				this.TimeTable = this.TimeTable.Take(7).ToList<TimeTableDayEntry>();
			}
			this.FillVolatile();
			return this;
		}

		public AccountSettings()
		{
			this.<RepairDrones>k__BackingField = true;
			this.<UserAgent>k__BackingField = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36";
			this.<AutoRefine>k__BackingField = true;
			this.<PalladiumCollectionAreaWidth>k__BackingField = 60;
			this.<Spinner_SpinDelay>k__BackingField = 250;
			this.PropertyChanged = delegate(object sender, PropertyChangedEventArgs e)
			{
			};
			base..ctor();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
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
