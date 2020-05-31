using System;
using System.Collections.Generic;
using DarkorbitAPI.Structures;

namespace DarkorbitAPI.CommonStructures.Containers
{
	public class EnemyLocatorResultCollection
	{
		public EnemyLocatorResultCollection()
		{
			Class13.NP5bWyNzLwONS();
			this.Entries = new Dictionary<int, EnemyLocatorResultCollection.Entry>();
			base..ctor();
		}

		public void method_0(HeroPet.EnemyLocatorResult enemyLocatorResult_0)
		{
			Dictionary<int, EnemyLocatorResultCollection.Entry> entries = this.Entries;
			lock (entries)
			{
				EnemyLocatorResultCollection.Entry entry;
				if (!this.Entries.TryGetValue(enemyLocatorResult_0.Id, out entry))
				{
					Dictionary<int, EnemyLocatorResultCollection.Entry> entries2 = this.Entries;
					int id = enemyLocatorResult_0.Id;
					EnemyLocatorResultCollection.Entry entry2 = new EnemyLocatorResultCollection.Entry();
					entry2.Id = enemyLocatorResult_0.Id;
					entry = entry2;
					entries2[id] = entry2;
				}
				entry.method_0(enemyLocatorResult_0);
			}
		}

		public bool method_1(int int_0)
		{
			EnemyLocatorResultCollection.Entry entry;
			return this.Entries.TryGetValue(int_0, out entry) && entry.WasLastFound;
		}

		public DateTimeOffset method_2(int int_0)
		{
			EnemyLocatorResultCollection.Entry entry;
			if (!this.Entries.TryGetValue(int_0, out entry))
			{
				return default(DateTimeOffset);
			}
			return entry.LastTick;
		}

		public readonly Dictionary<int, EnemyLocatorResultCollection.Entry> Entries;

		public class Entry
		{
			public int Id { get; set; }

			public DateTimeOffset LastTick { get; set; }

			public DateTimeOffset LastFound { get; set; }

			public bool WasLastFound { get; set; }

			public void method_0(HeroPet.EnemyLocatorResult enemyLocatorResult_0)
			{
				this.LastTick = DateTimeOffset.Now;
				if (enemyLocatorResult_0.Found)
				{
					this.LastFound = this.LastTick;
				}
				this.WasLastFound = enemyLocatorResult_0.Found;
			}

			public Entry()
			{
				Class13.NP5bWyNzLwONS();
				base..ctor();
			}
		}
	}
}
