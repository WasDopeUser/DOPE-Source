using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace DOPE.UI.Controls
{
	public partial class TreeViewObject : UserControl
	{
		public TreeViewObject()
		{
			Class8.xDph7tozmh5WD();
			base..ctor();
			this.InitializeComponent();
		}

		public object ObjectToVisualize
		{
			get
			{
				return base.GetValue(TreeViewObject.ObjectToVisualizeProperty);
			}
			set
			{
				base.SetValue(TreeViewObject.ObjectToVisualizeProperty, value);
			}
		}

		private static void smethod_0(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
			(dependencyObject_0 as TreeViewObject).TreeNodes = new List<TreeNode>
			{
				(TreeNode)dependencyPropertyChangedEventArgs_0.NewValue
			};
		}

		public List<TreeNode> TreeNodes
		{
			get
			{
				return (List<TreeNode>)base.GetValue(TreeViewObject.TreeNodesProperty);
			}
			set
			{
				base.SetValue(TreeViewObject.TreeNodesProperty, value);
			}
		}

		// Note: this type is marked as 'beforefieldinit'.
		static TreeViewObject()
		{
			Class8.xDph7tozmh5WD();
			TreeViewObject.ObjectToVisualizeProperty = DependencyProperty.Register("ObjectToVisualize", typeof(object), typeof(TreeViewObject), new PropertyMetadata(null, new PropertyChangedCallback(TreeViewObject.smethod_0)));
			TreeViewObject.TreeNodesProperty = DependencyProperty.Register("TreeNodes", typeof(List<TreeNode>), typeof(TreeViewObject), new PropertyMetadata(null));
		}

		public static readonly DependencyProperty ObjectToVisualizeProperty;

		public static readonly DependencyProperty TreeNodesProperty;
	}
}
