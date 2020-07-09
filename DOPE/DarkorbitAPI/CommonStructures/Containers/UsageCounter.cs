using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures.Containers
{
	public class UsageCounter<T>
	{
		public Dictionary<T, UsageCounter<T>.UsageEntry> Stats { get; private set; }

		public UsageCounter()
		{
			Class13.lOBHd9Nzn7x2T();
			this.Stats = new Dictionary<T, UsageCounter<T>.UsageEntry>();
			base..ctor();
		}

		public UsageCounter<T>.UsageEntry method_0(T boMMbpQlIhIBXqlMOYh)
		{
			Dictionary<T, UsageCounter<T>.UsageEntry> stats = this.Stats;
			UsageCounter<T>.UsageEntry result;
			lock (stats)
			{
				UsageCounter<T>.UsageEntry usageEntry;
				result = (this.Stats.TryGetValue(boMMbpQlIhIBXqlMOYh, out usageEntry) ? usageEntry : new UsageCounter<T>.UsageEntry());
			}
			return result;
		}

		public UsageCounter<T>.UsageEntry method_1(T pbbFYjQ2o137ZaFhlSy)
		{
			Dictionary<T, UsageCounter<T>.UsageEntry> stats = this.Stats;
			UsageCounter<T>.UsageEntry result;
			lock (stats)
			{
				UsageCounter<T>.UsageEntry usageEntry;
				if (!this.Stats.TryGetValue(pbbFYjQ2o137ZaFhlSy, out usageEntry))
				{
					usageEntry = (this.Stats[pbbFYjQ2o137ZaFhlSy] = new UsageCounter<T>.UsageEntry());
				}
				UsageCounter<T>.UsageEntry usageEntry2 = usageEntry;
				int count = usageEntry2.Count;
				usageEntry2.Count = count + 1;
				usageEntry.LastUsed = DateTimeOffset.Now;
				result = usageEntry;
			}
			return result;
		}

		public UsageCounter<T>.UsageEntry method_2(T WcuMmdQpdBEtdVKsk3M, TimeSpan timeSpan_0, bool bool_0 = false)
		{
			Dictionary<T, UsageCounter<T>.UsageEntry> stats = this.Stats;
			UsageCounter<T>.UsageEntry result;
			lock (stats)
			{
				UsageCounter<T>.UsageEntry usageEntry;
				if (!this.Stats.TryGetValue(WcuMmdQpdBEtdVKsk3M, out usageEntry))
				{
					usageEntry = (this.Stats[WcuMmdQpdBEtdVKsk3M] = new UsageCounter<T>.UsageEntry());
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

		public bool method_3(T aIGGq1QIYDcnGUWlRNj)
		{
			Dictionary<T, UsageCounter<T>.UsageEntry> stats = this.Stats;
			bool result;
			lock (stats)
			{
				result = this.Stats.Remove(aIGGq1QIYDcnGUWlRNj);
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
				Class13.lOBHd9Nzn7x2T();
				base..ctor();
			}
		}
	}
}
