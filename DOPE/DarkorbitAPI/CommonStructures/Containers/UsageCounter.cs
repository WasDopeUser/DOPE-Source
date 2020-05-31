using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures.Containers
{
	public class UsageCounter<T>
	{
		public Dictionary<T, UsageCounter<T>.UsageEntry> Stats { get; private set; }

		public UsageCounter()
		{
			Class13.NP5bWyNzLwONS();
			this.Stats = new Dictionary<T, UsageCounter<T>.UsageEntry>();
			base..ctor();
		}

		public UsageCounter<T>.UsageEntry method_0(T hqofP5Llfy1q0WKcCyl)
		{
			Dictionary<T, UsageCounter<T>.UsageEntry> stats = this.Stats;
			UsageCounter<T>.UsageEntry result;
			lock (stats)
			{
				UsageCounter<T>.UsageEntry usageEntry;
				result = (this.Stats.TryGetValue(hqofP5Llfy1q0WKcCyl, out usageEntry) ? usageEntry : new UsageCounter<T>.UsageEntry());
			}
			return result;
		}

		public UsageCounter<T>.UsageEntry method_1(T A66j0SL9SCJ87TW65LK)
		{
			Dictionary<T, UsageCounter<T>.UsageEntry> stats = this.Stats;
			UsageCounter<T>.UsageEntry result;
			lock (stats)
			{
				UsageCounter<T>.UsageEntry usageEntry;
				if (!this.Stats.TryGetValue(A66j0SL9SCJ87TW65LK, out usageEntry))
				{
					usageEntry = (this.Stats[A66j0SL9SCJ87TW65LK] = new UsageCounter<T>.UsageEntry());
				}
				UsageCounter<T>.UsageEntry usageEntry2 = usageEntry;
				int count = usageEntry2.Count;
				usageEntry2.Count = count + 1;
				usageEntry.LastUsed = DateTimeOffset.Now;
				result = usageEntry;
			}
			return result;
		}

		public UsageCounter<T>.UsageEntry method_2(T Y5nRpdLEBpmpt2hDwd6, TimeSpan timeSpan_0, bool bool_0 = false)
		{
			Dictionary<T, UsageCounter<T>.UsageEntry> stats = this.Stats;
			UsageCounter<T>.UsageEntry result;
			lock (stats)
			{
				UsageCounter<T>.UsageEntry usageEntry;
				if (!this.Stats.TryGetValue(Y5nRpdLEBpmpt2hDwd6, out usageEntry))
				{
					usageEntry = (this.Stats[Y5nRpdLEBpmpt2hDwd6] = new UsageCounter<T>.UsageEntry());
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

		public bool method_3(T Clhhl1LuI9i6P97xNYv)
		{
			Dictionary<T, UsageCounter<T>.UsageEntry> stats = this.Stats;
			bool result;
			lock (stats)
			{
				result = this.Stats.Remove(Clhhl1LuI9i6P97xNYv);
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
				Class13.NP5bWyNzLwONS();
				base..ctor();
			}
		}
	}
}
