using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

public static class GClass6
{
	public static g2ePwcEZAmslq0mSmUQ smethod_0<g2ePwcEZAmslq0mSmUQ>(DependencyObject dependencyObject_0, Func<g2ePwcEZAmslq0mSmUQ, bool> func_0 = null) where g2ePwcEZAmslq0mSmUQ : DependencyObject
	{
		if (dependencyObject_0 == null)
		{
			return default(g2ePwcEZAmslq0mSmUQ);
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
				g2ePwcEZAmslq0mSmUQ g2ePwcEZAmslq0mSmUQ = child as g2ePwcEZAmslq0mSmUQ;
				if (g2ePwcEZAmslq0mSmUQ != null && (func_0 == null || func_0(g2ePwcEZAmslq0mSmUQ)))
				{
					return g2ePwcEZAmslq0mSmUQ;
				}
				queue.Enqueue(child);
			}
		}
		return default(g2ePwcEZAmslq0mSmUQ);
	}
}
