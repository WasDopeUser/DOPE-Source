using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

public static class GClass6
{
	public static z0HbVNwRFDP8F6c3T9H smethod_0<z0HbVNwRFDP8F6c3T9H>(DependencyObject dependencyObject_0, Func<z0HbVNwRFDP8F6c3T9H, bool> func_0 = null) where z0HbVNwRFDP8F6c3T9H : DependencyObject
	{
		if (dependencyObject_0 == null)
		{
			return default(z0HbVNwRFDP8F6c3T9H);
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
				z0HbVNwRFDP8F6c3T9H z0HbVNwRFDP8F6c3T9H = child as z0HbVNwRFDP8F6c3T9H;
				if (z0HbVNwRFDP8F6c3T9H != null && (func_0 == null || func_0(z0HbVNwRFDP8F6c3T9H)))
				{
					return z0HbVNwRFDP8F6c3T9H;
				}
				queue.Enqueue(child);
			}
		}
		return default(z0HbVNwRFDP8F6c3T9H);
	}
}
