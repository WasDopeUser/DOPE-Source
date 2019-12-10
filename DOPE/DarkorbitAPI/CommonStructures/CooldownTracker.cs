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

		public bool method_0(T NvEwwwqCphFErIVrfIE)
		{
			DateTimeOffset right;
			if (!this.Cooldowns.TryGetValue(NvEwwwqCphFErIVrfIE, out right))
			{
				return true;
			}
			if (this.Time > right)
			{
				DateTimeOffset dateTimeOffset;
				this.Cooldowns.TryRemove(NvEwwwqCphFErIVrfIE, out dateTimeOffset);
				return true;
			}
			return false;
		}

		public void method_1(T nBImLHqkOuWphFambaJ, double double_0)
		{
			this.Cooldowns[nBImLHqkOuWphFambaJ] = this.Time.AddMilliseconds(double_0);
		}

		public bool method_2(T bCm1A5q0V3AZhIFCogp, double double_0)
		{
			if (!this.method_0(bCm1A5q0V3AZhIFCogp))
			{
				return false;
			}
			this.method_1(bCm1A5q0V3AZhIFCogp, double_0);
			return true;
		}

		public bool Clear(T action)
		{
			DateTimeOffset dateTimeOffset;
			return this.Cooldowns.TryRemove(action, out dateTimeOffset);
		}

		public CooldownTracker()
		{
			Class8.xDph7tozmh5WD();
			this.Cooldowns = new ConcurrentDictionary<T, DateTimeOffset>();
			base..ctor();
		}

		public readonly ConcurrentDictionary<T, DateTimeOffset> Cooldowns;
	}
}
