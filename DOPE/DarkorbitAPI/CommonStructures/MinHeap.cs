using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class MinHeap<T> : Heap<T>
	{
		public MinHeap()
		{
			Class13.lOBHd9Nzn7x2T();
			this..ctor(Comparer<T>.Default);
		}

		public MinHeap(Comparer<T> comparer_0)
		{
			Class13.lOBHd9Nzn7x2T();
			base..ctor(comparer_0);
		}

		public MinHeap(IEnumerable<T> ienumerable_0)
		{
			Class13.lOBHd9Nzn7x2T();
			base..ctor(ienumerable_0);
		}

		public MinHeap(IEnumerable<T> ienumerable_0, Comparer<T> comparer_0)
		{
			Class13.lOBHd9Nzn7x2T();
			base..ctor(ienumerable_0, comparer_0);
		}

		protected override bool Dominates(T d6iJMdQkkqwB9fpIjRO, T zaCSLyQRKwu63yJmAfw)
		{
			return base.Comparer.Compare(d6iJMdQkkqwB9fpIjRO, zaCSLyQRKwu63yJmAfw) <= 0;
		}
	}
}
