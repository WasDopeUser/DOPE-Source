using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

public static class GClass6
{
	public static SQAOx3bqMSagS7G2rh3 smethod_0<SQAOx3bqMSagS7G2rh3>(DependencyObject dependencyObject_0, Func<SQAOx3bqMSagS7G2rh3, bool> func_0 = null) where SQAOx3bqMSagS7G2rh3 : DependencyObject
	{
		if (dependencyObject_0 == null)
		{
			return default(SQAOx3bqMSagS7G2rh3);
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
				SQAOx3bqMSagS7G2rh3 sqaox3bqMSagS7G2rh = child as SQAOx3bqMSagS7G2rh3;
				if (sqaox3bqMSagS7G2rh != null && (func_0 == null || func_0(sqaox3bqMSagS7G2rh)))
				{
					return sqaox3bqMSagS7G2rh;
				}
				queue.Enqueue(child);
			}
		}
		return default(SQAOx3bqMSagS7G2rh3);
	}
}
