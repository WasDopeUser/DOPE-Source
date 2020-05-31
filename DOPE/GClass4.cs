using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

[CollectionDataContract(Namespace = "")]
public class GClass4<p2Lmrea3T7dTWk4rRI> : ICollection<p2Lmrea3T7dTWk4rRI>, IEnumerable<p2Lmrea3T7dTWk4rRI>, IReadOnlyList<p2Lmrea3T7dTWk4rRI>, IReadOnlyCollection<p2Lmrea3T7dTWk4rRI>, IEnumerable, ICollection
{
	[CompilerGenerated]
	public void method_0(GDelegate0 gdelegate0_1)
	{
		GDelegate0 gdelegate = this.gdelegate0_0;
		GDelegate0 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GDelegate0 value = (GDelegate0)Delegate.Combine(gdelegate2, gdelegate0_1);
			gdelegate = Interlocked.CompareExchange<GDelegate0>(ref this.gdelegate0_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	[CompilerGenerated]
	public void method_1(GDelegate0 gdelegate0_1)
	{
		GDelegate0 gdelegate = this.gdelegate0_0;
		GDelegate0 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GDelegate0 value = (GDelegate0)Delegate.Remove(gdelegate2, gdelegate0_1);
			gdelegate = Interlocked.CompareExchange<GDelegate0>(ref this.gdelegate0_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	[CompilerGenerated]
	public Dispatcher method_2()
	{
		return this.dispatcher_0;
	}

	[CompilerGenerated]
	public void method_3(Dispatcher dispatcher_1)
	{
		this.dispatcher_0 = dispatcher_1;
	}

	public ObservableCollection<p2Lmrea3T7dTWk4rRI> ObsColl
	{
		get
		{
			return this.observableCollection_0;
		}
	}

	public GClass4()
	{
		Class13.NP5bWyNzLwONS();
		this.list_0 = new List<p2Lmrea3T7dTWk4rRI>();
		this.list_1 = new List<p2Lmrea3T7dTWk4rRI>();
		this.object_0 = new object();
		this.list_2 = new List<p2Lmrea3T7dTWk4rRI>();
		this.observableCollection_0 = new ObservableCollection<p2Lmrea3T7dTWk4rRI>();
		this.concurrentQueue_0 = new ConcurrentQueue<NotifyCollectionChangedEventArgs>();
		base..ctor();
		this.method_3(Application.Current.Dispatcher);
	}

	public bool method_4()
	{
		return this.bool_0;
	}

	public void method_5(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	public Tuple<List<p2Lmrea3T7dTWk4rRI>, List<p2Lmrea3T7dTWk4rRI>> SddmjfOcV()
	{
		object obj = this.object_0;
		Tuple<List<p2Lmrea3T7dTWk4rRI>, List<p2Lmrea3T7dTWk4rRI>> result;
		lock (obj)
		{
			result = new Tuple<List<p2Lmrea3T7dTWk4rRI>, List<p2Lmrea3T7dTWk4rRI>>(this.list_0, this.list_1);
			this.list_0 = new List<p2Lmrea3T7dTWk4rRI>();
			this.list_1 = new List<p2Lmrea3T7dTWk4rRI>();
		}
		return result;
	}

	public p2Lmrea3T7dTWk4rRI[] method_6()
	{
		object obj = this.object_0;
		p2Lmrea3T7dTWk4rRI[] result;
		lock (obj)
		{
			result = this.list_0.ToArray();
		}
		return result;
	}

	public p2Lmrea3T7dTWk4rRI[] method_7()
	{
		object obj = this.object_0;
		p2Lmrea3T7dTWk4rRI[] result;
		lock (obj)
		{
			result = this.list_1.ToArray();
		}
		return result;
	}

	private void method_8(NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_0)
	{
		this.concurrentQueue_0.Enqueue(notifyCollectionChangedEventArgs_0);
		this.method_2().BeginInvoke(new Action(this.method_9), Array.Empty<object>());
	}

	private void method_9()
	{
		if (!this.method_2().CheckAccess())
		{
			throw new Exception("Can't be called from any thread than the dispatcher one");
		}
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs;
		while (this.concurrentQueue_0.TryDequeue(out notifyCollectionChangedEventArgs))
		{
			switch (notifyCollectionChangedEventArgs.Action)
			{
			case NotifyCollectionChangedAction.Add:
			{
				int num = 0;
				using (IEnumerator enumerator = notifyCollectionChangedEventArgs.NewItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						p2Lmrea3T7dTWk4rRI item = (p2Lmrea3T7dTWk4rRI)((object)obj);
						this.ObsColl.Insert(notifyCollectionChangedEventArgs.NewStartingIndex + num, item);
						num++;
					}
					continue;
				}
				break;
			}
			case NotifyCollectionChangedAction.Remove:
				break;
			case NotifyCollectionChangedAction.Replace:
				goto IL_10B;
			case NotifyCollectionChangedAction.Move:
				this.ObsColl.Move(notifyCollectionChangedEventArgs.OldStartingIndex, notifyCollectionChangedEventArgs.NewStartingIndex);
				continue;
			case NotifyCollectionChangedAction.Reset:
				this.ObsColl.Clear();
				continue;
			default:
				throw new Exception("Unsupported NotifyCollectionChangedEventArgs.Action");
			}
			if (notifyCollectionChangedEventArgs.NewStartingIndex >= 0)
			{
				this.ObsColl.RemoveAt(notifyCollectionChangedEventArgs.NewStartingIndex);
				continue;
			}
			using (IEnumerator enumerator = notifyCollectionChangedEventArgs.OldItems.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj2 = enumerator.Current;
					p2Lmrea3T7dTWk4rRI item2 = (p2Lmrea3T7dTWk4rRI)((object)obj2);
					this.ObsColl.Remove(item2);
				}
				continue;
			}
			IL_10B:
			if (notifyCollectionChangedEventArgs.NewStartingIndex >= 0 && notifyCollectionChangedEventArgs.OldStartingIndex < 0)
			{
				throw new ArgumentException(string.Format("Replace action expect NewStartingIndex and OldStartingIndex as: 0 <= {0} <= {1}, {2} <= 0.", notifyCollectionChangedEventArgs.NewStartingIndex, this.ObsColl.Count, notifyCollectionChangedEventArgs.OldStartingIndex));
			}
			bool oldItems = notifyCollectionChangedEventArgs.OldItems != null;
			IList newItems = notifyCollectionChangedEventArgs.NewItems;
			if (!oldItems || newItems == null)
			{
				throw new ArgumentException("Both argument Old and New item should be IList in a replace action.");
			}
			this.ObsColl[notifyCollectionChangedEventArgs.NewStartingIndex] = (p2Lmrea3T7dTWk4rRI)((object)newItems[0]);
		}
	}

	public List<p2Lmrea3T7dTWk4rRI> method_10()
	{
		List<p2Lmrea3T7dTWk4rRI> result = null;
		object obj = this.object_0;
		lock (obj)
		{
			result = new List<p2Lmrea3T7dTWk4rRI>(this.list_2);
		}
		return result;
	}

	public void method_11(IList ilist_0)
	{
		GClass4<p2Lmrea3T7dTWk4rRI>.<>c__DisplayClass26_0 CS$<>8__locals1 = new GClass4<p2Lmrea3T7dTWk4rRI>.<>c__DisplayClass26_0();
		CS$<>8__locals1.list = ilist_0;
		object obj = this.object_0;
		lock (obj)
		{
			this.list_2.xluxvrnbt(new Action<p2Lmrea3T7dTWk4rRI>(CS$<>8__locals1.method_0));
		}
	}

	public virtual IEnumerator<p2Lmrea3T7dTWk4rRI> GetEnumerator()
	{
		return this.method_10().GetEnumerator();
	}

	public virtual IEnumerator<p2Lmrea3T7dTWk4rRI> GetBlockingEnumerator()
	{
		return new GClass1<p2Lmrea3T7dTWk4rRI>(this.list_2.GetEnumerator(), this.object_0);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.method_10().GetEnumerator();
	}

	public void method_12(p2Lmrea3T7dTWk4rRI eYECFKvHHu7TmI2lOp)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			this.list_2.Insert(0, eYECFKvHHu7TmI2lOp);
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, eYECFKvHHu7TmI2lOp, 0);
			this.method_8(notifyCollectionChangedEventArgs_);
		}
		this.method_16(notifyCollectionChangedEventArgs_);
	}

