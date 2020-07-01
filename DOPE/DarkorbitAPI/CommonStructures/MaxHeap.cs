using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class MaxHeap<T> : Heap<T>
	{
		public MaxHeap()
		{
			Class13.F93tSdiz1aNIA();
			this..ctor(Comparer<T>.Default);
		}

		public MaxHeap(Comparer<T> comparer_0)
		{
			Class13.F93tSdiz1aNIA();
			base..ctor(comparer_0);
		}

		public MaxHeap(IEnumerable<T> ienumerable_0, Comparer<T> comparer_0)
		{
			Class13.F93tSdiz1aNIA();
			base..ctor(ienumerable_0, comparer_0);
		}

		public MaxHeap(IEnumerable<T> ienumerable_0)
		{
			Class13.F93tSdiz1aNIA();
			base..ctor(ienumerable_0);
		}

		protected override bool Dominates(T v8W5cAujJ0v201UyuQa, T k3HCGguxqoKYB5g22jI)
		{
			return base.Comparer.Compare(v8W5cAujJ0v201UyuQa, k3HCGguxqoKYB5g22jI) >= 0;
		}
	}
}
