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

		public bool method_0(T B0FSM8xeND3g1nu0S4a)
		{
			DateTimeOffset right;
			if (!this.Cooldowns.TryGetValue(B0FSM8xeND3g1nu0S4a, out right))
			{
				return true;
			}
			if (this.Time > right)
			{
				DateTimeOffset dateTimeOffset;
				this.Cooldowns.TryRemove(B0FSM8xeND3g1nu0S4a, out dateTimeOffset);
				return true;
			}
			return false;
		}

		public void method_1(T RpOgoXxJMkQXMQsayKh, double double_0)
		{
			this.Cooldowns[RpOgoXxJMkQXMQsayKh] = this.Time.AddMilliseconds(double_0);
		}

		public bool method_2(T BVV8a7xGjJvavb14MYa, double double_0)
		{
			if (!this.method_0(BVV8a7xGjJvavb14MYa))
			{
				return false;
			}
			this.method_1(BVV8a7xGjJvavb14MYa, double_0);
			return true;
		}

		public bool Clear(T action)
		{
			DateTimeOffset dateTimeOffset;
			return this.Cooldowns.TryRemove(action, out dateTimeOffset);
		}

		public CooldownTracker()
		{
			Class13.tMHx78BzgCM8j();
			this.Cooldowns = new ConcurrentDictionary<T, DateTimeOffset>();
			base..ctor();
		}

		public readonly ConcurrentDictionary<T, DateTimeOffset> Cooldowns;
	}
}
