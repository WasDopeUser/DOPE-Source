using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class MaxHeap<T> : Heap<T>
	{
		public MaxHeap()
		{
			Class13.igxcIukzfpare();
			this..ctor(Comparer<T>.Default);
		}

		public MaxHeap(Comparer<T> comparer_0)
		{
			Class13.igxcIukzfpare();
			base..ctor(comparer_0);
		}

		public MaxHeap(IEnumerable<T> ienumerable_0, Comparer<T> comparer_0)
		{
			Class13.igxcIukzfpare();
			base..ctor(ienumerable_0, comparer_0);
		}

		public MaxHeap(IEnumerable<T> ienumerable_0)
		{
			Class13.igxcIukzfpare();
			base..ctor(ienumerable_0);
		}

		protected override bool Dominates(T of05HOnHxoMGDqPBVpe, T vPH490nXJn9Hj0EEkTb)
		{
			return base.Comparer.Compare(of05HOnHxoMGDqPBVpe, vPH490nXJn9Hj0EEkTb) >= 0;
		}
	}
}
