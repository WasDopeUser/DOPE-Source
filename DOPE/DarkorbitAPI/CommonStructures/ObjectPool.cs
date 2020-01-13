using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using NLog;

namespace DarkorbitAPI.CommonStructures
{
	public class ObjectPool<T> where T : class
	{
		public ObjectPool(string string_0)
		{
			Class13.tMHx78BzgCM8j();
			base..ctor();
			this._items = new ConcurrentBag<T>();
			this._lock = new SemaphoreSlim(0);
			this.Log = LogManager.GetLogger("ObjectPool-" + string_0);
		}

		protected bool method_0(out T gparam_0)
		{
			gparam_0 = default(T);
			return this._lock.Wait(0) && this._items.TryTake(out gparam_0);
		}

		protected bool method_1(out T gparam_0, int int_0)
		{
			if (int_0 == 0)
			{
				return this.method_0(out gparam_0);
			}
			gparam_0 = default(T);
			return this._lock.Wait(int_0) && this._items.TryTake(out gparam_0);
		}

		protected void method_2(T tJPN69x5U7Tnb3TD8CE)
		{
			this._items.Add(tJPN69x5U7Tnb3TD8CE);
			this._lock.Release();
		}

		public void method_3(T SkbgaRxLm70HlqitPLf)
		{
			this.method_2(SkbgaRxLm70HlqitPLf);
		}

		public bool method_4(Action<T> action_0, int int_0 = 0)
		{
			T t;
			if (this.method_1(out t, int_0))
			{
				Stopwatch stopwatch = Stopwatch.StartNew();
				try
				{
					action_0(t);
				}
				finally
				{
					this.method_2(t);
				}
				stopwatch.Stop();
				if (stopwatch.ElapsedMilliseconds > 20L)
				{
					this.Log.Warn("Object returned after {time:0.00}ms", stopwatch.ElapsedMilliseconds);
				}
				return true;
			}
			return false;
		}

		private ConcurrentBag<T> _items;

		private SemaphoreSlim _lock;

		protected Logger Log;
	}
}
