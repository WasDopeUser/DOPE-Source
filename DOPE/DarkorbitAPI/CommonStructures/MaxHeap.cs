using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class MaxHeap<T> : Heap<T>
	{
		public MaxHeap()
		{
			Class13.plZSWFPzBWWEZ();
			this..ctor(Comparer<T>.Default);
		}

		public MaxHeap(Comparer<T> comparer_0)
		{
			Class13.plZSWFPzBWWEZ();
			base..ctor(comparer_0);
		}

		public MaxHeap(IEnumerable<T> ienumerable_0, Comparer<T> comparer_0)
		{
			Class13.plZSWFPzBWWEZ();
			base..ctor(ienumerable_0, comparer_0);
		}

		public MaxHeap(IEnumerable<T> ienumerable_0)
		{
			Class13.plZSWFPzBWWEZ();
			base..ctor(ienumerable_0);
		}

		protected override bool Dominates(T c1OZvOI64mafcG0k8jq, T mv3uxgIO53uthwmDcaX)
		{
			return base.Comparer.Compare(c1OZvOI64mafcG0k8jq, mv3uxgIO53uthwmDcaX) >= 0;
		}
	}
}
