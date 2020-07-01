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
public class GClass4<BTPJThMZ4kqmmy0pbe> : ICollection<BTPJThMZ4kqmmy0pbe>, IEnumerable<BTPJThMZ4kqmmy0pbe>, IReadOnlyList<BTPJThMZ4kqmmy0pbe>, IReadOnlyCollection<BTPJThMZ4kqmmy0pbe>, IEnumerable, ICollection
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
	public void GddkAtbBy(GDelegate0 gdelegate0_1)
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
	public Dispatcher method_1()
	{
		return this.dispatcher_0;
	}

	[CompilerGenerated]
	public void method_2(Dispatcher dispatcher_1)
	{
		this.dispatcher_0 = dispatcher_1;
	}

	public ObservableCollection<BTPJThMZ4kqmmy0pbe> ObsColl
	{
		get
		{
			return this.observableCollection_0;
		}
	}

	public GClass4()
	{
		Class13.F93tSdiz1aNIA();
		this.list_0 = new List<BTPJThMZ4kqmmy0pbe>();
		this.list_1 = new List<BTPJThMZ4kqmmy0pbe>();
		this.object_0 = new object();
		this.list_2 = new List<BTPJThMZ4kqmmy0pbe>();
		this.observableCollection_0 = new ObservableCollection<BTPJThMZ4kqmmy0pbe>();
		this.concurrentQueue_0 = new ConcurrentQueue<NotifyCollectionChangedEventArgs>();
		base..ctor();
		this.method_2(Application.Current.Dispatcher);
	}

	public bool method_3()
	{
		return this.bool_0;
	}

	public void method_4(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	public Tuple<List<BTPJThMZ4kqmmy0pbe>, List<BTPJThMZ4kqmmy0pbe>> method_5()
	{
		object obj = this.object_0;
		Tuple<List<BTPJThMZ4kqmmy0pbe>, List<BTPJThMZ4kqmmy0pbe>> result;
		lock (obj)
		{
			result = new Tuple<List<BTPJThMZ4kqmmy0pbe>, List<BTPJThMZ4kqmmy0pbe>>(this.list_0, this.list_1);
			this.list_0 = new List<BTPJThMZ4kqmmy0pbe>();
			this.list_1 = new List<BTPJThMZ4kqmmy0pbe>();
		}
		return result;
	}

	public BTPJThMZ4kqmmy0pbe[] kjemcMmjB()
	{
		object obj = this.object_0;
		BTPJThMZ4kqmmy0pbe[] result;
		lock (obj)
		{
			result = this.list_0.ToArray();
		}
		return result;
	}

	public BTPJThMZ4kqmmy0pbe[] method_6()
	{
		object obj = this.object_0;
		BTPJThMZ4kqmmy0pbe[] result;
		lock (obj)
		{
			result = this.list_1.ToArray();
		}
		return result;
	}

	private void method_7(NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_0)
	{
		this.concurrentQueue_0.Enqueue(notifyCollectionChangedEventArgs_0);
		this.method_1().BeginInvoke(new Action(this.method_8), Array.Empty<object>());
	}

	private void method_8()
	{
		if (!this.method_1().CheckAccess())
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
						BTPJThMZ4kqmmy0pbe item = (BTPJThMZ4kqmmy0pbe)((object)obj);
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
					BTPJThMZ4kqmmy0pbe item2 = (BTPJThMZ4kqmmy0pbe)((object)obj2);
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
			this.ObsColl[notifyCollectionChangedEventArgs.NewStartingIndex] = (BTPJThMZ4kqmmy0pbe)((object)newItems[0]);
		}
	}

	public List<BTPJThMZ4kqmmy0pbe> method_9()
	{
		List<BTPJThMZ4kqmmy0pbe> result = null;
		object obj = this.object_0;
		lock (obj)
		{
			result = new List<BTPJThMZ4kqmmy0pbe>(this.list_2);
		}
		return result;
	}

	public void method_10(IList ilist_0)
	{
		GClass4<BTPJThMZ4kqmmy0pbe>.<>c__DisplayClass26_0 CS$<>8__locals1 = new GClass4<BTPJThMZ4kqmmy0pbe>.<>c__DisplayClass26_0();
		CS$<>8__locals1.list = ilist_0;
		object obj = this.object_0;
		lock (obj)
		{
			this.list_2.smethod_4(new Action<BTPJThMZ4kqmmy0pbe>(CS$<>8__locals1.method_0));
		}
	}

	public virtual IEnumerator<BTPJThMZ4kqmmy0pbe> GetEnumerator()
	{
		return this.method_9().GetEnumerator();
	}

	public virtual IEnumerator<BTPJThMZ4kqmmy0pbe> GetBlockingEnumerator()
	{
		return new GClass1<BTPJThMZ4kqmmy0pbe>(this.list_2.GetEnumerator(), this.object_0);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.method_9().GetEnumerator();
	}

	public void method_11(BTPJThMZ4kqmmy0pbe GddAtbLByqJmSO1YEi)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			this.list_2.Insert(0, GddAtbLByqJmSO1YEi);
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, GddAtbLByqJmSO1YEi, 0);
			this.method_7(notifyCollectionChangedEventArgs_);
		}
		this.method_15(notifyCollectionChangedEventArgs_);
	}

	public void Add(BTPJThMZ4kqmmy0pbe RXs1BwTfbM3ySvwbyS)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			this.list_2.Add(RXs1BwTfbM3ySvwbyS);
			if (this.bool_0)
			{
				this.list_0.Add(RXs1BwTfbM3ySvwbyS);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, RXs1BwTfbM3ySvwbyS, this.list_2.Count - 1);
			this.method_7(notifyCollectionChangedEventArgs_);
		}
		this.method_15(notifyCollectionChangedEventArgs_);
	}

	public void method_12(IList<BTPJThMZ4kqmmy0pbe> ilist_0)
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
			this.method_7(notifyCollectionChangedEventArgs_);
		}
		this.method_15(notifyCollectionChangedEventArgs_);
	}

	public bool method_13(BTPJThMZ4kqmmy0pbe nQu3afj5kTlqPwUP4c)
	{
		bool result = false;
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			result = this.list_2.Remove(nQu3afj5kTlqPwUP4c);
			if (this.bool_0)
			{
				this.list_0.Add(nQu3afj5kTlqPwUP4c);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, nQu3afj5kTlqPwUP4c);
			this.method_7(notifyCollectionChangedEventArgs_);
		}
		this.method_15(notifyCollectionChangedEventArgs_);
		return result;
	}

	public void method_14(BTPJThMZ4kqmmy0pbe z1ykPmxRMH7ivuBQKJ, BTPJThMZ4kqmmy0pbe r3lb35AaVtYRlOIMVV)
	{
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = null;
		object obj = this.object_0;
		lock (obj)
		{
			int num = this.list_2.IndexOf(z1ykPmxRMH7ivuBQKJ);
			if (num < 0 || num >= this.list_2.Count)
			{
				throw new ArgumentException("Invalid old value");
			}
			if (this.bool_0)
			{
				this.list_0.Add(r3lb35AaVtYRlOIMVV);
				this.list_1.Add(z1ykPmxRMH7ivuBQKJ);
			}
			this.list_2[num] = r3lb35AaVtYRlOIMVV;
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, r3lb35AaVtYRlOIMVV, z1ykPmxRMH7ivuBQKJ, num);
			this.method_7(notifyCollectionChangedEventArgs_);
		}
		this.method_15(notifyCollectionChangedEventArgs_);
	}

	private void method_15(NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_0)
	{
		if (this.gdelegate0_0 != null && notifyCollectionChangedEventArgs_0 != null)
		{
			this.gdelegate0_0(this, notifyCollectionChangedEventArgs_0);
		}
	}

	public BTPJThMZ4kqmmy0pbe method_16(int int_0)
	{
		return this.list_2[int_0];
	}

	public BTPJThMZ4kqmmy0pbe method_17(int int_0, BTPJThMZ4kqmmy0pbe zMVgBT7h4yGU277MH1)
	{
		BTPJThMZ4kqmmy0pbe btpjthMZ4kqmmy0pbe = this.list_2[int_0];
		if (this.bool_0)
		{
			this.list_0.Add(zMVgBT7h4yGU277MH1);
			this.list_1.Add(btpjthMZ4kqmmy0pbe);
		}
		this.list_2[int_0] = zMVgBT7h4yGU277MH1;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, zMVgBT7h4yGU277MH1, btpjthMZ4kqmmy0pbe, int_0);
		this.method_7(notifyCollectionChangedEventArgs_);
		this.method_15(notifyCollectionChangedEventArgs_);
		return btpjthMZ4kqmmy0pbe;
	}

	public void method_18(int int_0, BTPJThMZ4kqmmy0pbe Yf12eNIKwpRBtBPlHN)
	{
		if (this.bool_0)
		{
			this.list_0.Add(Yf12eNIKwpRBtBPlHN);
		}
		this.list_2.Insert(int_0, Yf12eNIKwpRBtBPlHN);
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, Yf12eNIKwpRBtBPlHN, int_0);
		this.method_7(notifyCollectionChangedEventArgs_);
		this.method_15(notifyCollectionChangedEventArgs_);
	}

	public BTPJThMZ4kqmmy0pbe method_19(int int_0)
	{
		BTPJThMZ4kqmmy0pbe btpjthMZ4kqmmy0pbe = this.list_2[int_0];
		if (this.bool_0)
		{
			this.list_1.Add(btpjthMZ4kqmmy0pbe);
		}
		this.list_2.RemoveAt(int_0);
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, btpjthMZ4kqmmy0pbe, int_0);
		this.method_7(notifyCollectionChangedEventArgs_);
		this.method_15(notifyCollectionChangedEventArgs_);
		return btpjthMZ4kqmmy0pbe;
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
			this.method_7(notifyCollectionChangedEventArgs_);
		}
		this.method_15(notifyCollectionChangedEventArgs_);
	}

	public bool Contains(BTPJThMZ4kqmmy0pbe I8Bx1biGXZNa0QkvCb)
	{
		object obj = this.object_0;
		bool result;
		lock (obj)
		{
			result = this.list_2.Contains(I8Bx1biGXZNa0QkvCb);
		}
		return result;
	}

	public void CopyTo(BTPJThMZ4kqmmy0pbe[] array, int arrayIndex)
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

	public void method_20(object object_1)
	{
		this.method_13((BTPJThMZ4kqmmy0pbe)((object)object_1));
	}

	public int method_21(object object_1)
	{
		return this.method_21((BTPJThMZ4kqmmy0pbe)((object)object_1));
	}

	public object SyncRoot
	{
		get
		{
			return this.object_0;
		}
	}

	public bool method_22(IEnumerable<BTPJThMZ4kqmmy0pbe> ienumerable_0)
	{
		if (this.Count != ienumerable_0.Count<BTPJThMZ4kqmmy0pbe>())
		{
			return false;
		}
		object obj = this.object_0;
		lock (obj)
		{
			IEnumerator<BTPJThMZ4kqmmy0pbe> enumerator = this.GetEnumerator();
			enumerator.Reset();
			foreach (BTPJThMZ4kqmmy0pbe btpjthMZ4kqmmy0pbe in ienumerable_0)
			{
				enumerator.MoveNext();
				BTPJThMZ4kqmmy0pbe btpjthMZ4kqmmy0pbe2 = enumerator.Current;
				if (btpjthMZ4kqmmy0pbe2.Equals(btpjthMZ4kqmmy0pbe))
				{
					return false;
				}
			}
			GClass2.smethod_0(enumerator);
		}
		return true;
	}

	private void method_23()
	{
		if (!this.method_22(this.ObsColl))
		{
			this.method_24();
		}
	}

	private void method_24()
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
	private void method_25(StreamingContext streamingContext_0)
	{
		Monitor.Enter(this.object_0);
	}

	[OnSerialized]
	private void method_26(StreamingContext streamingContext_0)
	{
		Monitor.Exit(this.object_0);
	}

	[OnDeserializing]
	private void method_27(StreamingContext streamingContext_0)
	{
	}

	[OnDeserialized]
	private void method_28(StreamingContext streamingContext_0)
	{
	}

	public BTPJThMZ4kqmmy0pbe this[int index]
	{
		get
		{
			return this.list_2[index];
		}
	}

	public void method_29(BTPJThMZ4kqmmy0pbe CKajKC4acrw53uD1Qh)
	{
		this.Add(CKajKC4acrw53uD1Qh);
	}

	public bool method_30(out BTPJThMZ4kqmmy0pbe gparam_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			int count = this.list_2.Count;
			if (count > 0)
			{
				gparam_0 = this.method_19(count - 1);
				return true;
			}
		}
		gparam_0 = default(BTPJThMZ4kqmmy0pbe);
		return false;
	}

	public void method_31(BTPJThMZ4kqmmy0pbe Q03K99BFI6OmMJRBLd)
	{
		this.Add(Q03K99BFI6OmMJRBLd);
	}

	public bool method_32(out BTPJThMZ4kqmmy0pbe gparam_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			if (this.list_2.Count > 0)
			{
				gparam_0 = this.method_19(0);
				return true;
			}
		}
		gparam_0 = default(BTPJThMZ4kqmmy0pbe);
		return false;
	}

	public bool IsReadOnly
	{
		get
		{
			return false;
		}
	}

	bool ICollection<BTPJThMZ4kqmmy0pbe>.Remove(BTPJThMZ4kqmmy0pbe dNyJCQNIwZ1mAq4ucK)
	{
		return this.method_13(dNyJCQNIwZ1mAq4ucK);
	}

	public void CopyTo(Array array, int index)
	{
		object obj = this.object_0;
		lock (obj)
		{
			foreach (BTPJThMZ4kqmmy0pbe btpjthMZ4kqmmy0pbe in this.list_2)
			{
				array.SetValue(btpjthMZ4kqmmy0pbe, index++);
			}
		}
	}

	public bool IsSynchronized
	{
		get
		{
			return this.method_1().CheckAccess();
		}
	}

	private List<BTPJThMZ4kqmmy0pbe> list_0;

	private List<BTPJThMZ4kqmmy0pbe> list_1;

	private bool bool_0;

	private readonly object object_0;

	protected List<BTPJThMZ4kqmmy0pbe> list_2;

	private readonly ObservableCollection<BTPJThMZ4kqmmy0pbe> observableCollection_0;

	private readonly ConcurrentQueue<NotifyCollectionChangedEventArgs> concurrentQueue_0;

	[CompilerGenerated]
	private GDelegate0 gdelegate0_0;

	[CompilerGenerated]
	private Dispatcher dispatcher_0;
}
