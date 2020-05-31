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

		public bool method_0(T JjSIn2thf9jBqGLB9aL)
		{
			DateTimeOffset right;
			if (!this.Cooldowns.TryGetValue(JjSIn2thf9jBqGLB9aL, out right))
			{
				return true;
			}
			if (this.Time > right)
			{
				DateTimeOffset dateTimeOffset;
				this.Cooldowns.TryRemove(JjSIn2thf9jBqGLB9aL, out dateTimeOffset);
				return true;
			}
			return false;
		}

		public void method_1(T Jx5Vrcty55IE4wDn0qA, double double_0)
		{
			this.Cooldowns[Jx5Vrcty55IE4wDn0qA] = this.Time.AddMilliseconds(double_0);
		}

		public bool method_2(T t0xqR6t384bf4pMgo0W, double double_0)
		{
			if (!this.method_0(t0xqR6t384bf4pMgo0W))
			{
				return false;
			}
			this.method_1(t0xqR6t384bf4pMgo0W, double_0);
			return true;
		}

		public bool Clear(T action)
		{
			DateTimeOffset dateTimeOffset;
			return this.Cooldowns.TryRemove(action, out dateTimeOffset);
		}

		public CooldownTracker()
		{
			Class13.NP5bWyNzLwONS();
			this.Cooldowns = new ConcurrentDictionary<T, DateTimeOffset>();
			base..ctor();
		}

		public readonly ConcurrentDictionary<T, DateTimeOffset> Cooldowns;
	}
}
