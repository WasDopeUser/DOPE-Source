using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

public static class GClass6
{
	public static s6jr0LGPhbGgKTrp9LL smethod_0<s6jr0LGPhbGgKTrp9LL>(DependencyObject dependencyObject_0, Func<s6jr0LGPhbGgKTrp9LL, bool> func_0 = null) where s6jr0LGPhbGgKTrp9LL : DependencyObject
	{
		if (dependencyObject_0 == null)
		{
			return default(s6jr0LGPhbGgKTrp9LL);
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
				s6jr0LGPhbGgKTrp9LL s6jr0LGPhbGgKTrp9LL = child as s6jr0LGPhbGgKTrp9LL;
				if (s6jr0LGPhbGgKTrp9LL != null && (func_0 == null || func_0(s6jr0LGPhbGgKTrp9LL)))
				{
					return s6jr0LGPhbGgKTrp9LL;
				}
				queue.Enqueue(child);
			}
		}
		return default(s6jr0LGPhbGgKTrp9LL);
	}
}
