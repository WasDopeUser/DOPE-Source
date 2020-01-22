using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

public static class GClass6
{
	public static V7tjnMFMTHH5PLMqDyH smethod_0<V7tjnMFMTHH5PLMqDyH>(DependencyObject dependencyObject_0, Func<V7tjnMFMTHH5PLMqDyH, bool> func_0 = null) where V7tjnMFMTHH5PLMqDyH : DependencyObject
	{
		if (dependencyObject_0 == null)
		{
			return default(V7tjnMFMTHH5PLMqDyH);
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
				V7tjnMFMTHH5PLMqDyH v7tjnMFMTHH5PLMqDyH = child as V7tjnMFMTHH5PLMqDyH;
				if (v7tjnMFMTHH5PLMqDyH != null && (func_0 == null || func_0(v7tjnMFMTHH5PLMqDyH)))
				{
					return v7tjnMFMTHH5PLMqDyH;
				}
				queue.Enqueue(child);
			}
		}
		return default(V7tjnMFMTHH5PLMqDyH);
	}
}
