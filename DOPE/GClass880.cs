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

public class GClass880 : Window, INotifyPropertyChanged, IComponentConnector
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
		return GClass880.dateTimeOffset_0;
	}

	[CompilerGenerated]
	public static void smethod_1(DateTimeOffset dateTimeOffset_1)
	{
		GClass880.dateTimeOffset_0 = dateTimeOffset_1;
	}

	public bool IsLoading
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.method_4<bool>(ref this.bool_0, value, "IsLoading");
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
			this.method_4<string>(ref this.string_0, value, "LoadingStatus");
		}
	}

	private void method_0()
	{
		this.IsLoading = false;
	}

	[CompilerGenerated]
	public bool method_1()
	{
		return this.bool_1;
	}

	[CompilerGenerated]
	public void method_2(bool bool_3)
	{
		this.bool_1 = bool_3;
	}

	protected override void OnClosing(CancelEventArgs e)
	{
		if (!this.method_1())
		{
			e.Cancel = true;
			base.Hide();
		}
		base.OnClosing(e);
	}

	public void method_3()
	{
		base.Focus();
	}

	public GClass880()
	{
		Class13.NP5bWyNzLwONS();
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
		DateTimeOffset dateTimeOffset = GClass880.dateTimeOffset_0;
		if (dateTimeOffset.AddMinutes(5.0) < DateTimeOffset.Now)
		{
			Task.Factory.StartNew(new Action(this.Load));
			return;
		}
		this.method_0();
	}

	public void Load()
	{
		while (!Parallel.ForEach<GClass886>(PErkava.AllServersData, new ParallelOptions
		{
			MaxDegreeOfParallelism = 10
		}, new Action<GClass886>(this.method_5)).IsCompleted)
		{
			Thread.Sleep(1);
		}
		GClass880.smethod_1(DateTimeOffset.Now);
		this.LoadingStatus = "Done";
		base.Dispatcher.Invoke(new Action(this.method_0));
	}

	protected void method_4<bu6HWrN2riP4MDsXRAU>(ref bu6HWrN2riP4MDsXRAU gparam_0, bu6HWrN2riP4MDsXRAU qdX2yyNJ1r5R36GFsTU, [CallerMemberName] string name = null)
	{
		if (!EqualityComparer<bu6HWrN2riP4MDsXRAU>.Default.Equals(gparam_0, qdX2yyNJ1r5R36GFsTU))
		{
			gparam_0 = qdX2yyNJ1r5R36GFsTU;
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged == null)
			{
				return;
			}
			propertyChanged(this, new PropertyChangedEventArgs(name));
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
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

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		this.bool_2 = true;
	}

	[CompilerGenerated]
	private void method_5(GClass886 gclass886_0)
	{
		DarkOrbitWebAPI darkOrbitWebAPI = new DarkOrbitWebAPI(null);
		darkOrbitWebAPI.Server = gclass886_0.Name;
		this.LoadingStatus = "Finding game servers for " + gclass886_0.Name + "...";
		gclass886_0.method_3(darkOrbitWebAPI);
		PErkava.concurrentDictionary_3[gclass886_0.Name] = gclass886_0;
	}

	[CompilerGenerated]
	private static DateTimeOffset dateTimeOffset_0;

	private bool bool_0;

	private string string_0;

	[CompilerGenerated]
	private bool bool_1;

	private bool bool_2;
}
