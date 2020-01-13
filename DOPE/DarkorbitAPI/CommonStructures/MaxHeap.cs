using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class MaxHeap<T> : Heap<T>
	{
		public MaxHeap()
		{
			Class13.tMHx78BzgCM8j();
			this..ctor(Comparer<T>.Default);
		}

		public MaxHeap(Comparer<T> comparer_0)
		{
			Class13.tMHx78BzgCM8j();
			base..ctor(comparer_0);
		}

		public MaxHeap(IEnumerable<T> ienumerable_0, Comparer<T> comparer_0)
		{
			Class13.tMHx78BzgCM8j();
			base..ctor(ienumerable_0, comparer_0);
		}

		public MaxHeap(IEnumerable<T> ienumerable_0)
		{
			Class13.tMHx78BzgCM8j();
			base..ctor(ienumerable_0);
		}

		protected override bool Dominates(T PsujCJxyjYasWM2pAwI, T WBUDcdxuRMnTmKuN2qO)
		{
			return base.Comparer.Compare(PsujCJxyjYasWM2pAwI, WBUDcdxuRMnTmKuN2qO) >= 0;
		}
	}
}
