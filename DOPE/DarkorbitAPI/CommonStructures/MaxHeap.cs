using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class MaxHeap<T> : Heap<T>
	{
		public MaxHeap()
		{
			Class8.xDph7tozmh5WD();
			this..ctor(Comparer<T>.Default);
		}

		public MaxHeap(Comparer<T> comparer_0)
		{
			Class8.xDph7tozmh5WD();
			base..ctor(comparer_0);
		}

		public MaxHeap(IEnumerable<T> ienumerable_0, Comparer<T> comparer_0)
		{
			Class8.xDph7tozmh5WD();
			base..ctor(ienumerable_0, comparer_0);
		}

		public MaxHeap(IEnumerable<T> ienumerable_0)
		{
			Class8.xDph7tozmh5WD();
			base..ctor(ienumerable_0);
		}

		protected override bool Dominates(T UjyKO9qxpiXFQx0bGwb, T k1sVEgq6ZJdJPl7JL5a)
		{
			return base.Comparer.Compare(UjyKO9qxpiXFQx0bGwb, k1sVEgq6ZJdJPl7JL5a) >= 0;
		}
	}
}
