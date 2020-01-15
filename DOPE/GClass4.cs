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
public class GClass4<QfgHoDVieLt45ZK0Um> : ICollection<QfgHoDVieLt45ZK0Um>, IEnumerable<QfgHoDVieLt45ZK0Um>, IReadOnlyList<QfgHoDVieLt45ZK0Um>, IReadOnlyCollection<QfgHoDVieLt45ZK0Um>, IEnumerable, ICollection
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

	public ObservableCollection<QfgHoDVieLt45ZK0Um> ObsColl
	{
		get
		{
			return this.observableCollection_0;
		}
	}

	public GClass4()
	{
		Class13.nIxas2ezryi9b();
		this.list_0 = new List<QfgHoDVieLt45ZK0Um>();
		this.GTGBTRBRZ = new List<QfgHoDVieLt45ZK0Um>();
		this.object_0 = new object();
		this.list_1 = new List<QfgHoDVieLt45ZK0Um>();
		this.observableCollection_0 = new ObservableCollection<QfgHoDVieLt45ZK0Um>();
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

	public Tuple<List<QfgHoDVieLt45ZK0Um>, List<QfgHoDVieLt45ZK0Um>> nZiwbljls()
	{
		object obj = this.object_0;
		Tuple<List<QfgHoDVieLt45ZK0Um>, List<QfgHoDVieLt45ZK0Um>> result;
		lock (obj)
		{
			result = new Tuple<List<QfgHoDVieLt45ZK0Um>, List<QfgHoDVieLt45ZK0Um>>(this.list_0, this.GTGBTRBRZ);
			this.list_0 = new List<QfgHoDVieLt45ZK0Um>();
			this.GTGBTRBRZ = new List<QfgHoDVieLt45ZK0Um>();
		}
		return result;
	}

	public QfgHoDVieLt45ZK0Um[] method_6()
	{
		object obj = this.object_0;
		QfgHoDVieLt45ZK0Um[] result;
		lock (obj)
		{
			result = this.list_0.ToArray();
		}
		return result;
	}

	public QfgHoDVieLt45ZK0Um[] method_7()
	{
		object obj = this.object_0;
		QfgHoDVieLt45ZK0Um[] result;
		lock (obj)
		{
			result = this.GTGBTRBRZ.ToArray();
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
						QfgHoDVieLt45ZK0Um item = (QfgHoDVieLt45ZK0Um)((object)obj);
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
					QfgHoDVieLt45ZK0Um item2 = (QfgHoDVieLt45ZK0Um)((object)obj2);
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
			this.ObsColl[notifyCollectionChangedEventArgs.NewStartingIndex] = (QfgHoDVieLt45ZK0Um)((object)newItems[0]);
		}
	}

	public List<QfgHoDVieLt45ZK0Um> method_10()
	{
		List<QfgHoDVieLt45ZK0Um> result = null;
		object obj = this.object_0;
		lock (obj)
		{
			result = new List<QfgHoDVieLt45ZK0Um>(this.list_1);
		}
		return result;
	}

	public void method_11(IList ilist_0)
	{
		GClass4<QfgHoDVieLt45ZK0Um>.<>c__DisplayClass26_0 CS$<>8__locals1 = new GClass4<QfgHoDVieLt45ZK0Um>.<>c__DisplayClass26_0();
		CS$<>8__locals1.list = ilist_0;
		object obj = this.object_0;
		lock (obj)
		{
			this.list_1.smethod_4(new Action<QfgHoDVieLt45ZK0Um>(CS$<>8__locals1.method_0));
		}
	}

	public virtual IEnumerator<QfgHoDVieLt45ZK0Um> GetEnumerator()
	{
		return this.method_10().GetEnumerator();
	}

	public virtual IEnumerator<QfgHoDVieLt45ZK0Um> GetBlockingEnumerator()
	{
		return new GClass1<QfgHoDVieLt45ZK0Um>(this.list_1.GetEnumerator(), this.object_0);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.method_10().GetEnumerator();
	}

	public void method_12(QfgHoDVieLt45ZK0Um GBuCEi4AYDDtbQgBIL)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			this.list_1.Insert(0, GBuCEi4AYDDtbQgBIL);
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, GBuCEi4AYDDtbQgBIL, 0);
			this.method_8(notifyCollectionChangedEventArgs_);
		}
		this.method_16(notifyCollectionChangedEventArgs_);
	}

	public void Add(QfgHoDVieLt45ZK0Um woPWYy85A4axAnCE3U)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			this.list_1.Add(woPWYy85A4axAnCE3U);
			if (this.bool_0)
			{
				this.list_0.Add(woPWYy85A4axAnCE3U);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, woPWYy85A4axAnCE3U, this.list_1.Count - 1);
			this.method_8(notifyCollectionChangedEventArgs_);
		}
		this.method_16(notifyCollectionChangedEventArgs_);
	}

	public void method_13(IList<QfgHoDVieLt45ZK0Um> ilist_0)
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
			this.method_8(notifyCollectionChangedEventArgs_);
		}
		this.method_16(notifyCollectionChangedEventArgs_);
	}

	public bool method_14(QfgHoDVieLt45ZK0Um xr3hKo9AMXg67tRUQf)
	{
		bool result = false;
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			result = this.list_1.Remove(xr3hKo9AMXg67tRUQf);
			if (this.bool_0)
			{
				this.list_0.Add(xr3hKo9AMXg67tRUQf);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, xr3hKo9AMXg67tRUQf);
			this.method_8(notifyCollectionChangedEventArgs_);
		}
		this.method_16(notifyCollectionChangedEventArgs_);
		return result;
	}

	public void method_15(QfgHoDVieLt45ZK0Um NptB2amK5cqPxk8iXQ, QfgHoDVieLt45ZK0Um rynsVMl6KQOjgERuEH)
	{
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = null;
		object obj = this.object_0;
		lock (obj)
		{
			int num = this.list_1.IndexOf(NptB2amK5cqPxk8iXQ);
			if (num < 0 || num >= this.list_1.Count)
			{
				throw new ArgumentException("Invalid old value");
			}
			if (this.bool_0)
			{
				this.list_0.Add(rynsVMl6KQOjgERuEH);
				this.GTGBTRBRZ.Add(NptB2amK5cqPxk8iXQ);
			}
			this.list_1[num] = rynsVMl6KQOjgERuEH;
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, rynsVMl6KQOjgERuEH, NptB2amK5cqPxk8iXQ, num);
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

	public QfgHoDVieLt45ZK0Um method_17(int int_0)
	{
		return this.list_1[int_0];
	}

	public QfgHoDVieLt45ZK0Um method_18(int int_0, QfgHoDVieLt45ZK0Um k0ywaUj3XVqgy1rcgC)
	{
		QfgHoDVieLt45ZK0Um qfgHoDVieLt45ZK0Um = this.list_1[int_0];
		if (this.bool_0)
		{
			this.list_0.Add(k0ywaUj3XVqgy1rcgC);
			this.GTGBTRBRZ.Add(qfgHoDVieLt45ZK0Um);
		}
		this.list_1[int_0] = k0ywaUj3XVqgy1rcgC;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, k0ywaUj3XVqgy1rcgC, qfgHoDVieLt45ZK0Um, int_0);
		this.method_8(notifyCollectionChangedEventArgs_);
		this.method_16(notifyCollectionChangedEventArgs_);
		return qfgHoDVieLt45ZK0Um;
	}

	public void method_19(int int_0, QfgHoDVieLt45ZK0Um WOA2jbg5F7o245DSXv)
	{
		if (this.bool_0)
		{
			this.list_0.Add(WOA2jbg5F7o245DSXv);
		}
		this.list_1.Insert(int_0, WOA2jbg5F7o245DSXv);
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, WOA2jbg5F7o245DSXv, int_0);
		this.method_8(notifyCollectionChangedEventArgs_);
		this.method_16(notifyCollectionChangedEventArgs_);
	}

	public QfgHoDVieLt45ZK0Um method_20(int int_0)
	{
		QfgHoDVieLt45ZK0Um qfgHoDVieLt45ZK0Um = this.list_1[int_0];
		if (this.bool_0)
		{
			this.GTGBTRBRZ.Add(qfgHoDVieLt45ZK0Um);
		}
		this.list_1.RemoveAt(int_0);
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, qfgHoDVieLt45ZK0Um, int_0);
		this.method_8(notifyCollectionChangedEventArgs_);
		this.method_16(notifyCollectionChangedEventArgs_);
		return qfgHoDVieLt45ZK0Um;
	}

	public virtual void Clear()
	{
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = null;
		object obj = this.object_0;
		lock (obj)
		{
			if (this.bool_0)
			{
				this.GTGBTRBRZ.AddRange(this.list_1);
			}
			this.list_1.Clear();
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset);
			this.method_8(notifyCollectionChangedEventArgs_);
		}
		this.method_16(notifyCollectionChangedEventArgs_);
	}

	public bool Contains(QfgHoDVieLt45ZK0Um sn8qTVcTKdofUQrK5h)
	{
		object obj = this.object_0;
		bool result;
		lock (obj)
		{
			result = this.list_1.Contains(sn8qTVcTKdofUQrK5h);
		}
		return result;
	}

	public void CopyTo(QfgHoDVieLt45ZK0Um[] array, int arrayIndex)
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
		this.method_14((QfgHoDVieLt45ZK0Um)((object)object_1));
	}

	public int method_22(object object_1)
	{
		return this.method_22((QfgHoDVieLt45ZK0Um)((object)object_1));
	}

	public object SyncRoot
	{
		get
		{
			return this.object_0;
		}
	}

	public bool method_23(IEnumerable<QfgHoDVieLt45ZK0Um> ienumerable_0)
	{
		if (this.Count != ienumerable_0.Count<QfgHoDVieLt45ZK0Um>())
		{
			return false;
		}
		object obj = this.object_0;
		lock (obj)
		{
			IEnumerator<QfgHoDVieLt45ZK0Um> enumerator = this.GetEnumerator();
			enumerator.Reset();
			foreach (QfgHoDVieLt45ZK0Um qfgHoDVieLt45ZK0Um in ienumerable_0)
			{
				enumerator.MoveNext();
				QfgHoDVieLt45ZK0Um qfgHoDVieLt45ZK0Um2 = enumerator.Current;
				if (qfgHoDVieLt45ZK0Um2.Equals(qfgHoDVieLt45ZK0Um))
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

	public QfgHoDVieLt45ZK0Um this[int index]
	{
		get
		{
			return this.list_1[index];
		}
	}

	public void method_30(QfgHoDVieLt45ZK0Um IPEoo7PBD6CRs6Pnl3)
	{
		this.Add(IPEoo7PBD6CRs6Pnl3);
	}

	public bool method_31(out QfgHoDVieLt45ZK0Um gparam_0)
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
		gparam_0 = default(QfgHoDVieLt45ZK0Um);
		return false;
	}

	public void method_32(QfgHoDVieLt45ZK0Um XeRl2bqpYUwuFkYlwZ)
	{
		this.Add(XeRl2bqpYUwuFkYlwZ);
	}

	public bool method_33(out QfgHoDVieLt45ZK0Um gparam_0)
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
		gparam_0 = default(QfgHoDVieLt45ZK0Um);
		return false;
	}

	public bool IsReadOnly
	{
		get
		{
			return false;
		}
	}

	bool ICollection<QfgHoDVieLt45ZK0Um>.Remove(QfgHoDVieLt45ZK0Um dGdPgkauhwODEne2vb)
	{
		return this.method_14(dGdPgkauhwODEne2vb);
	}

	public void CopyTo(Array array, int index)
	{
		object obj = this.object_0;
		lock (obj)
		{
			foreach (QfgHoDVieLt45ZK0Um qfgHoDVieLt45ZK0Um in this.list_1)
			{
				array.SetValue(qfgHoDVieLt45ZK0Um, index++);
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

	private List<QfgHoDVieLt45ZK0Um> list_0;

	private List<QfgHoDVieLt45ZK0Um> GTGBTRBRZ;

	private bool bool_0;

	private readonly object object_0;

	protected List<QfgHoDVieLt45ZK0Um> list_1;

	private readonly ObservableCollection<QfgHoDVieLt45ZK0Um> observableCollection_0;

	private readonly ConcurrentQueue<NotifyCollectionChangedEventArgs> concurrentQueue_0;

	[CompilerGenerated]
	private GDelegate0 gdelegate0_0;

	[CompilerGenerated]
	private Dispatcher dispatcher_0;
}
