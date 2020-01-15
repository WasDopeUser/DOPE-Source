using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

public static class GClass6
{
	public static TRiqZDLAJkMZwTSAepB smethod_0<TRiqZDLAJkMZwTSAepB>(DependencyObject dependencyObject_0, Func<TRiqZDLAJkMZwTSAepB, bool> func_0 = null) where TRiqZDLAJkMZwTSAepB : DependencyObject
	{
		if (dependencyObject_0 == null)
		{
			return default(TRiqZDLAJkMZwTSAepB);
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
				TRiqZDLAJkMZwTSAepB triqZDLAJkMZwTSAepB = child as TRiqZDLAJkMZwTSAepB;
				if (triqZDLAJkMZwTSAepB != null && (func_0 == null || func_0(triqZDLAJkMZwTSAepB)))
				{
					return triqZDLAJkMZwTSAepB;
				}
				queue.Enqueue(child);
			}
		}
		return default(TRiqZDLAJkMZwTSAepB);
	}
}
