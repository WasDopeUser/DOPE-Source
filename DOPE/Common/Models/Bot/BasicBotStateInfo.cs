using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace DOPE.Common.Models.Bot
{
	[DataContract]
	[Guid("7CDB6E89-CAFE-4CA7-B212-CD514925AEC9")]
	public class BasicBotStateInfo : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged = delegate(object sender, PropertyChangedEventArgs e)
		{
		};

		[DataMember(Order = 1)]
		public string BotStateName
		{
			[CompilerGenerated]
			get
			{
				return this.<BotStateName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<BotStateName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<BotStateName>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_6);
			}
		}

		[DataMember(Order = 2)]
		public string BotControlState
		{
			[CompilerGenerated]
			get
			{
				return this.<BotControlState>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<BotControlState>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<BotControlState>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_4);
			}
		}

		[DataMember(Order = 3)]
		public string SessionId
		{
			[CompilerGenerated]
			get
			{
				return this.<SessionId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<SessionId>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<SessionId>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_84);
			}
		}

		[DataMember(Order = 4)]
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

		[DataMember(Order = 5)]
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

		[DataMember(Order = 6)]
		public string MapName
		{
			[CompilerGenerated]
			get
			{
				return this.<MapName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<MapName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<MapName>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.MapName);
			}
		}

		[DataMember(Order = 7)]
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

		[DataMember(Order = 8)]
		public string NextProfileName
		{
			[CompilerGenerated]
			get
			{
				return this.<NextProfileName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<NextProfileName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<NextProfileName>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_66);
			}
		}

		[DataMember(Order = 9)]
		public bool HasNextProfile
		{
			[CompilerGenerated]
			get
			{
				return this.<HasNextProfile>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<HasNextProfile>k__BackingField == value)
				{
					return;
				}
				this.<HasNextProfile>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_48);
			}
		}

		[DataMember(Order = 10)]
		public bool HasLicense
		{
			[CompilerGenerated]
			get
			{
				return this.<HasLicense>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<HasLicense>k__BackingField == value)
				{
					return;
				}
				this.<HasLicense>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_47);
			}
		}

		[DataMember(Order = 11)]
		public string LastError
		{
			[CompilerGenerated]
			get
			{
				return this.<LastError>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<LastError>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<LastError>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_57);
			}
		}

		[DataMember(Order = 12)]
		public bool TimeTableActive
		{
			[CompilerGenerated]
			get
			{
				return this.<TimeTableActive>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<TimeTableActive>k__BackingField == value)
				{
					return;
				}
				this.<TimeTableActive>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_105);
			}
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
