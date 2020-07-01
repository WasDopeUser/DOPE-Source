using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures.Containers
{
	public class UsageCounter<T>
	{
		public Dictionary<T, UsageCounter<T>.UsageEntry> Stats { get; private set; }

		public UsageCounter()
		{
			Class13.F93tSdiz1aNIA();
			this.Stats = new Dictionary<T, UsageCounter<T>.UsageEntry>();
			base..ctor();
		}

		public UsageCounter<T>.UsageEntry method_0(T XO1gy9uHxgmXN69CJ6c)
		{
			Dictionary<T, UsageCounter<T>.UsageEntry> stats = this.Stats;
			UsageCounter<T>.UsageEntry result;
			lock (stats)
			{
				UsageCounter<T>.UsageEntry usageEntry;
				result = (this.Stats.TryGetValue(XO1gy9uHxgmXN69CJ6c, out usageEntry) ? usageEntry : new UsageCounter<T>.UsageEntry());
			}
			return result;
		}

		public UsageCounter<T>.UsageEntry method_1(T FSJoLFuDQy5YyPBVkKx)
		{
			Dictionary<T, UsageCounter<T>.UsageEntry> stats = this.Stats;
			UsageCounter<T>.UsageEntry result;
			lock (stats)
			{
				UsageCounter<T>.UsageEntry usageEntry;
				if (!this.Stats.TryGetValue(FSJoLFuDQy5YyPBVkKx, out usageEntry))
				{
					usageEntry = (this.Stats[FSJoLFuDQy5YyPBVkKx] = new UsageCounter<T>.UsageEntry());
				}
				UsageCounter<T>.UsageEntry usageEntry2 = usageEntry;
				int count = usageEntry2.Count;
				usageEntry2.Count = count + 1;
				usageEntry.LastUsed = DateTimeOffset.Now;
				result = usageEntry;
			}
			return result;
		}

		public UsageCounter<T>.UsageEntry method_2(T hoKuWGuaQQ4YMu50k1y, TimeSpan timeSpan_0, bool bool_0 = false)
		{
			Dictionary<T, UsageCounter<T>.UsageEntry> stats = this.Stats;
			UsageCounter<T>.UsageEntry result;
			lock (stats)
			{
				UsageCounter<T>.UsageEntry usageEntry;
				if (!this.Stats.TryGetValue(hoKuWGuaQQ4YMu50k1y, out usageEntry))
				{
					usageEntry = (this.Stats[hoKuWGuaQQ4YMu50k1y] = new UsageCounter<T>.UsageEntry());
				}
				if (!usageEntry.LastUsed.smethod_1(timeSpan_0))
				{
					usageEntry.Count = 0;
				}
				if (bool_0)
				{
					UsageCounter<T>.UsageEntry usageEntry2 = usageEntry;
					int count = usageEntry2.Count;
					usageEntry2.Count = count + 1;
					usageEntry.LastUsed = DateTimeOffset.Now;
				}
				result = usageEntry;
			}
			return result;
		}

		public bool method_3(T h361pKuGpgoRMeTdrjL)
		{
			Dictionary<T, UsageCounter<T>.UsageEntry> stats = this.Stats;
			bool result;
			lock (stats)
			{
				result = this.Stats.Remove(h361pKuGpgoRMeTdrjL);
			}
			return result;
		}

		public void Clear()
		{
			Dictionary<T, UsageCounter<T>.UsageEntry> stats = this.Stats;
			lock (stats)
			{
				this.Stats.Clear();
			}
		}

		public class UsageEntry
		{
			public int Count { get; set; }

			public DateTimeOffset LastUsed { get; set; }

			public UsageEntry()
			{
				Class13.F93tSdiz1aNIA();
				base..ctor();
			}
		}
	}
}
