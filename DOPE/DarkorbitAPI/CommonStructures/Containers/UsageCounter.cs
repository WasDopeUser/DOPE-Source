using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures.Containers
{
	public class UsageCounter<T>
	{
		public Dictionary<T, UsageCounter<T>.UsageEntry> Stats { get; private set; }

		public UsageCounter()
		{
			Class13.Gj4N3WdzaR1LY();
			this.Stats = new Dictionary<T, UsageCounter<T>.UsageEntry>();
			base..ctor();
		}

		public UsageCounter<T>.UsageEntry method_0(T GjtpBqPvV76vaG0hrwZ)
		{
			Dictionary<T, UsageCounter<T>.UsageEntry> stats = this.Stats;
			UsageCounter<T>.UsageEntry result;
			lock (stats)
			{
				UsageCounter<T>.UsageEntry usageEntry;
				result = (this.Stats.TryGetValue(GjtpBqPvV76vaG0hrwZ, out usageEntry) ? usageEntry : new UsageCounter<T>.UsageEntry());
			}
			return result;
		}

		public UsageCounter<T>.UsageEntry method_1(T owsghNPI0lMq7pQc9Fh)
		{
			Dictionary<T, UsageCounter<T>.UsageEntry> stats = this.Stats;
			UsageCounter<T>.UsageEntry result;
			lock (stats)
			{
				UsageCounter<T>.UsageEntry usageEntry;
				if (!this.Stats.TryGetValue(owsghNPI0lMq7pQc9Fh, out usageEntry))
				{
					usageEntry = (this.Stats[owsghNPI0lMq7pQc9Fh] = new UsageCounter<T>.UsageEntry());
				}
				UsageCounter<T>.UsageEntry usageEntry2 = usageEntry;
				int count = usageEntry2.Count;
				usageEntry2.Count = count + 1;
				usageEntry.LastUsed = DateTimeOffset.Now;
				result = usageEntry;
			}
			return result;
		}

		public UsageCounter<T>.UsageEntry method_2(T JbZ8gsPgnJToIHRln0j, TimeSpan timeSpan_0, bool bool_0 = false)
		{
			Dictionary<T, UsageCounter<T>.UsageEntry> stats = this.Stats;
			UsageCounter<T>.UsageEntry result;
			lock (stats)
			{
				UsageCounter<T>.UsageEntry usageEntry;
				if (!this.Stats.TryGetValue(JbZ8gsPgnJToIHRln0j, out usageEntry))
				{
					usageEntry = (this.Stats[JbZ8gsPgnJToIHRln0j] = new UsageCounter<T>.UsageEntry());
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

		public bool method_3(T h7CW7HPtNJBOiyAw3D7)
		{
			Dictionary<T, UsageCounter<T>.UsageEntry> stats = this.Stats;
			bool result;
			lock (stats)
			{
				result = this.Stats.Remove(h7CW7HPtNJBOiyAw3D7);
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
				Class13.Gj4N3WdzaR1LY();
				base..ctor();
			}
		}
	}
}
