using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class MinHeap<T> : Heap<T>
	{
		public MinHeap()
		{
			Class13.plZSWFPzBWWEZ();
			this..ctor(Comparer<T>.Default);
		}

		public MinHeap(Comparer<T> comparer_0)
		{
			Class13.plZSWFPzBWWEZ();
			base..ctor(comparer_0);
		}

		public MinHeap(IEnumerable<T> ienumerable_0)
		{
			Class13.plZSWFPzBWWEZ();
			base..ctor(ienumerable_0);
		}

		public MinHeap(IEnumerable<T> ienumerable_0, Comparer<T> comparer_0)
		{
			Class13.plZSWFPzBWWEZ();
			base..ctor(ienumerable_0, comparer_0);
		}

		protected override bool Dominates(T Eec9qQIpYIi7vKyDBOF, T YvhX9LIN86qBbNC56Rq)
		{
			return base.Comparer.Compare(Eec9qQIpYIi7vKyDBOF, YvhX9LIN86qBbNC56Rq) <= 0;
		}
	}
}
