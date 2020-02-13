using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class MinHeap<T> : Heap<T>
	{
		public MinHeap()
		{
			Class13.igxcIukzfpare();
			this..ctor(Comparer<T>.Default);
		}

		public MinHeap(Comparer<T> comparer_0)
		{
			Class13.igxcIukzfpare();
			base..ctor(comparer_0);
		}

		public MinHeap(IEnumerable<T> ienumerable_0)
		{
			Class13.igxcIukzfpare();
			base..ctor(ienumerable_0);
		}

		public MinHeap(IEnumerable<T> ienumerable_0, Comparer<T> comparer_0)
		{
			Class13.igxcIukzfpare();
			base..ctor(ienumerable_0, comparer_0);
		}

		protected override bool Dominates(T CijnALnuWyDL0f8SKM6, T kxRAtBnYOpQg0aBL01b)
		{
			return base.Comparer.Compare(CijnALnuWyDL0f8SKM6, kxRAtBnYOpQg0aBL01b) <= 0;
		}
	}
}
