using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using DarkorbitAPI;
using DOPE.Common;
using DOPE.Common.Models.Bot.Stats;
using DOPE.Core;
using DOPE.UI.Commands;
using PErkava;

namespace DOPE.UI
{
	public partial class MainWindow : Window, INotifyPropertyChanged, IStyleConnector, IBotClient
	{
		public bool Debug
		{
			get
			{
				return false;
			}
		}

		public Controller Controller
		{
			[CompilerGenerated]
			get
			{
				return this.<Controller>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Controller>k__BackingField, value))
				{
					return;
				}
				this.<Controller>k__BackingField = value;
				this.method_31(<>PropertyChangedEventArgs.Controller);
			}
		}

		public string KeyPath
		{
			get
			{
				return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DOPE", "KEY");
			}
		}

		public string method_0()
		{
			if (File.Exists(this.KeyPath))
			{
				return File.ReadAllText(this.KeyPath);
			}
			return null;
		}

		public void method_1()
		{
			DirectoryInfo directory = new FileInfo(this.KeyPath).Directory;
			if (!directory.Exists)
			{
				directory.Create();
			}
			File.WriteAllText(this.KeyPath, this.Controller.Key);
		}

		public MainWindow()
		{
			Class13.lOBHd9Nzn7x2T();
			this._lock = new object();
			this.<BotControllers>k__BackingField = new GClass4<GClass922>();
			base..ctor();
			Application.Current.MainWindow = this;
			MainWindow.Instance = this;
			this.CellTextBlock_SizeChangedHandler = new SizeChangedEventHandler(this.method_27);
			this.Controller = new Controller("dope", Constants.VersionString);
			this.Controller.Control.method_4(this.BotControllers);
			this.BotControllers.method_0(new GDelegate0(this.method_8));
			base.DataContext = this;
			this.InitializeComponent();
			this.Controller.Key = this.method_0();
			this.Controller.method_7(this.Controller.Key);
			this.MapRendererThread = new Thread(new ThreadStart(this.method_9));
			this.MapRendererThread.IsBackground = true;
			this.MapRendererThread.Start();
			base.Closed += this.MainWindow_Closed;
			this._tray = new TrayHelper(this);
			base.Title = "DOPE " + Constants.VersionString + " by PowerOfDark";
			this.method_2();
		}

		public RelayCommand GroupInviteCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<GroupInviteCommand>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<GroupInviteCommand>k__BackingField, value))
				{
					return;
				}
				this.<GroupInviteCommand>k__BackingField = value;
				this.method_31(<>PropertyChangedEventArgs.GroupInviteCommand);
			}
		}

		public RelayCommand GroupKickCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<GroupKickCommand>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<GroupKickCommand>k__BackingField, value))
				{
					return;
				}
				this.<GroupKickCommand>k__BackingField = value;
				this.method_31(<>PropertyChangedEventArgs.GroupKickCommand);
			}
		}

		public RelayCommand GroupAcceptInviteCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<GroupAcceptInviteCommand>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<GroupAcceptInviteCommand>k__BackingField, value))
				{
					return;
				}
				this.<GroupAcceptInviteCommand>k__BackingField = value;
				this.method_31(<>PropertyChangedEventArgs.GroupAcceptInviteCommand);
			}
		}

		public RelayCommand GroupDeclineInviteCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<GroupDeclineInviteCommand>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<GroupDeclineInviteCommand>k__BackingField, value))
				{
					return;
				}
				this.<GroupDeclineInviteCommand>k__BackingField = value;
				this.method_31(<>PropertyChangedEventArgs.GroupDeclineInviteCommand);
			}
		}

		private void method_2()
		{
			this.GroupInviteCommand = new RelayCommand(new Action<object>(this.method_4), null);
			this.GroupKickCommand = new RelayCommand(new Action<object>(this.method_5), null);
			this.GroupAcceptInviteCommand = new RelayCommand(new Action<object>(this.method_6), null);
			this.GroupDeclineInviteCommand = new RelayCommand(new Action<object>(this.method_7), null);
		}

		private void method_3(Action<GClass922> action_0, bool bool_0 = false)
		{
			GClass922 selected = this.Selected;
			if (selected != null && (!bool_0 || selected.Context.Hero.IsInitialized))
			{
				action_0(selected);
			}
		}

		private void method_4(object object_0)
		{
			MainWindow.<>c__DisplayClass38_0 CS$<>8__locals1 = new MainWindow.<>c__DisplayClass38_0();
			ComboBox comboBox = (ComboBox)object_0;
			CS$<>8__locals1.name = comboBox.Text;
			if (string.IsNullOrWhiteSpace(CS$<>8__locals1.name))
			{
				return;
			}
			comboBox.Text = "";
			this.method_3(new Action<GClass922>(CS$<>8__locals1.method_0), true);
		}

		private void method_5(object object_0)
		{
			MainWindow.<>c__DisplayClass39_0 CS$<>8__locals1 = new MainWindow.<>c__DisplayClass39_0();
			CS$<>8__locals1.id = (int)object_0;
			this.method_3(new Action<GClass922>(CS$<>8__locals1.method_0), false);
		}

		private void method_6(object object_0)
		{
			MainWindow.<>c__DisplayClass40_0 CS$<>8__locals1 = new MainWindow.<>c__DisplayClass40_0();
			CS$<>8__locals1.id = (int)object_0;
			this.method_3(new Action<GClass922>(CS$<>8__locals1.method_0), false);
		}

		private void method_7(object object_0)
		{
			MainWindow.<>c__DisplayClass41_0 CS$<>8__locals1 = new MainWindow.<>c__DisplayClass41_0();
			CS$<>8__locals1.id = (int)object_0;
			this.method_3(new Action<GClass922>(CS$<>8__locals1.method_0), false);
		}

		private void MainWindow_Closed(object sender, EventArgs e)
		{
			this._closing = true;
			Controller controller = this.Controller;
			if (controller != null)
			{
				controller.Stop();
			}
			Application.Current.Shutdown();
		}

		private void method_8(object sender, NotifyCollectionChangedEventArgs e)
		{
			if (e.NewItems == null)
			{
				return;
			}
			foreach (object obj in e.NewItems)
			{
				GClass922 gclass = (GClass922)obj;
				PErkava.smethod_0()[int.Parse(gclass.Context.Account.UserId)] = gclass.Context;
			}
		}

		public static MainWindow Instance { get; set; }

		public GClass4<GClass922> BotControllers
		{
			[CompilerGenerated]
			get
			{
				return this.<BotControllers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<BotControllers>k__BackingField, value))
				{
					return;
				}
				this.<BotControllers>k__BackingField = value;
				this.method_31(<>PropertyChangedEventArgs.Selected);
				this.method_31(<>PropertyChangedEventArgs.BotControllers);
			}
		}

		public GClass922 Selected
		{
			get
			{
				if (this.MainTabs != null)
				{
					if (this.BotControllers.Count > this.MainTabs.SelectedIndex)
					{
						if (this.MainTabs.SelectedIndex != -1)
						{
							return this.BotControllers[this.MainTabs.SelectedIndex];
						}
					}
					return null;
				}
				return null;
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void method_9()
		{
			while (!this._closing)
			{
				Thread.Sleep(50);
				this.LastRender = DateTimeOffset.Now.AddDays(1.0);
				try
				{
					base.Dispatcher.Invoke(new Action(this.method_10));
				}
				catch
				{
				}
			}
		}

		private void method_10()
		{
			try
			{
				MainWindow.<>c__DisplayClass60_0 CS$<>8__locals1 = new MainWindow.<>c__DisplayClass60_0();
				CS$<>8__locals1.selected = this.Selected;
				if (CS$<>8__locals1.selected != null)
				{
					if (this._lastSelected == CS$<>8__locals1.selected && this._lastMapControl != null)
					{
						int renders = this.Renders;
						this.Renders = renders + 1;
						if (renders % 100 != 0)
						{
							goto IL_67;
						}
					}
					this._lastMapControl = GClass6.smethod_0<MapControl>(this.MainTabs, new Func<MapControl, bool>(CS$<>8__locals1.method_0));
					IL_67:
					this._lastSelected = CS$<>8__locals1.selected;
					MapControl lastMapControl = this._lastMapControl;
					if (lastMapControl != null)
					{
						lastMapControl.InvalidateVisual();
					}
					GClass922 lastSelected = this._lastSelected;
					if (lastSelected != null)
					{
						GClass890 context = lastSelected.Context;
						if (context != null)
						{
							GClass882 stats = context.Stats;
							if (stats != null)
							{
								stats.method_3();
							}
						}
					}
					GameManager game = CS$<>8__locals1.selected.Context.Game;
				}
			}
			catch
			{
			}
			this.LastRender = DateTimeOffset.Now;
		}

		private void method_11(object sender, RoutedEventArgs e)
		{
			foreach (GClass922 gclass in this.BotControllers)
			{
				gclass.Start();
			}
		}

		private void method_12(object sender, RoutedEventArgs e)
		{
			this.Selected.Start();
		}

		private void method_13(object sender, RoutedEventArgs e)
		{
			foreach (GClass922 gclass in this.BotControllers)
			{
				gclass.Pause();
			}
		}

		private void method_14(object sender, RoutedEventArgs e)
		{
			this.Selected.Pause();
		}

		private void method_15(object sender, RoutedEventArgs e)
		{
			foreach (GClass922 gclass in this.BotControllers)
			{
				gclass.Stop();
			}
		}

		private void method_16(object sender, RoutedEventArgs e)
		{
			this.Selected.Stop();
		}

		private void method_17(object sender, RoutedEventArgs e)
		{
			this.Selected.ForceStop();
		}

		private void method_18(object sender, RoutedEventArgs e)
		{
			if (this.Selected != null && this.Selected.Context.Game.Web.IsLoggedIn)
			{
				new BrowserWindow(this.Selected.Context.Game.Web)
				{
					Owner = this
				}.Show();
			}
		}

		private void method_19(object sender, RoutedEventArgs e)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged == null)
			{
				return;
			}
			propertyChanged(sender, new PropertyChangedEventArgs("Selected"));
		}

		private void method_20(object sender, RoutedEventArgs e)
		{
			new SettingsWindow(this.Controller).ShowDialog();
			this.method_1();
		}

		private void Main_Closing(object sender, CancelEventArgs e)
		{
		}

		private void Main_Loaded(object sender, RoutedEventArgs e)
		{
			base.Focus();
			base.Activate();
		}

		private void method_21(object sender, RoutedEventArgs e)
		{
			if (!this.Debug)
			{
				return;
			}
			DebugWindow debugWindow = new DebugWindow();
			debugWindow.method_1<GClass854>(this._lastSelected.Context.Game.Connection.Socket.method_5());
			debugWindow.Show();
		}

		private void method_22(object sender, RoutedEventArgs e)
		{
			if (this.PerkavaWindow != null && this.PerkavaWindow.IsLoaded)
			{
				this.PerkavaWindow.Focus();
				return;
			}
			this.PerkavaWindow = new GClass924();
			if (this.PerkavaWindow.method_5())
			{
				this.PerkavaWindow.Show();
			}
		}

		private void method_23(object sender, RoutedEventArgs e)
		{
			Process.Start("https://powerofdark.space");
		}

		private void method_24(object sender, MouseButtonEventArgs e)
		{
			GClass922 selected = this.Selected;
			if (selected != null && selected.Context.Game.Connection.Socket.method_2())
			{
				int config = selected.Context.Hero.Config;
				selected.Context.Server.method_4((config == 1) ? 2 : 1);
				return;
			}
		}

		private void method_25(object sender, EventArgs e)
		{
			object dataContext = (sender as TabControl).DataContext;
		}

		private void method_26(object sender, EventArgs e)
		{
			ListView listView = (ListView)sender;
			StatisticsCategory statisticsCategory_ = listView.DataContext as StatisticsCategory;
			this.method_28(listView, statisticsCategory_);
		}

		private void method_27(object sender, SizeChangedEventArgs e)
		{
			TextBlock textBlock = (TextBlock)sender;
			GridViewColumn gridViewColumn = (GridViewColumn)textBlock.Tag;
			gridViewColumn.SetValue(GridViewColumn.WidthProperty, textBlock.ActualWidth);
			gridViewColumn.SetValue(GridViewColumn.WidthProperty, double.NaN);
		}

		private void method_28(ListView listView_0, StatisticsCategory statisticsCategory_0)
		{
			if (statisticsCategory_0 != null)
			{
				statisticsCategory_0.Rebuild();
				CollectionView collectionView = (CollectionView)CollectionViewSource.GetDefaultView(listView_0.ItemsSource);
				ObservableCollection<GroupDescription> groupDescriptions = collectionView.GroupDescriptions;
				if (groupDescriptions.Count == 0)
				{
					groupDescriptions.Add(new PropertyGroupDescription("Group"));
				}
				SortDescriptionCollection sortDescriptions = collectionView.SortDescriptions;
				if (sortDescriptions.Count == 0)
				{
					sortDescriptions.Add(new SortDescription("Order", ListSortDirection.Ascending));
				}
				GridView gridView = listView_0.View as GridView;
				gridView.Columns.Clear();
				int num = 0;
				foreach (string header in statisticsCategory_0.ColumnNames)
				{
					FrameworkElementFactory frameworkElementFactory = new FrameworkElementFactory(typeof(TextBlock));
					GridViewColumn gridViewColumn = new GridViewColumn
					{
						Header = header,
						CellTemplate = new DataTemplate
						{
							VisualTree = frameworkElementFactory
						}
					};
					frameworkElementFactory.SetBinding(TextBlock.TextProperty, new Binding(string.Format("Cells[{0}].Value", num)));
					frameworkElementFactory.SetValue(TextBlock.TextWrappingProperty, TextWrapping.NoWrap);
					frameworkElementFactory.SetValue(TextBlock.TextTrimmingProperty, TextTrimming.None);
					frameworkElementFactory.SetValue(TextBlock.TextAlignmentProperty, TextAlignment.Right);
					frameworkElementFactory.AddHandler(FrameworkElement.SizeChangedEvent, this.CellTextBlock_SizeChangedHandler);
					frameworkElementFactory.SetValue(FrameworkElement.TagProperty, gridViewColumn);
					gridView.Columns.Add(gridViewColumn);
					num++;
				}
				collectionView.Refresh();
			}
		}

		private void method_29(object sender, DependencyPropertyChangedEventArgs e)
		{
			ListView listView_ = (ListView)sender;
			StatisticsCategory statisticsCategory_ = e.NewValue as StatisticsCategory;
			this.method_28(listView_, statisticsCategory_);
		}

		private void method_30(object sender, EventArgs e)
		{
			ComboBox comboBox = sender as ComboBox;
			comboBox.Items.Clear();
			foreach (GClass922 gclass in this.BotControllers)
			{
				string userName = gclass.Context.Game.Web.UserName;
				if (!string.IsNullOrEmpty(userName))
				{
					comboBox.Items.Add(userName);
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 2:
				((ListView)target).DataContextChanged += this.method_29;
				((ListView)target).Initialized += this.method_26;
				return;
			case 3:
			case 4:
			case 5:
				break;
			case 6:
				((TextBlock)target).MouseLeftButtonUp += this.method_24;
				return;
			case 7:
				((TabControl)target).Initialized += this.method_25;
				return;
			case 8:
				((Button)target).Click += this.method_12;
				return;
			case 9:
				((Button)target).Click += this.method_14;
				return;
			case 10:
				((Button)target).Click += this.method_16;
				return;
			case 11:
				((Button)target).Click += this.method_17;
				return;
			case 12:
				((Button)target).Click += this.method_18;
				return;
			case 13:
				((Button)target).Click += this.method_21;
				return;
			case 14:
				((ComboBox)target).DropDownOpened += this.method_30;
				break;
			default:
				return;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
		protected void method_31(PropertyChangedEventArgs propertyChangedEventArgs_0)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, propertyChangedEventArgs_0);
			}
		}

		private MapControl _lastMapControl;

		private GClass922 _lastSelected;

		private readonly object _lock;

		public Thread AccountManagerThread;

		public Thread MapRendererThread;

		public GClass924 PerkavaWindow;

		private volatile bool _closing;

		private TrayHelper _tray;

		public DateTimeOffset LastRender;

		public int Renders;

		private SizeChangedEventHandler CellTextBlock_SizeChangedHandler;
	}
}
