using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DarkorbitAPI.CommonStructures
{
	public abstract class Heap<T> : IEnumerable<T>, IEnumerable
	{
		public int Count
		{
			get
			{
				return this._tail;
			}
		}

		public int Capacity
		{
			get
			{
				return this._capacity;
			}
		}

		private protected Comparer<T> Comparer { protected get; private set; }

		protected abstract bool Dominates(T JFRBGRn9vtVCtgW364E, T Q7StqSnRsJ9Z2pF9OT3);

		protected Heap()
		{
			Class13.igxcIukzfpare();
			this..ctor(Comparer<T>.Default);
		}

		protected Heap(Comparer<T> comparer_0)
		{
			Class13.igxcIukzfpare();
			this..ctor(Enumerable.Empty<T>(), comparer_0);
		}

		protected Heap(IEnumerable<T> ienumerable_0)
		{
			Class13.igxcIukzfpare();
			this..ctor(ienumerable_0, Comparer<T>.Default);
		}

		public int Insertions { get; set; }

		protected Heap(IEnumerable<T> ienumerable_0, Comparer<T> comparer_0)
		{
			Class13.igxcIukzfpare();
			this._heap = new T[0];
			base..ctor();
			if (ienumerable_0 == null)
			{
				throw new ArgumentNullException("collection");
			}
			if (comparer_0 == null)
			{
				throw new ArgumentNullException("comparer");
			}
			this.Comparer = comparer_0;
			foreach (T t in ienumerable_0)
			{
				if (this.Count == this.Capacity)
				{
					this.method_8();
				}
				T[] heap = this._heap;
				int tail = this._tail;
				this._tail = tail + 1;
				heap[tail] = t;
			}
			for (int i = Heap<T>.Parent(this._tail - 1); i >= 0; i--)
			{
				this.method_4(i);
			}
		}

		public void method_0(T uXMxt9nt3gG0ofOFmHx)
		{
			int num = this.Insertions;
			this.Insertions = num + 1;
			if (this.Count == this.Capacity)
			{
				this.method_8();
			}
			T[] heap = this._heap;
			num = this._tail;
			this._tail = num + 1;
			heap[num] = uXMxt9nt3gG0ofOFmHx;
			this.method_1(this._tail - 1);
		}

		private void method_1(int int_0)
		{
			if (int_0 != 0 && !this.Dominates(this._heap[Heap<T>.Parent(int_0)], this._heap[int_0]))
			{
				this.method_7(int_0, Heap<T>.Parent(int_0));
				this.method_1(Heap<T>.Parent(int_0));
				return;
			}
		}

		public T method_2()
		{
			if (this.Count == 0)
			{
				throw new InvalidOperationException("Heap is empty");
			}
			return this._heap[0];
		}

		public T method_3()
		{
			if (this.Count == 0)
			{
				throw new InvalidOperationException("Heap is empty");
			}
			T result = this._heap[0];
			this._tail--;
			this.method_7(this._tail, 0);
			this.method_4(0);
			return result;
		}

		private void method_4(int int_0)
		{
			int num = this.method_5(int_0);
			if (num == int_0)
			{
				return;
			}
			this.method_7(int_0, num);
			this.method_4(num);
		}

		private int method_5(int int_0)
		{
			int int_ = this.method_6(Heap<T>.smethod_0(int_0), int_0);
			return this.method_6(Heap<T>.smethod_1(int_0), int_);
		}

		private int method_6(int int_0, int int_1)
		{
			if (int_0 < this._tail && !this.Dominates(this._heap[int_1], this._heap[int_0]))
			{
				return int_0;
			}
			return int_1;
		}

		private void method_7(int int_0, int int_1)
		{
			T t = this._heap[int_0];
			this._heap[int_0] = this._heap[int_1];
			this._heap[int_1] = t;
		}

		private static int Parent(int i)
		{
			return (i + 1) / 2 - 1;
		}

		private static int smethod_0(int int_0)
		{
			return (int_0 + 1) * 2 - 1;
		}

		private static int smethod_1(int int_0)
		{
			return Heap<T>.smethod_0(int_0) + 1;
		}

		private void method_8()
		{
			int num = this._capacity * 2 + 1;
			T[] array = new T[num];
			Array.Copy(this._heap, array, this._capacity);
			this._heap = array;
			this._capacity = num;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return this._heap.Take(this.Count).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		private int _capacity;

		private T[] _heap;

		private int _tail;
	}
}
