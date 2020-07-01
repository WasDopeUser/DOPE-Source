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

		public bool method_0(T Vjmxwcuhe3bNkJTmOU4)
		{
			DateTimeOffset right;
			if (!this.Cooldowns.TryGetValue(Vjmxwcuhe3bNkJTmOU4, out right))
			{
				return true;
			}
			if (this.Time > right)
			{
				DateTimeOffset dateTimeOffset;
				this.Cooldowns.TryRemove(Vjmxwcuhe3bNkJTmOU4, out dateTimeOffset);
				return true;
			}
			return false;
		}

		public void method_1(T cLhHCQulI1MN8sVIYy3, double double_0)
		{
			this.Cooldowns[cLhHCQulI1MN8sVIYy3] = this.Time.AddMilliseconds(double_0);
		}

		public bool method_2(T vEAaq6uMTtxK7EmJAkD, double double_0)
		{
			if (!this.method_0(vEAaq6uMTtxK7EmJAkD))
			{
				return false;
			}
			this.method_1(vEAaq6uMTtxK7EmJAkD, double_0);
			return true;
		}

		public bool Clear(T action)
		{
			DateTimeOffset dateTimeOffset;
			return this.Cooldowns.TryRemove(action, out dateTimeOffset);
		}

		public CooldownTracker()
		{
			Class13.F93tSdiz1aNIA();
			this.Cooldowns = new ConcurrentDictionary<T, DateTimeOffset>();
			base..ctor();
		}

		public readonly ConcurrentDictionary<T, DateTimeOffset> Cooldowns;
	}
}
