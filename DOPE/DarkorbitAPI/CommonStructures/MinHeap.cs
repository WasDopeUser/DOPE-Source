using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class MinHeap<T> : Heap<T>
	{
		public MinHeap()
		{
			Class8.xDph7tozmh5WD();
			this..ctor(Comparer<T>.Default);
		}

		public MinHeap(Comparer<T> comparer_0)
		{
			Class8.xDph7tozmh5WD();
			base..ctor(comparer_0);
		}

		public MinHeap(IEnumerable<T> ienumerable_0)
		{
			Class8.xDph7tozmh5WD();
			base..ctor(ienumerable_0);
		}

		public MinHeap(IEnumerable<T> ienumerable_0, Comparer<T> comparer_0)
		{
			Class8.xDph7tozmh5WD();
			base..ctor(ienumerable_0, comparer_0);
		}

		protected override bool Dominates(T wT3VIiqe1XUXJwRGOav, T e56Jj6q7wSdkaLNPedk)
		{
			return base.Comparer.Compare(wT3VIiqe1XUXJwRGOav, e56Jj6q7wSdkaLNPedk) <= 0;
		}
	}
}
