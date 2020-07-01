using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

public static class GClass6
{
	public static z39BTQc3E2aUydjJ40R smethod_0<z39BTQc3E2aUydjJ40R>(DependencyObject dependencyObject_0, Func<z39BTQc3E2aUydjJ40R, bool> func_0 = null) where z39BTQc3E2aUydjJ40R : DependencyObject
	{
		if (dependencyObject_0 == null)
		{
			return default(z39BTQc3E2aUydjJ40R);
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
				z39BTQc3E2aUydjJ40R z39BTQc3E2aUydjJ40R = child as z39BTQc3E2aUydjJ40R;
				if (z39BTQc3E2aUydjJ40R != null && (func_0 == null || func_0(z39BTQc3E2aUydjJ40R)))
				{
					return z39BTQc3E2aUydjJ40R;
				}
				queue.Enqueue(child);
			}
		}
		return default(z39BTQc3E2aUydjJ40R);
	}
}
