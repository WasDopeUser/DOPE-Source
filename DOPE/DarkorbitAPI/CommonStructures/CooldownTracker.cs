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

		public bool method_0(T YB2HVgIc9KRkHvfam9E)
		{
			DateTimeOffset right;
			if (!this.Cooldowns.TryGetValue(YB2HVgIc9KRkHvfam9E, out right))
			{
				return true;
			}
			if (this.Time > right)
			{
				DateTimeOffset dateTimeOffset;
				this.Cooldowns.TryRemove(YB2HVgIc9KRkHvfam9E, out dateTimeOffset);
				return true;
			}
			return false;
		}

		public void NuEqfWytUcF(T gdDyKrIHbMAdjEVOd7I, double double_0)
		{
			this.Cooldowns[gdDyKrIHbMAdjEVOd7I] = this.Time.AddMilliseconds(double_0);
		}

		public bool method_1(T LCjC8hIJUUbm4dy8oSk, double double_0)
		{
			if (!this.method_0(LCjC8hIJUUbm4dy8oSk))
			{
				return false;
			}
			this.NuEqfWytUcF(LCjC8hIJUUbm4dy8oSk, double_0);
			return true;
		}

		public bool Clear(T action)
		{
			DateTimeOffset dateTimeOffset;
			return this.Cooldowns.TryRemove(action, out dateTimeOffset);
		}

		public CooldownTracker()
		{
			Class13.plZSWFPzBWWEZ();
			this.Cooldowns = new ConcurrentDictionary<T, DateTimeOffset>();
			base..ctor();
		}

		public readonly ConcurrentDictionary<T, DateTimeOffset> Cooldowns;
	}
}