	public void Add(p2Lmrea3T7dTWk4rRI kIySZGBn1csppqIJCT)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			this.list_2.Add(kIySZGBn1csppqIJCT);
			if (this.bool_0)
			{
				this.list_0.Add(kIySZGBn1csppqIJCT);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, kIySZGBn1csppqIJCT, this.list_2.Count - 1);
			this.method_8(notifyCollectionChangedEventArgs_);
		}
		this.method_16(notifyCollectionChangedEventArgs_);
	}

	public void method_13(IList<p2Lmrea3T7dTWk4rRI> ilist_0)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			int count = this.list_2.Count;
			this.list_2.AddRange(ilist_0);
			if (this.bool_0)
			{
				this.list_0.AddRange(ilist_0);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, ilist_0 as IList, count);
			this.method_8(notifyCollectionChangedEventArgs_);
		}
		this.method_16(notifyCollectionChangedEventArgs_);
	}

	public bool method_14(p2Lmrea3T7dTWk4rRI BgX7U6K5bgqgoADA0y)
	{
		bool result = false;
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			result = this.list_2.Remove(BgX7U6K5bgqgoADA0y);
			if (this.bool_0)
			{
				this.list_0.Add(BgX7U6K5bgqgoADA0y);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, BgX7U6K5bgqgoADA0y);
			this.method_8(notifyCollectionChangedEventArgs_);
		}
		this.method_16(notifyCollectionChangedEventArgs_);
		return result;
	}

	public void method_15(p2Lmrea3T7dTWk4rRI gr2amEi3JoN5pwB7Mo, p2Lmrea3T7dTWk4rRI m1jaeroODBfja1vRlB)
	{
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = null;
		object obj = this.object_0;
		lock (obj)
		{
			int num = this.list_2.IndexOf(gr2amEi3JoN5pwB7Mo);
			if (num < 0 || num >= this.list_2.Count)
			{
				throw new ArgumentException("Invalid old value");
			}
			if (this.bool_0)
			{
				this.list_0.Add(m1jaeroODBfja1vRlB);
				this.list_1.Add(gr2amEi3JoN5pwB7Mo);
			}
			this.list_2[num] = m1jaeroODBfja1vRlB;
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, m1jaeroODBfja1vRlB, gr2amEi3JoN5pwB7Mo, num);
			this.method_8(notifyCollectionChangedEventArgs_);
		}
		this.method_16(notifyCollectionChangedEventArgs_);
	}

	private void method_16(NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_0)
	{
		if (this.gdelegate0_0 != null && notifyCollectionChangedEventArgs_0 != null)
		{
			this.gdelegate0_0(this, notifyCollectionChangedEventArgs_0);
		}
	}

	public p2Lmrea3T7dTWk4rRI method_17(int int_0)
	{
		return this.list_2[int_0];
	}

	public p2Lmrea3T7dTWk4rRI method_18(int int_0, p2Lmrea3T7dTWk4rRI wWYMZQ8Y6JWUmqTkUQ)
	{
		p2Lmrea3T7dTWk4rRI p2Lmrea3T7dTWk4rRI = this.list_2[int_0];
		if (this.bool_0)
		{
			this.list_0.Add(wWYMZQ8Y6JWUmqTkUQ);
			this.list_1.Add(p2Lmrea3T7dTWk4rRI);
		}
		this.list_2[int_0] = wWYMZQ8Y6JWUmqTkUQ;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, wWYMZQ8Y6JWUmqTkUQ, p2Lmrea3T7dTWk4rRI, int_0);
		this.method_8(notifyCollectionChangedEventArgs_);
		this.method_16(notifyCollectionChangedEventArgs_);
		return p2Lmrea3T7dTWk4rRI;
	}

	public void method_19(int int_0, p2Lmrea3T7dTWk4rRI LK0OB6eQwZBaTRwNgM)
	{
		if (this.bool_0)
		{
			this.list_0.Add(LK0OB6eQwZBaTRwNgM);
		}
		this.list_2.Insert(int_0, LK0OB6eQwZBaTRwNgM);
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, LK0OB6eQwZBaTRwNgM, int_0);
		this.method_8(notifyCollectionChangedEventArgs_);
		this.method_16(notifyCollectionChangedEventArgs_);
	}

	public p2Lmrea3T7dTWk4rRI method_20(int int_0)
	{
		p2Lmrea3T7dTWk4rRI p2Lmrea3T7dTWk4rRI = this.list_2[int_0];
		if (this.bool_0)
		{
			this.list_1.Add(p2Lmrea3T7dTWk4rRI);
		}
		this.list_2.RemoveAt(int_0);
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, p2Lmrea3T7dTWk4rRI, int_0);
		this.method_8(notifyCollectionChangedEventArgs_);
		this.method_16(notifyCollectionChangedEventArgs_);
		return p2Lmrea3T7dTWk4rRI;
	}

	public virtual void Clear()
	{
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = null;
		object obj = this.object_0;
		lock (obj)
		{
			if (this.bool_0)
			{
				this.list_1.AddRange(this.list_2);
			}
			this.list_2.Clear();
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset);
			this.method_8(notifyCollectionChangedEventArgs_);
		}
		this.method_16(notifyCollectionChangedEventArgs_);
	}

	public bool Contains(p2Lmrea3T7dTWk4rRI EggEGurpdZ6kUEiKdc)
	{
		object obj = this.object_0;
		bool result;
		lock (obj)
		{
			result = this.list_2.Contains(EggEGurpdZ6kUEiKdc);
		}
		return result;
	}

	public void CopyTo(p2Lmrea3T7dTWk4rRI[] array, int arrayIndex)
	{
		object obj = this.object_0;
		lock (obj)
		{
			this.list_2.CopyTo(array, arrayIndex);
		}
	}

	public int Count
	{
		get
		{
			object obj = this.object_0;
			int count;
			lock (obj)
			{
				count = this.list_2.Count;
			}
			return count;
		}
	}

	public void method_21(object object_1)
	{
		this.method_14((p2Lmrea3T7dTWk4rRI)((object)object_1));
	}

	public int method_22(object object_1)
	{
		return this.method_22((p2Lmrea3T7dTWk4rRI)((object)object_1));
	}

	public object SyncRoot
	{
		get
		{
			return this.object_0;
		}
	}

	public bool nEnpaOxOX(IEnumerable<p2Lmrea3T7dTWk4rRI> ienumerable_0)
	{
		if (this.Count != ienumerable_0.Count<p2Lmrea3T7dTWk4rRI>())
		{
			return false;
		}
		object obj = this.object_0;
		lock (obj)
		{
			IEnumerator<p2Lmrea3T7dTWk4rRI> enumerator = this.GetEnumerator();
			enumerator.Reset();
			foreach (p2Lmrea3T7dTWk4rRI p2Lmrea3T7dTWk4rRI in ienumerable_0)
			{
				enumerator.MoveNext();
				p2Lmrea3T7dTWk4rRI p2Lmrea3T7dTWk4rRI2 = enumerator.Current;
				if (p2Lmrea3T7dTWk4rRI2.Equals(p2Lmrea3T7dTWk4rRI))
				{
					return false;
				}
			}
			GClass2.smethod_0(enumerator);
		}
		return true;
	}

	private void IkwwTeOcd()
	{
		if (!this.nEnpaOxOX(this.ObsColl))
		{
			this.method_23();
		}
	}

	private void method_23()
	{
		object obj = this.object_0;
		lock (obj)
		{
			IEnumerator enumerator = this.list_2.GetEnumerator();
			IEnumerator enumerator2 = this.ObsColl.GetEnumerator();
			enumerator.Reset();
			enumerator2.Reset();
			bool flag2 = enumerator.MoveNext();
			bool flag3 = enumerator2.MoveNext();
			while (flag2 || flag3)
			{
				if (flag2)
				{
					flag2 = enumerator.MoveNext();
				}
				if (flag3)
				{
					flag3 = enumerator2.MoveNext();
				}
			}
			GClass2.smethod_0(enumerator);
			GClass2.smethod_0(enumerator2);
		}
	}

	[OnSerializing]
	private void method_24(StreamingContext streamingContext_0)
	{
		Monitor.Enter(this.object_0);
	}

	[OnSerialized]
	private void method_25(StreamingContext streamingContext_0)
	{
		Monitor.Exit(this.object_0);
	}

	[OnDeserializing]
	private void method_26(StreamingContext streamingContext_0)
	{
	}

	[OnDeserialized]
	private void method_27(StreamingContext streamingContext_0)
	{
	}

	public p2Lmrea3T7dTWk4rRI this[int index]
	{
		get
		{
			return this.list_2[index];
		}
	}

	public void method_28(p2Lmrea3T7dTWk4rRI NZc6hFwK82c3w6rh2u)
	{
		this.Add(NZc6hFwK82c3w6rh2u);
	}

	public bool HoBkojLxg(out p2Lmrea3T7dTWk4rRI gparam_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			int count = this.list_2.Count;
			if (count > 0)
			{
				gparam_0 = this.method_20(count - 1);
				return true;
			}
		}
		gparam_0 = default(p2Lmrea3T7dTWk4rRI);
		return false;
	}

	public void method_29(p2Lmrea3T7dTWk4rRI QSukQutr8mM97kdMxD)
	{
		this.Add(QSukQutr8mM97kdMxD);
	}

	public bool method_30(out p2Lmrea3T7dTWk4rRI gparam_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			if (this.list_2.Count > 0)
			{
				gparam_0 = this.method_20(0);
				return true;
			}
		}
		gparam_0 = default(p2Lmrea3T7dTWk4rRI);
		return false;
	}

	public bool IsReadOnly
	{
		get
		{
			return false;
		}
	}

	bool ICollection<p2Lmrea3T7dTWk4rRI>.Remove(p2Lmrea3T7dTWk4rRI wUy7Z7LRa8TfEmjn1D)
	{
		return this.method_14(wUy7Z7LRa8TfEmjn1D);
	}

	public void CopyTo(Array array, int index)
	{
		object obj = this.object_0;
		lock (obj)
		{
			foreach (p2Lmrea3T7dTWk4rRI p2Lmrea3T7dTWk4rRI in this.list_2)
			{
				array.SetValue(p2Lmrea3T7dTWk4rRI, index++);
			}
		}
	}

	public bool IsSynchronized
	{
		get
		{
			return this.method_2().CheckAccess();
		}
	}

	private List<p2Lmrea3T7dTWk4rRI> list_0;

	private List<p2Lmrea3T7dTWk4rRI> list_1;

	private bool bool_0;

	private readonly object object_0;

	protected List<p2Lmrea3T7dTWk4rRI> list_2;

	private readonly ObservableCollection<p2Lmrea3T7dTWk4rRI> observableCollection_0;

	private readonly ConcurrentQueue<NotifyCollectionChangedEventArgs> concurrentQueue_0;

	[CompilerGenerated]
	private GDelegate0 gdelegate0_0;

	[CompilerGenerated]
	private Dispatcher dispatcher_0;
}
