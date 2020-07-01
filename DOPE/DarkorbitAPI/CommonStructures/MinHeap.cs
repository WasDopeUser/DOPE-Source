using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class MinHeap<T> : Heap<T>
	{
		public MinHeap()
		{
			Class13.F93tSdiz1aNIA();
			this..ctor(Comparer<T>.Default);
		}

		public MinHeap(Comparer<T> comparer_0)
		{
			Class13.F93tSdiz1aNIA();
			base..ctor(comparer_0);
		}

		public MinHeap(IEnumerable<T> ienumerable_0)
		{
			Class13.F93tSdiz1aNIA();
			base..ctor(ienumerable_0);
		}

		public MinHeap(IEnumerable<T> ienumerable_0, Comparer<T> comparer_0)
		{
			Class13.F93tSdiz1aNIA();
			base..ctor(ienumerable_0, comparer_0);
		}

		protected override bool Dominates(T I2OiBvuA4yHXeZOLGXP, T CMR7uou7TWCegNCkf3j)
		{
			return base.Comparer.Compare(I2OiBvuA4yHXeZOLGXP, CMR7uou7TWCegNCkf3j) <= 0;
		}
	}
}
