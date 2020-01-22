using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using DarkorbitAPI;
using PErkava;

public class GClass861 : Window, INotifyPropertyChanged, IComponentConnector
{
	public bool IsSupported
	{
		get
		{
			return PErkava.IsSupported;
		}
	}

	[CompilerGenerated]
	public static DateTimeOffset smethod_0()
	{
		return GClass861.dateTimeOffset_0;
	}

	[CompilerGenerated]
	public static void smethod_1(DateTimeOffset dateTimeOffset_1)
	{
		GClass861.dateTimeOffset_0 = dateTimeOffset_1;
	}

	public bool IsLoading
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.method_3<bool>(ref this.bool_0, value, "IsLoading");
		}
	}

	public string LoadingStatus
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.method_3<string>(ref this.string_0, value, "LoadingStatus");
		}
	}

	private void method_0()
	{
		this.IsLoading = false;
	}

	[CompilerGenerated]
	public bool ygDqHuElcCj()
	{
		return this.bool_1;
	}

	[CompilerGenerated]
	public void method_1(bool bool_3)
	{
		this.bool_1 = bool_3;
	}

	protected override void OnClosing(CancelEventArgs e)
	{
		if (!this.ygDqHuElcCj())
		{
			e.Cancel = true;
			base.Hide();
		}
		base.OnClosing(e);
	}

	public void method_2()
	{
		base.Focus();
	}

	public GClass861()
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "Wait...";
		base..ctor();
		this.InitializeComponent();
		base.DataContext = this;
		PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
		if (propertyChanged != null)
		{
			propertyChanged(this, new PropertyChangedEventArgs("IsSupported"));
		}
		this.IsLoading = true;
		if (!this.IsSupported)
		{
			this.LoadingStatus = "PErkava is not supported\r\nPlease run DOPE with Administrator privileges.";
			return;
		}
		DateTimeOffset dateTimeOffset = GClass861.dateTimeOffset_0;
		if (dateTimeOffset.AddMinutes(5.0) < DateTimeOffset.Now)
		{
			Task.Factory.StartNew(new Action(this.Load));
			return;
		}
		this.method_0();
	}

	public void Load()
	{
		while (!Parallel.ForEach<GClass867>(PErkava.AllServersData, new ParallelOptions
		{
			MaxDegreeOfParallelism = 10
		}, new Action<GClass867>(this.method_4)).IsCompleted)
		{
			Thread.Sleep(1);
		}
		GClass861.smethod_1(DateTimeOffset.Now);
		this.LoadingStatus = "Done";
		base.Dispatcher.Invoke(new Action(this.method_0));
	}

	protected void method_3<y3mHVBrx3vlLI2xUKru>(ref y3mHVBrx3vlLI2xUKru gparam_0, y3mHVBrx3vlLI2xUKru BnUQRorWk5qlavJVkUM, [CallerMemberName] string name = null)
	{
		if (!EqualityComparer<y3mHVBrx3vlLI2xUKru>.Default.Equals(gparam_0, BnUQRorWk5qlavJVkUM))
		{
			gparam_0 = BnUQRorWk5qlavJVkUM;
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged == null)
			{
				return;
			}
			propertyChanged(this, new PropertyChangedEventArgs(name));
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (this.bool_2)
		{
			return;
		}
		this.bool_2 = true;
		Uri resourceLocator = new Uri("/DOPE;component/mainwindow.xaml", UriKind.Relative);
		Application.LoadComponent(this, resourceLocator);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		this.bool_2 = true;
	}

	[CompilerGenerated]
	private void method_4(GClass867 gclass867_0)
	{
		DarkOrbitWebAPI darkOrbitWebAPI = new DarkOrbitWebAPI(null);
		darkOrbitWebAPI.Server = gclass867_0.Name;
		this.LoadingStatus = "Finding game servers for " + gclass867_0.Name + "...";
		gclass867_0.method_3(darkOrbitWebAPI);
		PErkava.concurrentDictionary_3[gclass867_0.Name] = gclass867_0;
	}

	[CompilerGenerated]
	private static DateTimeOffset dateTimeOffset_0;

	private bool bool_0;

	private string string_0;

	[CompilerGenerated]
	private bool bool_1;

	private bool bool_2;
}
