using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class MinHeap<T> : Heap<T>
	{
		public MinHeap()
		{
			Class13.Gj4N3WdzaR1LY();
			this..ctor(Comparer<T>.Default);
		}

		public MinHeap(Comparer<T> comparer_0)
		{
			Class13.Gj4N3WdzaR1LY();
			base..ctor(comparer_0);
		}

		public MinHeap(IEnumerable<T> ienumerable_0)
		{
			Class13.Gj4N3WdzaR1LY();
			base..ctor(ienumerable_0);
		}

		public MinHeap(IEnumerable<T> ienumerable_0, Comparer<T> comparer_0)
		{
			Class13.Gj4N3WdzaR1LY();
			base..ctor(ienumerable_0, comparer_0);
		}

		protected override bool Dominates(T X2TieHPkjqPfsm51sij, T sh3bdQPhNIUuha6YvRS)
		{
			return base.Comparer.Compare(X2TieHPkjqPfsm51sij, sh3bdQPhNIUuha6YvRS) <= 0;
		}
	}
}
