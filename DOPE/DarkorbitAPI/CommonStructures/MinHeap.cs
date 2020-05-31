using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class MinHeap<T> : Heap<T>
	{
		public MinHeap()
		{
			Class13.NP5bWyNzLwONS();
			this..ctor(Comparer<T>.Default);
		}

		public MinHeap(Comparer<T> comparer_0)
		{
			Class13.NP5bWyNzLwONS();
			base..ctor(comparer_0);
		}

		public MinHeap(IEnumerable<T> ienumerable_0)
		{
			Class13.NP5bWyNzLwONS();
			base..ctor(ienumerable_0);
		}

		public MinHeap(IEnumerable<T> ienumerable_0, Comparer<T> comparer_0)
		{
			Class13.NP5bWyNzLwONS();
			base..ctor(ienumerable_0, comparer_0);
		}

		protected override bool Dominates(T KscvPEtDBAgGuRJiNBv, T ugDvOdtqNSdcIVBN1QN)
		{
			return base.Comparer.Compare(KscvPEtDBAgGuRJiNBv, ugDvOdtqNSdcIVBN1QN) <= 0;
		}
	}
}
