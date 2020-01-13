using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

public static class GClass6
{
	public static gEBk6mHNpCH45QqumUL smethod_0<gEBk6mHNpCH45QqumUL>(DependencyObject dependencyObject_0, Func<gEBk6mHNpCH45QqumUL, bool> func_0 = null) where gEBk6mHNpCH45QqumUL : DependencyObject
	{
		if (dependencyObject_0 == null)
		{
			return default(gEBk6mHNpCH45QqumUL);
		}
		Queue<DependencyObject> queue = new Queue<DependencyObject>();
		queue.Enqueue(dependencyObject_0);
		while (queue.Any<DependencyObject>())
		{
			DependencyObject reference = queue.Dequeue();
			int childrenCount = VisualTreeHelper.GetChildrenCount(reference);
			for (int i = 0; i < childrenCount; i++)
			{
				DependencyObject child = VisualTreeHelper.GetChild(reference, i);
				gEBk6mHNpCH45QqumUL gEBk6mHNpCH45QqumUL = child as gEBk6mHNpCH45QqumUL;
				if (gEBk6mHNpCH45QqumUL != null && (func_0 == null || func_0(gEBk6mHNpCH45QqumUL)))
				{
					return gEBk6mHNpCH45QqumUL;
				}
				queue.Enqueue(child);
			}
		}
		return default(gEBk6mHNpCH45QqumUL);
	}
}
