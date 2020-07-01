using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using DOPE.UI.Controls;
using DOPE.UI.Models;

namespace DOPE.UI
{
	public partial class DebugWindow : Window, INotifyPropertyChanged, IStyleConnector
	{
		public ObservableCollection<TreeNode> Filtered
		{
			[CompilerGenerated]
			get
			{
				return this.<Filtered>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Filtered>k__BackingField, value))
				{
					return;
				}
				this.<Filtered>k__BackingField = value;
				this.method_13(<>PropertyChangedEventArgs.Filtered);
			}
		}

		public List<TreeHeaderNode> All
		{
			[CompilerGenerated]
			get
			{
				return this.<All>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<All>k__BackingField, value))
				{
					return;
				}
				this.<All>k__BackingField = value;
				this.method_13(<>PropertyChangedEventArgs.All);
			}
		}

		public bool? FilterReceived
		{
			[CompilerGenerated]
			get
			{
				return this.<FilterReceived>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<bool>(this.<FilterReceived>k__BackingField, value))
				{
					return;
				}
				this.<FilterReceived>k__BackingField = value;
				this.method_13(<>PropertyChangedEventArgs.FilterReceived);
			}
		}

		public List<CommandViewModel> Commands
		{
			[CompilerGenerated]
			get
			{
				return this.<Commands>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Commands>k__BackingField, value))
				{
					return;
				}
				this.<Commands>k__BackingField = value;
				this.method_13(<>PropertyChangedEventArgs.Commands);
			}
		}

		public Dictionary<int, CommandViewModel> CommandById
		{
			[CompilerGenerated]
			get
			{
				return this.<CommandById>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<CommandById>k__BackingField, value))
				{
					return;
				}
				this.<CommandById>k__BackingField = value;
				this.method_13(<>PropertyChangedEventArgs.CommandById);
			}
		}

		public bool JumpToLast
		{
			[CompilerGenerated]
			get
			{
				return this.<JumpToLast>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<JumpToLast>k__BackingField == value)
				{
					return;
				}
				this.<JumpToLast>k__BackingField = value;
				this.method_13(<>PropertyChangedEventArgs.JumpToLast);
			}
		}

		public string SearchText
		{
			[CompilerGenerated]
			get
			{
				return this.<SearchText>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<SearchText>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<SearchText>k__BackingField = value;
				this.method_13(<>PropertyChangedEventArgs.SearchText);
			}
		}

		public DebugWindow()
		{
			Class13.F93tSdiz1aNIA();
			this.<Filtered>k__BackingField = new ObservableCollection<TreeNode>();
			this.<All>k__BackingField = new List<TreeHeaderNode>();
			this.<JumpToLast>k__BackingField = true;
			this._lock = new object();
			this.PropertyChanged = new PropertyChangedEventHandler(DebugWindow.<>c.<>9.method_3);
			this._attached = new List<GInterface5>();
			base..ctor();
			this.InitializeComponent();
			base.DataContext = this;
			base.Closing += this.DebugWindow_Closing;
			this.Commands = GClass86.yOxTxpksbc.Select(new Func<KeyValuePair<int, Type>, CommandViewModel>(DebugWindow.<>c.<>9.method_0)).ToList<CommandViewModel>();
			foreach (CommandViewModel commandViewModel in this.Commands)
			{
				commandViewModel.PropertyChanged += this.method_0;
			}
			this.CommandById = this.Commands.ToDictionary(new Func<CommandViewModel, int>(DebugWindow.<>c.<>9.method_1), new Func<CommandViewModel, CommandViewModel>(DebugWindow.<>c.<>9.method_2));
			BindingOperations.EnableCollectionSynchronization(this.Filtered, this._lock);
			this.PropertyChanged += this.DebugWindow_PropertyChanged;
		}

		private void DebugWindow_Closing(object sender, CancelEventArgs e)
		{
			foreach (GInterface5 ginterface in this._attached)
			{
				ginterface.MessageReceived -= this.method_5;
				ginterface.MessageSent -= this.method_6;
			}
			this._attached.Clear();
		}

		private void method_0(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Enabled")
			{
				this.method_2();
			}
		}

		private void DebugWindow_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "SearchText")
			{
				foreach (object obj in ((IEnumerable)this.DataGrid.Items))
				{
					CommandViewModel commandViewModel = obj as CommandViewModel;
					if (commandViewModel != null && commandViewModel.Name.Contains(this.SearchText))
					{
						this.DataGrid.SelectedValue = obj;
						this.DataGrid.ScrollIntoView(obj);
						break;
					}
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void method_1<m2eLf0pOKNSypsINdH>(GClass84<m2eLf0pOKNSypsINdH> gclass84_0) where m2eLf0pOKNSypsINdH : GInterface7
		{
			gclass84_0.MessageSent += this.method_6;
			gclass84_0.MessageReceived += this.method_5;
			this._attached.Add(gclass84_0);
		}

		public void method_2()
		{
			object @lock = this._lock;
			lock (@lock)
			{
				BindingOperations.DisableCollectionSynchronization(this.Filtered);
				this.Filtered = new ObservableCollection<TreeNode>(this.Filtered.Where(new Func<TreeNode, bool>(this.method_11)));
				BindingOperations.EnableCollectionSynchronization(this.Filtered, this._lock);
			}
		}

		public bool method_3(TreeHeaderNode treeHeaderNode_0)
		{
			return (this.FilterReceived == null || this.FilterReceived.Value == treeHeaderNode_0.Received) && treeHeaderNode_0.Enabled;
		}

		public void method_4(GInterface0 ginterface0_0, bool bool_0)
		{
			DateTime now = DateTime.Now;
			TreeHeaderNode treeHeaderNode = TreeNode.smethod_0(ginterface0_0, this.CommandById[(int)ginterface0_0.Id], now, bool_0);
			if (bool_0)
			{
				CommandViewModel commandViewModel = this.CommandById[(int)ginterface0_0.Id];
				int num = commandViewModel.CountReceived;
				commandViewModel.CountReceived = num + 1;
			}
			else
			{
				CommandViewModel commandViewModel2 = this.CommandById[(int)ginterface0_0.Id];
				int num = commandViewModel2.CountSent;
				commandViewModel2.CountSent = num + 1;
			}
			if (this.method_3(treeHeaderNode))
			{
				object @lock = this._lock;
				lock (@lock)
				{
					this.Filtered.Add(treeHeaderNode);
				}
				if (this.JumpToLast)
				{
					base.Dispatcher.BeginInvoke(new Action(this.method_12), Array.Empty<object>());
				}
			}
		}

		private void method_5(GInterface0 ginterface0_0)
		{
			this.method_4(ginterface0_0, true);
		}

		private void method_6(GInterface0 ginterface0_0)
		{
			this.method_4(ginterface0_0, false);
		}

		private void method_7(object sender, RoutedEventArgs e)
		{
			this.method_2();
		}

		private void method_8(object sender, RoutedEventArgs e)
		{
			this.Filtered.Clear();
			foreach (CommandViewModel commandViewModel in this.Commands)
			{
				commandViewModel.CountReceived = 0;
				commandViewModel.CountSent = 0;
			}
		}

		private void method_9(object sender, RoutedEventArgs e)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_10(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 6)
			{
				((CheckBox)target).Click += this.method_9;
			}
		}

		[CompilerGenerated]
		private bool method_11(TreeNode treeNode_0)
		{
			return this.method_3(treeNode_0 as TreeHeaderNode);
		}

		[CompilerGenerated]
		private void method_12()
		{
			this.CmdList.ScrollToEnd();
		}

		[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
		[DebuggerNonUserCode]
		protected void method_13(PropertyChangedEventArgs propertyChangedEventArgs_0)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, propertyChangedEventArgs_0);
			}
		}

		private readonly object _lock;

		private List<GInterface5> _attached;
	}
}
