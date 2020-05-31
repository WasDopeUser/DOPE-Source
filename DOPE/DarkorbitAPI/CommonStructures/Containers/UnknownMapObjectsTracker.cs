using System;
using System.Collections.Generic;
using System.Numerics;

namespace DarkorbitAPI.CommonStructures.Containers
{
	public class UnknownMapObjectsTracker<T>
	{
		public HashSet<UnknownMapObjectsTracker<T>.ObjectEntry<T>> Objects { get; protected set; }

		public void method_0()
		{
			HashSet<UnknownMapObjectsTracker<T>.ObjectEntry<T>> objects = this.Objects;
			lock (objects)
			{
				this.Objects.RemoveWhere(new Predicate<UnknownMapObjectsTracker<T>.ObjectEntry<T>>(UnknownMapObjectsTracker<T>.<>c.<>9.method_0));
			}
		}

		public UnknownMapObjectsTracker<T>.ObjectEntry<T> method_1(Vector2 vector2_0, int int_0 = 1700)
		{
			HashSet<UnknownMapObjectsTracker<T>.ObjectEntry<T>> objects = this.Objects;
			UnknownMapObjectsTracker<T>.ObjectEntry<T> result;
			lock (objects)
			{
				UnknownMapObjectsTracker<T>.ObjectEntry<T> objectEntry;
				if (this.method_2(vector2_0, out objectEntry, int_0))
				{
					objectEntry.method_1(vector2_0);
					result = objectEntry;
				}
				else
				{
					UnknownMapObjectsTracker<T>.ObjectEntry<T> objectEntry2 = new UnknownMapObjectsTracker<T>.ObjectEntry<T>
					{
						Position = vector2_0
					};
					this.Objects.Add(objectEntry2);
					result = objectEntry2;
				}
			}
			return result;
		}

		public bool method_2(Vector2 vector2_0, out UnknownMapObjectsTracker<T>.ObjectEntry<T> objectEntry_0, int int_0 = 1700)
		{
			HashSet<UnknownMapObjectsTracker<T>.ObjectEntry<T>> objects = this.Objects;
			bool result;
			lock (objects)
			{
				float num = float.MaxValue;
				objectEntry_0 = null;
				foreach (UnknownMapObjectsTracker<T>.ObjectEntry<T> objectEntry in this.Objects)
				{
					float num2;
					if (objectEntry.method_0(vector2_0, out num2, (float)int_0) && num2 < num)
					{
						num = num2;
						objectEntry_0 = objectEntry;
					}
				}
				result = (objectEntry_0 != null);
			}
			return result;
		}

		public void Clear()
		{
			HashSet<UnknownMapObjectsTracker<T>.ObjectEntry<T>> objects = this.Objects;
			lock (objects)
			{
				this.Objects.Clear();
			}
		}

		public UnknownMapObjectsTracker()
		{
			Class13.NP5bWyNzLwONS();
			base..ctor();
			this.Objects = new HashSet<UnknownMapObjectsTracker<T>.ObjectEntry<T>>();
		}

		public class ObjectEntry<TData>
		{
			public Vector2 Position { get; set; }

			public DateTimeOffset LastUpdated { get; set; }

			public DateTimeOffset Created { get; set; }

			public float Speed
			{
				get
				{
					return 300f;
				}
			}

			public int Ttl
			{
				get
				{
					return 40000;
				}
			}

			public TData Data { get; protected set; }

			public ObjectEntry()
			{
				Class13.NP5bWyNzLwONS();
				base..ctor();
				this.Created = DateTimeOffset.Now;
				this.LastUpdated = this.Created;
			}

			public override int GetHashCode()
			{
				return this.Position.GetHashCode();
			}

			public override bool Equals(object obj)
			{
				UnknownMapObjectsTracker<T>.ObjectEntry<TData> objectEntry = obj as UnknownMapObjectsTracker<T>.ObjectEntry<TData>;
				return objectEntry != null && objectEntry.Position == this.Position;
			}

			public bool method_0(Vector2 vector2_0, out float float_0, float float_1)
			{
				float_0 = Vector2.Distance(vector2_0, this.Position);
				double totalMilliseconds = (DateTimeOffset.Now - this.LastUpdated).TotalMilliseconds;
				if (totalMilliseconds > (double)this.Ttl)
				{
					return false;
				}
				double val = totalMilliseconds * (double)this.Speed / 1000.0 + 200.0;
				return (double)float_0 <= Math.Min(val, (double)float_1);
			}

			public void method_1(Vector2 vector2_0)
			{
				this.LastUpdated = DateTimeOffset.Now;
				this.Position = vector2_0;
			}
		}
	}
}
