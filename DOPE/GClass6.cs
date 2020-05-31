using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

public static class GClass6
{
	public static L7mu37EWBfIjet5wHMj smethod_0<L7mu37EWBfIjet5wHMj>(DependencyObject dependencyObject_0, Func<L7mu37EWBfIjet5wHMj, bool> func_0 = null) where L7mu37EWBfIjet5wHMj : DependencyObject
	{
		if (dependencyObject_0 == null)
		{
			return default(L7mu37EWBfIjet5wHMj);
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
				L7mu37EWBfIjet5wHMj l7mu37EWBfIjet5wHMj = child as L7mu37EWBfIjet5wHMj;
				if (l7mu37EWBfIjet5wHMj != null && (func_0 == null || func_0(l7mu37EWBfIjet5wHMj)))
				{
					return l7mu37EWBfIjet5wHMj;
				}
				queue.Enqueue(child);
			}
		}
		return default(L7mu37EWBfIjet5wHMj);
	}
}
