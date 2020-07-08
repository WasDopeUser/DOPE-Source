using System;
using System.Collections.Concurrent;

namespace DarkorbitAPI.CommonStructures
{
	public class CooldownTracker<T>
	{
		public DateTimeOffset? Now { get; set; }

		private DateTimeOffset Time
		{
			get
			{
				if (this.Now == null)
				{
					return DateTimeOffset.Now;
				}
				return this.Now.Value;
			}
		}

		public bool method_0(T sADnvG5TKdncAPkhmNo)
		{
			DateTimeOffset right;
			if (!this.Cooldowns.TryGetValue(sADnvG5TKdncAPkhmNo, out right))
			{
				return true;
			}
			if (this.Time > right)
			{
				DateTimeOffset dateTimeOffset;
				this.Cooldowns.TryRemove(sADnvG5TKdncAPkhmNo, out dateTimeOffset);
				return true;
			}
			return false;
		}

		public void method_1(T x2rVJZ5ky8v5Nr2ZhS4, double double_0)
		{
			this.Cooldowns[x2rVJZ5ky8v5Nr2ZhS4] = this.Time.AddMilliseconds(double_0);
		}

		public bool method_2(T uJ9nBb5tFEyTvwMgTNd, double double_0)
		{
			if (!this.method_0(uJ9nBb5tFEyTvwMgTNd))
			{
				return false;
			}
			this.method_1(uJ9nBb5tFEyTvwMgTNd, double_0);
			return true;
		}

		public bool Clear(T action)
		{
			DateTimeOffset dateTimeOffset;
			return this.Cooldowns.TryRemove(action, out dateTimeOffset);
		}

		public CooldownTracker()
		{
			Class13.xnk8ImWzpOt04();
			this.Cooldowns = new ConcurrentDictionary<T, DateTimeOffset>();
			base..ctor();
		}

		public readonly ConcurrentDictionary<T, DateTimeOffset> Cooldowns;
	}
}
