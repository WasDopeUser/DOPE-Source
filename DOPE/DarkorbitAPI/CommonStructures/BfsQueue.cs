using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class BfsQueue<T>
	{
		public T this[int int_0]
		{
			get
			{
				return ref this._store[int_0];
			}
		}

		public ref T Top
		{
			get
			{
				return ref this._store[this._tree[1]];
			}
		}

		public BfsQueue(T[] gparam_0, Comparer<T> comparer_0)
		{
			Class8.xDph7tozmh5WD();
			base..ctor();
			this._pendingUpdates = new List<int>();
			this._store = gparam_0;
			this._leaves = 1;
			while (gparam_0.Length >= this._leaves)
			{
				this._leaves *= 2;
			}
			this._tree = new int[this._leaves + 7];
			this._leaves /= 2;
			this._comparer = comparer_0;
			this.method_0();
		}

		public void method_0()
		{
			int num = this._leaves + this._store.Length / 2;
			int i = this._leaves;
			int num2 = 0;
			while (i < num)
			{
				this._tree[i] = num2 + ((this._comparer.Compare(this._store[num2], this._store[num2 + 1]) > 0) ? 1 : 0);
				i++;
				num2 += 2;
			}
			if (this._store.Length % 2 == 1)
			{
				this._tree[num] = this._store.Length - 1;
			}
			for (int j = this._leaves - 1; j > 0; j--)
			{
				if (this._comparer.Compare(this._store[this._tree[2 * j]], this._store[this._tree[2 * j + 1]]) > 0)
				{
					this._tree[j] = this._tree[2 * j + 1];
				}
				else
				{
					this._tree[j] = this._tree[2 * j];
				}
			}
		}

		private int method_1(int int_0)
		{
			int num = this._leaves + int_0 / 2;
			if (int_0 == this._store.Length - 1)
			{
				this._tree[num] = int_0;
			}
			else
			{
				int num2 = (int_0 % 2 == 0) ? 1 : -1;
				this._tree[num] = int_0 + ((this._comparer.Compare(this._store[int_0], this._store[int_0 + num2]) > 0) ? num2 : 0);
			}
			return num;
		}

		public void QjqiiDdsoYg(int int_0)
		{
			int i = this.method_1(int_0);
			for (i /= 2; i > 0; i /= 2)
			{
				if (this._comparer.Compare(this._store[this._tree[2 * i]], this._store[this._tree[2 * i + 1]]) > 0)
				{
					this._tree[i] = this._tree[2 * i + 1];
				}
				else
				{
					this._tree[i] = this._tree[2 * i];
				}
			}
		}

		public void method_2(int int_0)
		{
			this._pendingUpdates.Add(int_0);
		}

		public void method_3()
		{
			if (this._pendingUpdates.Count == 1)
			{
				this.QjqiiDdsoYg(this._pendingUpdates[0]);
				this._pendingUpdates.Clear();
				return;
			}
			this._pendingUpdates.Sort();
			int num = this._pendingUpdates.Count;
			int i = 0;
			int num2 = -1;
			for (int j = 0; j < num; j++)
			{
				if (j / 2 != num2)
				{
					num2 = this.method_1(this._pendingUpdates[j]);
					if (num2 / 2 > 0)
					{
						this._pendingUpdates[j] = num2 / 2;
						i++;
					}
				}
			}
			while (i > 0)
			{
				int num3 = 0;
				num = i;
				num2 = -1;
				for (int k = 0; k < num; k++)
				{
					int num4 = this._pendingUpdates[k];
					if (num4 != num2)
					{
						num2 = num4;
						if (this._comparer.Compare(this._store[this._tree[2 * num4]], this._store[this._tree[2 * num4 + 1]]) > 0)
						{
							this._tree[num4] = this._tree[2 * num4 + 1];
						}
						else
						{
							this._tree[num4] = this._tree[2 * num4];
						}
						if (num4 / 2 > 0)
						{
							this._pendingUpdates[num3++] = num4 / 2;
						}
					}
				}
				i = num3;
			}
			this._pendingUpdates.Clear();
		}

		public int method_4()
		{
			return this._tree[1];
		}

		private readonly Comparer<T> _comparer;

		private readonly T[] _store;

		private int[] _tree;

		private int _leaves;

		private readonly List<int> _pendingUpdates;
	}
}
