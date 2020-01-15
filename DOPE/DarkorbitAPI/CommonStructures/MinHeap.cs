using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class MinHeap<T> : Heap<T>
	{
		public MinHeap()
		{
			Class13.nIxas2ezryi9b();
			this..ctor(Comparer<T>.Default);
		}

		public MinHeap(Comparer<T> comparer_0)
		{
			Class13.nIxas2ezryi9b();
			base..ctor(comparer_0);
		}

		public MinHeap(IEnumerable<T> ienumerable_0)
		{
			Class13.nIxas2ezryi9b();
			base..ctor(ienumerable_0);
		}

		public MinHeap(IEnumerable<T> ienumerable_0, Comparer<T> comparer_0)
		{
			Class13.nIxas2ezryi9b();
			base..ctor(ienumerable_0, comparer_0);
		}

		protected override bool Dominates(T q4ujeKqEVcKgiiI3nSn, T r80imSqJFbfwCJ8awFZ)
		{
			return base.Comparer.Compare(q4ujeKqEVcKgiiI3nSn, r80imSqJFbfwCJ8awFZ) <= 0;
		}
	}
}
