using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Windows.Markup;
using DarkorbitAPI;
using DarkorbitAPI.Structures;
using PErkava;

public class GClass855 : Window, INotifyPropertyChanged, IComponentConnector
{
	private void method_0()
	{
		this.method_1(GEnum13.None, Keys.Oemtilde);
		this.method_1((GEnum13)4U, Keys.Oemtilde);
		this.method_1(GEnum13.None, Keys.Scroll);
		this.method_1((GEnum13)4U, Keys.Scroll);
	}

	protected override void OnSourceInitialized(EventArgs e)
	{
		base.OnSourceInitialized(e);
		WindowInteropHelper windowInteropHelper = new WindowInteropHelper(this);
		this.hwndSource_0 = HwndSource.FromHwnd(windowInteropHelper.Handle);
		this.hwndSource_0.AddHook(new HwndSourceHook(this.method_3));
		this.method_0();
	}

	[DllImport("User32.dll")]
	private static extern bool RegisterHotKey([In] IntPtr intptr_0, [In] int int_1, [In] uint uint_0, [In] uint uint_1);

	[DllImport("User32.dll")]
	private static extern bool UnregisterHotKey([In] IntPtr intptr_0, [In] int int_1);

	protected override void OnClosed(EventArgs e)
	{
		HwndSource hwndSource = this.hwndSource_0;
		if (hwndSource != null)
		{
			hwndSource.RemoveHook(new HwndSourceHook(this.method_3));
		}
		this.hwndSource_0 = null;
		this.method_2();
		base.OnClosed(e);
	}

	private void method_1(GEnum13 genum13_0, Keys keys_0)
	{
		WindowInteropHelper windowInteropHelper = new WindowInteropHelper(this);
		int num = Interlocked.Increment(ref GClass855.int_0);
		if (GClass855.RegisterHotKey(windowInteropHelper.Handle, num, (uint)genum13_0, (uint)keys_0))
		{
			this.hashSet_0.Add(num);
		}
	}

	private void method_2()
	{
		WindowInteropHelper windowInteropHelper = new WindowInteropHelper(this);
		foreach (int int_ in this.hashSet_0)
		{
			GClass855.UnregisterHotKey(windowInteropHelper.Handle, int_);
		}
		this.hashSet_0.Clear();
	}

	private IntPtr method_3(IntPtr intptr_0, int int_1, IntPtr intptr_1, IntPtr intptr_2, ref bool bool_1)
	{
		if (int_1 == 786)
		{
			int item = intptr_1.ToInt32();
			if (this.hashSet_0.Contains(item))
			{
				Keys keys_ = (Keys)((int)intptr_2 >> 16 & 65535);
				GEnum13 genum13_ = (GEnum13)((int)intptr_2 & 65535);
				if (this.method_9(this, new GEventArgs0(genum13_, keys_)))
				{
					bool_1 = true;
				}
			}
		}
		return IntPtr.Zero;
	}

	public GClass863 Proxy
	{
		get
		{
			return this.gclass863_0;
		}
		set
		{
			this.method_6<GClass863>(ref this.gclass863_0, value, "Target", "Proxy");
		}
	}

	public Ship Target
	{
		get
		{
			GClass863 proxy = this.Proxy;
			if (proxy == null)
			{
				return null;
			}
			GameManager game = proxy.Game;
			if (game == null)
			{
				return null;
			}
			Map map = game.Map;
			if (map == null)
			{
				return null;
			}
			return map.SelectedShip;
		}
	}

	public GClass855()
	{
		Class13.Gj4N3WdzaR1LY();
		this.hashSet_0 = new HashSet<int>();
		base..ctor();
		this.InitializeComponent();
		base.DataContext = this;
		base.Closed += this.GClass855_Closed;
		this.gclass862_0 = new GClass862();
		this.timer_0 = new System.Windows.Forms.Timer();
		this.timer_0.Tick += this.timer_0_Tick;
		this.timer_0.Interval = 100;
		this.timer_0.Start();
	}

	public void method_4()
	{
		this.gclass862_0.method_3();
		this.gclass862_0.ShowDialog();
		base.Topmost = true;
		base.Focus();
	}

	public bool method_5()
	{
		this.method_4();
		if (!this.gclass862_0.IsSupported)
		{
			base.Close();
			return false;
		}
		base.Visibility = Visibility.Visible;
		base.Topmost = true;
		base.Focus();
		return true;
	}

