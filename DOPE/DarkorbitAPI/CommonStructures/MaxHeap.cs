using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class MaxHeap<T> : Heap<T>
	{
		public MaxHeap()
		{
			Class13.NP5bWyNzLwONS();
			this..ctor(Comparer<T>.Default);
		}

		public MaxHeap(Comparer<T> comparer_0)
		{
			Class13.NP5bWyNzLwONS();
			base..ctor(comparer_0);
		}

		public MaxHeap(IEnumerable<T> ienumerable_0, Comparer<T> comparer_0)
		{
			Class13.NP5bWyNzLwONS();
			base..ctor(ienumerable_0, comparer_0);
		}

		public MaxHeap(IEnumerable<T> ienumerable_0)
		{
			Class13.NP5bWyNzLwONS();
			base..ctor(ienumerable_0);
		}

		protected override bool Dominates(T hcdWC8tdcmYK2huwcFI, T Wm1Q4WtVfVu5X5snyqZ)
		{
			return base.Comparer.Compare(hcdWC8tdcmYK2huwcFI, Wm1Q4WtVfVu5X5snyqZ) >= 0;
		}
	}
}
