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

		public bool method_0(T GF013yPejSv1eEMjU6O)
		{
			DateTimeOffset right;
			if (!this.Cooldowns.TryGetValue(GF013yPejSv1eEMjU6O, out right))
			{
				return true;
			}
			if (this.Time > right)
			{
				DateTimeOffset dateTimeOffset;
				this.Cooldowns.TryRemove(GF013yPejSv1eEMjU6O, out dateTimeOffset);
				return true;
			}
			return false;
		}

		public void method_1(T g0tULCP09wqahG4sHPS, double double_0)
		{
			this.Cooldowns[g0tULCP09wqahG4sHPS] = this.Time.AddMilliseconds(double_0);
		}

		public bool method_2(T uaRUG0PDdrBnXbenW5X, double double_0)
		{
			if (!this.method_0(uaRUG0PDdrBnXbenW5X))
			{
				return false;
			}
			this.method_1(uaRUG0PDdrBnXbenW5X, double_0);
			return true;
		}

		public bool Clear(T action)
		{
			DateTimeOffset dateTimeOffset;
			return this.Cooldowns.TryRemove(action, out dateTimeOffset);
		}

		public CooldownTracker()
		{
			Class13.Gj4N3WdzaR1LY();
			this.Cooldowns = new ConcurrentDictionary<T, DateTimeOffset>();
			base..ctor();
		}

		public readonly ConcurrentDictionary<T, DateTimeOffset> Cooldowns;
	}
}