	private void GClass855_Closed(object sender, EventArgs e)
	{
		System.Windows.Forms.Timer timer = this.timer_0;
		if (timer != null)
		{
			timer.Stop();
		}
		System.Windows.Forms.Timer timer2 = this.timer_0;
		if (timer2 != null)
		{
			timer2.Dispose();
		}
		if (this.gclass862_0 != null)
		{
			this.gclass862_0.method_2(true);
		}
		GClass862 gclass = this.gclass862_0;
		if (gclass == null)
		{
			return;
		}
		gclass.Close();
	}

	protected void method_6<U2wWBGE0kduDp36NBDj>(ref U2wWBGE0kduDp36NBDj gparam_0, U2wWBGE0kduDp36NBDj dGfE2vEDCvfbPOpkI59, string string_0 = null, [CallerMemberName] string name = null)
	{
		if (!EqualityComparer<U2wWBGE0kduDp36NBDj>.Default.Equals(gparam_0, dGfE2vEDCvfbPOpkI59))
		{
			gparam_0 = dGfE2vEDCvfbPOpkI59;
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(name));
			}
			if (string_0 != null)
			{
				PropertyChangedEventHandler propertyChanged2 = this.PropertyChanged;
				if (propertyChanged2 == null)
				{
					return;
				}
				propertyChanged2(this, new PropertyChangedEventArgs(string_0));
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	private void method_7(object sender, RoutedEventArgs e)
	{
		GClass863 proxy = this.Proxy;
		if (proxy == null)
		{
			return;
		}
		GClass84<GClass788<GInterface7>> gclass = proxy.method_0();
		if (gclass == null)
		{
			return;
		}
		GClass91 socket = gclass.Socket;
		if (socket == null)
		{
			return;
		}
		socket.method_8();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		IntPtr foregroundWindow = GClass858.GetForegroundWindow();
		GClass863 proxy = null;
		PErkava.concurrentDictionary_0.TryGetValue(foregroundWindow, out proxy);
		this.Proxy = proxy;
	}

	public void method_8(bool bool_1)
	{
		GClass855.<>c__DisplayClass30_0 CS$<>8__locals1 = new GClass855.<>c__DisplayClass30_0();
		CS$<>8__locals1.hero_0 = this.Proxy.Game.Hero;
		Ship ship;
		if (bool_1)
		{
			ship = this.Proxy.Game.Map.method_5<Ship>(CS$<>8__locals1.hero_0.Position, new Func<Ship, bool>(CS$<>8__locals1.method_0), null, 0);
		}
		else
		{
			ship = this.Proxy.Game.Map.method_5<Ship>(CS$<>8__locals1.hero_0.Position, new Func<Ship, bool>(CS$<>8__locals1.method_1), null, 0);
		}
		if (ship != null)
		{
			this.Proxy.Game.Connection.Server.method_7(ship, false);
		}
	}

	public bool method_9(object object_0, GEventArgs0 geventArgs0_0)
	{
		if (this.Proxy == null)
		{
			return false;
		}
		if (geventArgs0_0.Key != Keys.Oemtilde)
		{
			if (geventArgs0_0.Key != Keys.Scroll)
			{
				return false;
			}
		}
		this.method_8(geventArgs0_0.method_0().HasFlag((GEnum13)4U));
		return true;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (this.bool_0)
		{
			return;
		}
		this.bool_0 = true;
		Uri resourceLocator = new Uri("/DOPE;component/overlaywindow.xaml", UriKind.Relative);
		System.Windows.Application.LoadComponent(this, resourceLocator);
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			this.Guide = (System.Windows.Controls.Label)target;
			return;
		case 2:
			this.Progress = (System.Windows.Controls.Label)target;
			return;
		case 3:
			((System.Windows.Controls.Button)target).Click += this.method_7;
			return;
		default:
			this.bool_0 = true;
			return;
		}
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass855()
	{
		Class13.Gj4N3WdzaR1LY();
		GClass855.int_0 = 913376;
	}

	private HwndSource hwndSource_0;

	private static int int_0;

	private HashSet<int> hashSet_0;

	private GClass863 gclass863_0;

	private System.Windows.Forms.Timer timer_0;

	private GClass862 gclass862_0;

	internal System.Windows.Controls.Label Guide;

	internal System.Windows.Controls.Label Progress;

	private bool bool_0;
}
