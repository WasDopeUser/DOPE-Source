using System;
using System.Collections.Generic;

namespace DOPE.Common.Structures
{
	public class CachedDictionary<TKey, TValue>
	{
		public int CacheTime { get; }

		public CachedDictionary(int time)
		{
			this.CacheTime = time;
		}

		public void Put(TKey key, TValue value)
		{
			this.Map[key] = new KeyValuePair<DateTimeOffset, TValue>(DateTimeOffset.Now.AddMilliseconds((double)this.CacheTime), value);
		}

		public TValue GetOrDefault(TKey key)
		{
			KeyValuePair<DateTimeOffset, TValue> keyValuePair;
			if (!this.Map.TryGetValue(key, out keyValuePair))
			{
				return default(TValue);
			}
			if (!(keyValuePair.Key > DateTimeOffset.Now))
			{
				return default(TValue);
			}
			return keyValuePair.Value;
		}

		public TValue GetOrFallback(TKey key, TValue fallback)
		{
			KeyValuePair<DateTimeOffset, TValue> keyValuePair;
			if (!this.Map.TryGetValue(key, out keyValuePair))
			{
				return fallback;
			}
			if (!(keyValuePair.Key > DateTimeOffset.Now))
			{
				return fallback;
			}
			return keyValuePair.Value;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			KeyValuePair<DateTimeOffset, TValue> keyValuePair;
			bool result = this.Map.TryGetValue(key, out keyValuePair) && keyValuePair.Key > DateTimeOffset.Now;
			value = keyValuePair.Value;
			return result;
		}

		public readonly Dictionary<TKey, KeyValuePair<DateTimeOffset, TValue>> Map = new Dictionary<TKey, KeyValuePair<DateTimeOffset, TValue>>();
	}
}
