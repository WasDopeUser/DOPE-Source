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

		public bool method_0(T k6FvPuqG3Wx7aW70lSs)
		{
			DateTimeOffset right;
			if (!this.Cooldowns.TryGetValue(k6FvPuqG3Wx7aW70lSs, out right))
			{
				return true;
			}
			if (this.Time > right)
			{
				DateTimeOffset dateTimeOffset;
				this.Cooldowns.TryRemove(k6FvPuqG3Wx7aW70lSs, out dateTimeOffset);
				return true;
			}
			return false;
		}

		public void method_1(T pZT8weqF5vIbdTbHcJY, double double_0)
		{
			this.Cooldowns[pZT8weqF5vIbdTbHcJY] = this.Time.AddMilliseconds(double_0);
		}

		public bool method_2(T ixrpLvqDwmWowVZGrZG, double double_0)
		{
			if (!this.method_0(ixrpLvqDwmWowVZGrZG))
			{
				return false;
			}
			this.method_1(ixrpLvqDwmWowVZGrZG, double_0);
			return true;
		}

		public bool Clear(T action)
		{
			DateTimeOffset dateTimeOffset;
			return this.Cooldowns.TryRemove(action, out dateTimeOffset);
		}

		public CooldownTracker()
		{
			Class13.nIxas2ezryi9b();
			this.Cooldowns = new ConcurrentDictionary<T, DateTimeOffset>();
			base..ctor();
		}

		public readonly ConcurrentDictionary<T, DateTimeOffset> Cooldowns;
	}
}
