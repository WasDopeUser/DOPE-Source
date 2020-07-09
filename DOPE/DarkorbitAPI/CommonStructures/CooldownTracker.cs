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

		public bool method_0(T yJRpWbQat6n6VCJ1rDk)
		{
			DateTimeOffset right;
			if (!this.Cooldowns.TryGetValue(yJRpWbQat6n6VCJ1rDk, out right))
			{
				return true;
			}
			if (this.Time > right)
			{
				DateTimeOffset dateTimeOffset;
				this.Cooldowns.TryRemove(yJRpWbQat6n6VCJ1rDk, out dateTimeOffset);
				return true;
			}
			return false;
		}

		public void method_1(T wPpsLYQYpICCJkxI98j, double double_0)
		{
			this.Cooldowns[wPpsLYQYpICCJkxI98j] = this.Time.AddMilliseconds(double_0);
		}

		public bool method_2(T xWEYupQ6HTJv937gOED, double double_0)
		{
			if (!this.method_0(xWEYupQ6HTJv937gOED))
			{
				return false;
			}
			this.method_1(xWEYupQ6HTJv937gOED, double_0);
			return true;
		}

		public bool Clear(T action)
		{
			DateTimeOffset dateTimeOffset;
			return this.Cooldowns.TryRemove(action, out dateTimeOffset);
		}

		public CooldownTracker()
		{
			Class13.lOBHd9Nzn7x2T();
			this.Cooldowns = new ConcurrentDictionary<T, DateTimeOffset>();
			base..ctor();
		}

		public readonly ConcurrentDictionary<T, DateTimeOffset> Cooldowns;
	}
}
