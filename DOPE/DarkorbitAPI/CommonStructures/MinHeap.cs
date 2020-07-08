using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class MinHeap<T> : Heap<T>
	{
		public MinHeap()
		{
			Class13.xnk8ImWzpOt04();
			this..ctor(Comparer<T>.Default);
		}

		public MinHeap(Comparer<T> comparer_0)
		{
			Class13.xnk8ImWzpOt04();
			base..ctor(comparer_0);
		}

		public MinHeap(IEnumerable<T> ienumerable_0)
		{
			Class13.xnk8ImWzpOt04();
			base..ctor(ienumerable_0);
		}

		public MinHeap(IEnumerable<T> ienumerable_0, Comparer<T> comparer_0)
		{
			Class13.xnk8ImWzpOt04();
			base..ctor(ienumerable_0, comparer_0);
		}

		protected override bool Dominates(T EQq0p75dnk4qSZ1abY6, T VrMx6b5jGR8EyAgdwpT)
		{
			return base.Comparer.Compare(EQq0p75dnk4qSZ1abY6, VrMx6b5jGR8EyAgdwpT) <= 0;
		}
	}
}
