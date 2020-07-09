using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

public static class GClass6
{
	public static gwsrCxcKsxbU8un8ejd smethod_0<gwsrCxcKsxbU8un8ejd>(DependencyObject dependencyObject_0, Func<gwsrCxcKsxbU8un8ejd, bool> func_0 = null) where gwsrCxcKsxbU8un8ejd : DependencyObject
	{
		if (dependencyObject_0 == null)
		{
			return default(gwsrCxcKsxbU8un8ejd);
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
				gwsrCxcKsxbU8un8ejd gwsrCxcKsxbU8un8ejd = child as gwsrCxcKsxbU8un8ejd;
				if (gwsrCxcKsxbU8un8ejd != null && (func_0 == null || func_0(gwsrCxcKsxbU8un8ejd)))
				{
					return gwsrCxcKsxbU8un8ejd;
				}
				queue.Enqueue(child);
			}
		}
		return default(gwsrCxcKsxbU8un8ejd);
	}
}
