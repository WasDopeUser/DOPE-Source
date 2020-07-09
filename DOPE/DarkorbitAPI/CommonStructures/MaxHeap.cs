using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class MaxHeap<T> : Heap<T>
	{
		public MaxHeap()
		{
			Class13.lOBHd9Nzn7x2T();
			this..ctor(Comparer<T>.Default);
		}

		public MaxHeap(Comparer<T> comparer_0)
		{
			Class13.lOBHd9Nzn7x2T();
			base..ctor(comparer_0);
		}

		public MaxHeap(IEnumerable<T> ienumerable_0, Comparer<T> comparer_0)
		{
			Class13.lOBHd9Nzn7x2T();
			base..ctor(ienumerable_0, comparer_0);
		}

		public MaxHeap(IEnumerable<T> ienumerable_0)
		{
			Class13.lOBHd9Nzn7x2T();
			base..ctor(ienumerable_0);
		}

		protected override bool Dominates(T VVFu1QQNi1Ood7KYrD3, T SAgPBSQBxOMNuu1wsmL)
		{
			return base.Comparer.Compare(VVFu1QQNi1Ood7KYrD3, SAgPBSQBxOMNuu1wsmL) >= 0;
		}
	}
}
