using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class MaxHeap<T> : Heap<T>
	{
		public MaxHeap()
		{
			Class13.nIxas2ezryi9b();
			this..ctor(Comparer<T>.Default);
		}

		public MaxHeap(Comparer<T> comparer_0)
		{
			Class13.nIxas2ezryi9b();
			base..ctor(comparer_0);
		}

		public MaxHeap(IEnumerable<T> ienumerable_0, Comparer<T> comparer_0)
		{
			Class13.nIxas2ezryi9b();
			base..ctor(ienumerable_0, comparer_0);
		}

		public MaxHeap(IEnumerable<T> ienumerable_0)
		{
			Class13.nIxas2ezryi9b();
			base..ctor(ienumerable_0);
		}

		protected override bool Dominates(T UPGwr7qXsCJEVj3RSbC, T tfqGCgqpiJoOaROnWHf)
		{
			return base.Comparer.Compare(UPGwr7qXsCJEVj3RSbC, tfqGCgqpiJoOaROnWHf) >= 0;
		}
	}
}
