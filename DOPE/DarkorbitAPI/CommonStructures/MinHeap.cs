using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class MinHeap<T> : Heap<T>
	{
		public MinHeap()
		{
			Class13.tMHx78BzgCM8j();
			this..ctor(Comparer<T>.Default);
		}

		public MinHeap(Comparer<T> comparer_0)
		{
			Class13.tMHx78BzgCM8j();
			base..ctor(comparer_0);
		}

		public MinHeap(IEnumerable<T> ienumerable_0)
		{
			Class13.tMHx78BzgCM8j();
			base..ctor(ienumerable_0);
		}

		public MinHeap(IEnumerable<T> ienumerable_0, Comparer<T> comparer_0)
		{
			Class13.tMHx78BzgCM8j();
			base..ctor(ienumerable_0, comparer_0);
		}

		protected override bool Dominates(T Y7DB1WxtaIwVJR2YOHm, T nbuoRrx0sQ29qVNaFOh)
		{
			return base.Comparer.Compare(Y7DB1WxtaIwVJR2YOHm, nbuoRrx0sQ29qVNaFOh) <= 0;
		}
	}
}
