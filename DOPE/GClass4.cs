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
public class GClass4<BuWIYp6s752jjOVqba> : ICollection<BuWIYp6s752jjOVqba>, IEnumerable<BuWIYp6s752jjOVqba>, IReadOnlyList<BuWIYp6s752jjOVqba>, IReadOnlyCollection<BuWIYp6s752jjOVqba>, IEnumerable, ICollection
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

	public ObservableCollection<BuWIYp6s752jjOVqba> ObsColl
	{
		get
		{
			return this.gQgbdytcw;
		}
	}

	public GClass4()
	{
		Class13.lOBHd9Nzn7x2T();
		this.list_0 = new List<BuWIYp6s752jjOVqba>();
		this.WlBitMfaq = new List<BuWIYp6s752jjOVqba>();
		this.object_0 = new object();
		this.list_1 = new List<BuWIYp6s752jjOVqba>();
		this.gQgbdytcw = new ObservableCollection<BuWIYp6s752jjOVqba>();
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

	public Tuple<List<BuWIYp6s752jjOVqba>, List<BuWIYp6s752jjOVqba>> method_6()
	{
		object obj = this.object_0;
		Tuple<List<BuWIYp6s752jjOVqba>, List<BuWIYp6s752jjOVqba>> result;
		lock (obj)
		{
			result = new Tuple<List<BuWIYp6s752jjOVqba>, List<BuWIYp6s752jjOVqba>>(this.list_0, this.WlBitMfaq);
			this.list_0 = new List<BuWIYp6s752jjOVqba>();
			this.WlBitMfaq = new List<BuWIYp6s752jjOVqba>();
		}
		return result;
	}

	public BuWIYp6s752jjOVqba[] method_7()
	{
		object obj = this.object_0;
		BuWIYp6s752jjOVqba[] result;
		lock (obj)
		{
			result = this.list_0.ToArray();
		}
		return result;
	}

	public BuWIYp6s752jjOVqba[] method_8()
	{
		object obj = this.object_0;
		BuWIYp6s752jjOVqba[] result;
		lock (obj)
		{
			result = this.WlBitMfaq.ToArray();
		}
		return result;
	}

	private void method_9(NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_0)
	{
		this.concurrentQueue_0.Enqueue(notifyCollectionChangedEventArgs_0);
		this.method_2().BeginInvoke(new Action(this.method_10), Array.Empty<object>());
	}

	private void method_10()
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
						BuWIYp6s752jjOVqba item = (BuWIYp6s752jjOVqba)((object)obj);
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
					BuWIYp6s752jjOVqba item2 = (BuWIYp6s752jjOVqba)((object)obj2);
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
			this.ObsColl[notifyCollectionChangedEventArgs.NewStartingIndex] = (BuWIYp6s752jjOVqba)((object)newItems[0]);
		}
	}

	public List<BuWIYp6s752jjOVqba> method_11()
	{
		List<BuWIYp6s752jjOVqba> result = null;
		object obj = this.object_0;
		lock (obj)
		{
			result = new List<BuWIYp6s752jjOVqba>(this.list_1);
		}
		return result;
	}

	public void method_12(IList ilist_0)
	{
		GClass4<BuWIYp6s752jjOVqba>.<>c__DisplayClass26_0 CS$<>8__locals1 = new GClass4<BuWIYp6s752jjOVqba>.<>c__DisplayClass26_0();
		CS$<>8__locals1.list = ilist_0;
		object obj = this.object_0;
		lock (obj)
		{
			this.list_1.smethod_4(new Action<BuWIYp6s752jjOVqba>(CS$<>8__locals1.method_0));
		}
	}

	public virtual IEnumerator<BuWIYp6s752jjOVqba> GetEnumerator()
	{
		return this.method_11().GetEnumerator();
	}

	public virtual IEnumerator<BuWIYp6s752jjOVqba> GetBlockingEnumerator()
	{
		return new GClass1<BuWIYp6s752jjOVqba>(this.list_1.GetEnumerator(), this.object_0);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.method_11().GetEnumerator();
	}

	public void WkiOiloIt(BuWIYp6s752jjOVqba kqWYRS7IxhNeu282b6)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			this.list_1.Insert(0, kqWYRS7IxhNeu282b6);
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, kqWYRS7IxhNeu282b6, 0);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_16(notifyCollectionChangedEventArgs_);
	}

	public void Add(BuWIYp6s752jjOVqba klvftHVbOEg7EjSRtF)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			this.list_1.Add(klvftHVbOEg7EjSRtF);
			if (this.bool_0)
			{
				this.list_0.Add(klvftHVbOEg7EjSRtF);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, klvftHVbOEg7EjSRtF, this.list_1.Count - 1);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_16(notifyCollectionChangedEventArgs_);
	}

	public void method_13(IList<BuWIYp6s752jjOVqba> ilist_0)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			int count = this.list_1.Count;
			this.list_1.AddRange(ilist_0);
			if (this.bool_0)
			{
				this.list_0.AddRange(ilist_0);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, ilist_0 as IList, count);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_16(notifyCollectionChangedEventArgs_);
	}

	public bool method_14(BuWIYp6s752jjOVqba NqFpWNNYOJnn72sRmc)
	{
		bool result = false;
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			result = this.list_1.Remove(NqFpWNNYOJnn72sRmc);
			if (this.bool_0)
			{
				this.list_0.Add(NqFpWNNYOJnn72sRmc);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, NqFpWNNYOJnn72sRmc);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_16(notifyCollectionChangedEventArgs_);
		return result;
	}

	public void method_15(BuWIYp6s752jjOVqba HJvqFNBXZRamIqndFw, BuWIYp6s752jjOVqba WEEC6AkBsU9ri7pQ74)
	{
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = null;
		object obj = this.object_0;
		lock (obj)
		{
			int num = this.list_1.IndexOf(HJvqFNBXZRamIqndFw);
			if (num < 0 || num >= this.list_1.Count)
			{
				throw new ArgumentException("Invalid old value");
			}
			if (this.bool_0)
			{
				this.list_0.Add(WEEC6AkBsU9ri7pQ74);
				this.WlBitMfaq.Add(HJvqFNBXZRamIqndFw);
			}
			this.list_1[num] = WEEC6AkBsU9ri7pQ74;
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, WEEC6AkBsU9ri7pQ74, HJvqFNBXZRamIqndFw, num);
			this.method_9(notifyCollectionChangedEventArgs_);
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

	public BuWIYp6s752jjOVqba method_17(int int_0)
	{
		return this.list_1[int_0];
	}

	public BuWIYp6s752jjOVqba method_18(int int_0, BuWIYp6s752jjOVqba iHRUaDRKagCYXcJeZJ)
	{
		BuWIYp6s752jjOVqba buWIYp6s752jjOVqba = this.list_1[int_0];
		if (this.bool_0)
		{
			this.list_0.Add(iHRUaDRKagCYXcJeZJ);
			this.WlBitMfaq.Add(buWIYp6s752jjOVqba);
		}
		this.list_1[int_0] = iHRUaDRKagCYXcJeZJ;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, iHRUaDRKagCYXcJeZJ, buWIYp6s752jjOVqba, int_0);
		this.method_9(notifyCollectionChangedEventArgs_);
		this.method_16(notifyCollectionChangedEventArgs_);
		return buWIYp6s752jjOVqba;
	}

	public void method_19(int int_0, BuWIYp6s752jjOVqba arnP5qLQHDvbYYYvOc)
	{
		if (this.bool_0)
		{
			this.list_0.Add(arnP5qLQHDvbYYYvOc);
		}
		this.list_1.Insert(int_0, arnP5qLQHDvbYYYvOc);
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, arnP5qLQHDvbYYYvOc, int_0);
		this.method_9(notifyCollectionChangedEventArgs_);
		this.method_16(notifyCollectionChangedEventArgs_);
	}

	public BuWIYp6s752jjOVqba method_20(int int_0)
	{
		BuWIYp6s752jjOVqba buWIYp6s752jjOVqba = this.list_1[int_0];
		if (this.bool_0)
		{
			this.WlBitMfaq.Add(buWIYp6s752jjOVqba);
		}
		this.list_1.RemoveAt(int_0);
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, buWIYp6s752jjOVqba, int_0);
		this.method_9(notifyCollectionChangedEventArgs_);
		this.method_16(notifyCollectionChangedEventArgs_);
		return buWIYp6s752jjOVqba;
	}

	public virtual void Clear()
	{
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = null;
		object obj = this.object_0;
		lock (obj)
		{
			if (this.bool_0)
			{
				this.WlBitMfaq.AddRange(this.list_1);
			}
			this.list_1.Clear();
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_16(notifyCollectionChangedEventArgs_);
	}

	public bool Contains(BuWIYp6s752jjOVqba zyR28T8984r7IcTbfg)
	{
		object obj = this.object_0;
		bool result;
		lock (obj)
		{
			result = this.list_1.Contains(zyR28T8984r7IcTbfg);
		}
		return result;
	}

	public void CopyTo(BuWIYp6s752jjOVqba[] array, int arrayIndex)
	{
		object obj = this.object_0;
		lock (obj)
		{
			this.list_1.CopyTo(array, arrayIndex);
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
				count = this.list_1.Count;
			}
			return count;
		}
	}

	public void method_21(object object_1)
	{
		this.method_14((BuWIYp6s752jjOVqba)((object)object_1));
	}

	public int method_22(object object_1)
	{
		return this.method_22((BuWIYp6s752jjOVqba)((object)object_1));
	}

	public object SyncRoot
	{
		get
		{
			return this.object_0;
		}
	}

	public bool method_23(IEnumerable<BuWIYp6s752jjOVqba> ienumerable_0)
	{
		if (this.Count != ienumerable_0.Count<BuWIYp6s752jjOVqba>())
		{
			return false;
		}
		object obj = this.object_0;
		lock (obj)
		{
			IEnumerator<BuWIYp6s752jjOVqba> enumerator = this.GetEnumerator();
			enumerator.Reset();
			foreach (BuWIYp6s752jjOVqba buWIYp6s752jjOVqba in ienumerable_0)
			{
				enumerator.MoveNext();
				BuWIYp6s752jjOVqba buWIYp6s752jjOVqba2 = enumerator.Current;
				if (buWIYp6s752jjOVqba2.Equals(buWIYp6s752jjOVqba))
				{
					return false;
				}
			}
			GClass2.smethod_0(enumerator);
		}
		return true;
	}

	private void method_24()
	{
		if (!this.method_23(this.ObsColl))
		{
			this.method_25();
		}
	}

	private void method_25()
	{
		object obj = this.object_0;
		lock (obj)
		{
			IEnumerator enumerator = this.list_1.GetEnumerator();
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
	private void method_26(StreamingContext streamingContext_0)
	{
		Monitor.Enter(this.object_0);
	}

	[OnSerialized]
	private void method_27(StreamingContext streamingContext_0)
	{
		Monitor.Exit(this.object_0);
	}

	[OnDeserializing]
	private void method_28(StreamingContext streamingContext_0)
	{
	}

	[OnDeserialized]
	private void method_29(StreamingContext streamingContext_0)
	{
	}

	public BuWIYp6s752jjOVqba this[int index]
	{
		get
		{
			return this.list_1[index];
		}
	}

	public void method_30(BuWIYp6s752jjOVqba uU5lwK42wHNJqVfIK5)
	{
		this.Add(uU5lwK42wHNJqVfIK5);
	}

	public bool method_31(out BuWIYp6s752jjOVqba gparam_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			int count = this.list_1.Count;
			if (count > 0)
			{
				gparam_0 = this.method_20(count - 1);
				return true;
			}
		}
		gparam_0 = default(BuWIYp6s752jjOVqba);
		return false;
	}

	public void method_32(BuWIYp6s752jjOVqba V7aij6iuruJnFmxP5j)
	{
		this.Add(V7aij6iuruJnFmxP5j);
	}

	public bool method_33(out BuWIYp6s752jjOVqba gparam_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			if (this.list_1.Count > 0)
			{
				gparam_0 = this.method_20(0);
				return true;
			}
		}
		gparam_0 = default(BuWIYp6s752jjOVqba);
		return false;
	}

	public bool IsReadOnly
	{
		get
		{
			return false;
		}
	}

	bool ICollection<BuWIYp6s752jjOVqba>.Remove(BuWIYp6s752jjOVqba qrfhFjTf1DxINAalJL)
	{
		return this.method_14(qrfhFjTf1DxINAalJL);
	}

	public void CopyTo(Array array, int index)
	{
		object obj = this.object_0;
		lock (obj)
		{
			foreach (BuWIYp6s752jjOVqba buWIYp6s752jjOVqba in this.list_1)
			{
				array.SetValue(buWIYp6s752jjOVqba, index++);
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

	private List<BuWIYp6s752jjOVqba> list_0;

	private List<BuWIYp6s752jjOVqba> WlBitMfaq;

	private bool bool_0;

	private readonly object object_0;

	protected List<BuWIYp6s752jjOVqba> list_1;

	private readonly ObservableCollection<BuWIYp6s752jjOVqba> gQgbdytcw;

	private readonly ConcurrentQueue<NotifyCollectionChangedEventArgs> concurrentQueue_0;

	[CompilerGenerated]
	private GDelegate0 gdelegate0_0;

	[CompilerGenerated]
	private Dispatcher dispatcher_0;
}
