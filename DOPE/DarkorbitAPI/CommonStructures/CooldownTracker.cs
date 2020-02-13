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

		public bool method_0(T QMHELinvkSjpiQZ3poZ)
		{
			DateTimeOffset right;
			if (!this.Cooldowns.TryGetValue(QMHELinvkSjpiQZ3poZ, out right))
			{
				return true;
			}
			if (this.Time > right)
			{
				DateTimeOffset dateTimeOffset;
				this.Cooldowns.TryRemove(QMHELinvkSjpiQZ3poZ, out dateTimeOffset);
				return true;
			}
			return false;
		}

		public void method_1(T PbBjdsnAJLgRGWMsR15, double double_0)
		{
			this.Cooldowns[PbBjdsnAJLgRGWMsR15] = this.Time.AddMilliseconds(double_0);
		}

		public bool method_2(T lpVKSAn0wodGfVf4GQE, double double_0)
		{
			if (!this.method_0(lpVKSAn0wodGfVf4GQE))
			{
				return false;
			}
			this.method_1(lpVKSAn0wodGfVf4GQE, double_0);
			return true;
		}

		public bool Clear(T action)
		{
			DateTimeOffset dateTimeOffset;
			return this.Cooldowns.TryRemove(action, out dateTimeOffset);
		}

		public CooldownTracker()
		{
			Class13.igxcIukzfpare();
			this.Cooldowns = new ConcurrentDictionary<T, DateTimeOffset>();
			base..ctor();
		}

		public readonly ConcurrentDictionary<T, DateTimeOffset> Cooldowns;
	}
}
