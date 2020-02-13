using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using DarkorbitAPI;
using PErkava;

public class GClass869 : INotifyPropertyChanged
{
	protected void method_0<MQdqaTL5swwGDyqCVK5>(ref MQdqaTL5swwGDyqCVK5 gparam_0, MQdqaTL5swwGDyqCVK5 irqIWjLUo5YUljjBycV, [CallerMemberName] string name = null)
	{
		if (!EqualityComparer<MQdqaTL5swwGDyqCVK5>.Default.Equals(gparam_0, irqIWjLUo5YUljjBycV))
		{
			gparam_0 = irqIWjLUo5YUljjBycV;
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(name));
			}
			if (name == "Enabled")
			{
				if ((bool)((object)irqIWjLUo5YUljjBycV))
				{
					PErkava.smethod_5(this);
					return;
				}
				PErkava.smethod_6(this);
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	public bool Enabled
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.method_0<bool>(ref this.bool_0, value, "Enabled");
		}
	}

	public string Name
	{
		get
		{
			return this.zkYotWmaWsL;
		}
		set
		{
			this.method_0<string>(ref this.zkYotWmaWsL, value, "Name");
		}
	}

	public int ServerCount
	{
		get
		{
			HashSet<string> servers = this.Servers;
			if (servers == null)
			{
				return 0;
			}
			return servers.Count;
		}
	}

	public HashSet<string> Servers { get; set; }

	[CompilerGenerated]
	public Dictionary<int, string> method_1()
	{
		return this.dictionary_0;
	}

	[CompilerGenerated]
	public void method_2(Dictionary<int, string> dictionary_1)
	{
		this.dictionary_0 = dictionary_1;
	}

	public void method_3(DarkOrbitWebAPI darkOrbitWebAPI_0)
	{
		Dictionary<int, string> mapHosts;
		this.method_2(mapHosts = darkOrbitWebAPI_0.GetMapHosts());
		this.Servers = new HashSet<string>(mapHosts.Select(new Func<KeyValuePair<int, string>, string>(GClass869.<>c.<>c_0.method_0)));
		PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
		if (propertyChanged == null)
		{
			return;
		}
		propertyChanged(this, new PropertyChangedEventArgs("ServerCount"));
	}

	public GClass869()
	{
		Class13.igxcIukzfpare();
		this.Servers = new HashSet<string>();
		this.dictionary_0 = new Dictionary<int, string>();
		base..ctor();
	}

	private bool bool_0;

	private string zkYotWmaWsL;

	[CompilerGenerated]
	private HashSet<string> hashSet_0;

	[CompilerGenerated]
	private Dictionary<int, string> dictionary_0;
}
