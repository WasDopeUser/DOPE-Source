using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class MaxHeap<T> : Heap<T>
	{
		public MaxHeap()
		{
			Class13.Gj4N3WdzaR1LY();
			this..ctor(Comparer<T>.Default);
		}

		public MaxHeap(Comparer<T> comparer_0)
		{
			Class13.Gj4N3WdzaR1LY();
			base..ctor(comparer_0);
		}

		public MaxHeap(IEnumerable<T> ienumerable_0, Comparer<T> comparer_0)
		{
			Class13.Gj4N3WdzaR1LY();
			base..ctor(ienumerable_0, comparer_0);
		}

		public MaxHeap(IEnumerable<T> ienumerable_0)
		{
			Class13.Gj4N3WdzaR1LY();
			base..ctor(ienumerable_0);
		}

		protected override bool Dominates(T F1Q53XPHr4JqqjHAhX6, T TvhZfDPKONcaNr8taBJ)
		{
			return base.Comparer.Compare(F1Q53XPHr4JqqjHAhX6, TvhZfDPKONcaNr8taBJ) >= 0;
		}
	}
}
