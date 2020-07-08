using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class MaxHeap<T> : Heap<T>
	{
		public MaxHeap()
		{
			Class13.xnk8ImWzpOt04();
			this..ctor(Comparer<T>.Default);
		}

		public MaxHeap(Comparer<T> comparer_0)
		{
			Class13.xnk8ImWzpOt04();
			base..ctor(comparer_0);
		}

		public MaxHeap(IEnumerable<T> ienumerable_0, Comparer<T> comparer_0)
		{
			Class13.xnk8ImWzpOt04();
			base..ctor(ienumerable_0, comparer_0);
		}

		public MaxHeap(IEnumerable<T> ienumerable_0)
		{
			Class13.xnk8ImWzpOt04();
			base..ctor(ienumerable_0);
		}

		protected override bool Dominates(T mESuBD5haXeOAkrZrcn, T Ew9rKk53ySrdNTP4tbV)
		{
			return base.Comparer.Compare(mESuBD5haXeOAkrZrcn, Ew9rKk53ySrdNTP4tbV) >= 0;
		}
	}
}
