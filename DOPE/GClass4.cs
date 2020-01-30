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
public class GClass4<OhOXECUc4L56VtEYHO> : ICollection<OhOXECUc4L56VtEYHO>, IEnumerable<OhOXECUc4L56VtEYHO>, IReadOnlyList<OhOXECUc4L56VtEYHO>, IReadOnlyCollection<OhOXECUc4L56VtEYHO>, IEnumerable, ICollection
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

	public ObservableCollection<OhOXECUc4L56VtEYHO> ObsColl
	{
		get
		{
			return this.observableCollection_0;
		}
	}

	public GClass4()
	{
		Class13.Gj4N3WdzaR1LY();
		this.list_0 = new List<OhOXECUc4L56VtEYHO>();
		this.QgWenHojs = new List<OhOXECUc4L56VtEYHO>();
		this.object_0 = new object();
		this.list_1 = new List<OhOXECUc4L56VtEYHO>();
		this.observableCollection_0 = new ObservableCollection<OhOXECUc4L56VtEYHO>();
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

	public Tuple<List<OhOXECUc4L56VtEYHO>, List<OhOXECUc4L56VtEYHO>> method_6()
	{
		object obj = this.object_0;
		Tuple<List<OhOXECUc4L56VtEYHO>, List<OhOXECUc4L56VtEYHO>> result;
		lock (obj)
		{
			result = new Tuple<List<OhOXECUc4L56VtEYHO>, List<OhOXECUc4L56VtEYHO>>(this.list_0, this.QgWenHojs);
			this.list_0 = new List<OhOXECUc4L56VtEYHO>();
			this.QgWenHojs = new List<OhOXECUc4L56VtEYHO>();
		}
		return result;
	}

	public OhOXECUc4L56VtEYHO[] method_7()
	{
		object obj = this.object_0;
		OhOXECUc4L56VtEYHO[] result;
		lock (obj)
		{
			result = this.list_0.ToArray();
		}
		return result;
	}

	public OhOXECUc4L56VtEYHO[] method_8()
	{
		object obj = this.object_0;
		OhOXECUc4L56VtEYHO[] result;
		lock (obj)
		{
			result = this.QgWenHojs.ToArray();
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
						OhOXECUc4L56VtEYHO item = (OhOXECUc4L56VtEYHO)((object)obj);
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
					OhOXECUc4L56VtEYHO item2 = (OhOXECUc4L56VtEYHO)((object)obj2);
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
			this.ObsColl[notifyCollectionChangedEventArgs.NewStartingIndex] = (OhOXECUc4L56VtEYHO)((object)newItems[0]);
		}
	}

	public List<OhOXECUc4L56VtEYHO> method_11()
	{
		List<OhOXECUc4L56VtEYHO> result = null;
		object obj = this.object_0;
		lock (obj)
		{
			result = new List<OhOXECUc4L56VtEYHO>(this.list_1);
		}
		return result;
	}

	public void method_12(IList ilist_0)
	{
		GClass4<OhOXECUc4L56VtEYHO>.<>c__DisplayClass26_0 CS$<>8__locals1 = new GClass4<OhOXECUc4L56VtEYHO>.<>c__DisplayClass26_0();
		CS$<>8__locals1.list = ilist_0;
		object obj = this.object_0;
		lock (obj)
		{
			this.list_1.smethod_4(new Action<OhOXECUc4L56VtEYHO>(CS$<>8__locals1.method_0));
		}
	}

	public virtual IEnumerator<OhOXECUc4L56VtEYHO> GetEnumerator()
	{
		return this.method_11().GetEnumerator();
	}

	public virtual IEnumerator<OhOXECUc4L56VtEYHO> GetBlockingEnumerator()
	{
		return new GClass1<OhOXECUc4L56VtEYHO>(this.list_1.GetEnumerator(), this.object_0);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.method_11().GetEnumerator();
	}

	public void method_13(OhOXECUc4L56VtEYHO dPMnPd7yZ96PgrM3B1)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			this.list_1.Insert(0, dPMnPd7yZ96PgrM3B1);
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, dPMnPd7yZ96PgrM3B1, 0);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	public void Add(OhOXECUc4L56VtEYHO WSVcGEYKP2dFdDHo9a)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			this.list_1.Add(WSVcGEYKP2dFdDHo9a);
			if (this.bool_0)
			{
				this.list_0.Add(WSVcGEYKP2dFdDHo9a);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, WSVcGEYKP2dFdDHo9a, this.list_1.Count - 1);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	public void method_14(IList<OhOXECUc4L56VtEYHO> ilist_0)
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
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	public bool method_15(OhOXECUc4L56VtEYHO GDfW82vcKPeeFSqlio)
	{
		bool result = false;
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			result = this.list_1.Remove(GDfW82vcKPeeFSqlio);
			if (this.bool_0)
			{
				this.list_0.Add(GDfW82vcKPeeFSqlio);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, GDfW82vcKPeeFSqlio);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_17(notifyCollectionChangedEventArgs_);
		return result;
	}

	public void method_16(OhOXECUc4L56VtEYHO vCnxVKIvGKv0lKVJNw, OhOXECUc4L56VtEYHO hXDtXpgbyl66fEDWrv)
	{
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = null;
		object obj = this.object_0;
		lock (obj)
		{
			int num = this.list_1.IndexOf(vCnxVKIvGKv0lKVJNw);
			if (num < 0 || num >= this.list_1.Count)
			{
				throw new ArgumentException("Invalid old value");
			}
			if (this.bool_0)
			{
				this.list_0.Add(hXDtXpgbyl66fEDWrv);
				this.QgWenHojs.Add(vCnxVKIvGKv0lKVJNw);
			}
			this.list_1[num] = hXDtXpgbyl66fEDWrv;
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, hXDtXpgbyl66fEDWrv, vCnxVKIvGKv0lKVJNw, num);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	private void method_17(NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_0)
	{
		if (this.gdelegate0_0 != null && notifyCollectionChangedEventArgs_0 != null)
		{
			this.gdelegate0_0(this, notifyCollectionChangedEventArgs_0);
		}
	}

	public OhOXECUc4L56VtEYHO method_18(int int_0)
	{
		return this.list_1[int_0];
	}

	public OhOXECUc4L56VtEYHO method_19(int int_0, OhOXECUc4L56VtEYHO WrhrJ1t9knxY3kceMG)
	{
		OhOXECUc4L56VtEYHO ohOXECUc4L56VtEYHO = this.list_1[int_0];
		if (this.bool_0)
		{
			this.list_0.Add(WrhrJ1t9knxY3kceMG);
			this.QgWenHojs.Add(ohOXECUc4L56VtEYHO);
		}
		this.list_1[int_0] = WrhrJ1t9knxY3kceMG;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, WrhrJ1t9knxY3kceMG, ohOXECUc4L56VtEYHO, int_0);
		this.method_9(notifyCollectionChangedEventArgs_);
		this.method_17(notifyCollectionChangedEventArgs_);
		return ohOXECUc4L56VtEYHO;
	}

	public void method_20(int int_0, OhOXECUc4L56VtEYHO BpILILRYx4N0sgo8TB)
	{
		if (this.bool_0)
		{
			this.list_0.Add(BpILILRYx4N0sgo8TB);
		}
		this.list_1.Insert(int_0, BpILILRYx4N0sgo8TB);
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, BpILILRYx4N0sgo8TB, int_0);
		this.method_9(notifyCollectionChangedEventArgs_);
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	public OhOXECUc4L56VtEYHO jcKvkaTix(int int_0)
	{
		OhOXECUc4L56VtEYHO ohOXECUc4L56VtEYHO = this.list_1[int_0];
		if (this.bool_0)
		{
			this.QgWenHojs.Add(ohOXECUc4L56VtEYHO);
		}
		this.list_1.RemoveAt(int_0);
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, ohOXECUc4L56VtEYHO, int_0);
		this.method_9(notifyCollectionChangedEventArgs_);
		this.method_17(notifyCollectionChangedEventArgs_);
		return ohOXECUc4L56VtEYHO;
	}

	public virtual void Clear()
	{
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = null;
		object obj = this.object_0;
		lock (obj)
		{
			if (this.bool_0)
			{
				this.QgWenHojs.AddRange(this.list_1);
			}
			this.list_1.Clear();
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	public bool Contains(OhOXECUc4L56VtEYHO iSYSiu1FKJMErTCdaB)
	{
		object obj = this.object_0;
		bool result;
		lock (obj)
		{
			result = this.list_1.Contains(iSYSiu1FKJMErTCdaB);
		}
		return result;
	}

	public void CopyTo(OhOXECUc4L56VtEYHO[] array, int arrayIndex)
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
		this.method_15((OhOXECUc4L56VtEYHO)((object)object_1));
	}

	public int method_22(object object_1)
	{
		return this.method_22((OhOXECUc4L56VtEYHO)((object)object_1));
	}

	public object SyncRoot
	{
		get
		{
			return this.object_0;
		}
	}

	public bool method_23(IEnumerable<OhOXECUc4L56VtEYHO> ienumerable_0)
	{
		if (this.Count != ienumerable_0.Count<OhOXECUc4L56VtEYHO>())
		{
			return false;
		}
		object obj = this.object_0;
		lock (obj)
		{
			IEnumerator<OhOXECUc4L56VtEYHO> enumerator = this.GetEnumerator();
			enumerator.Reset();
			foreach (OhOXECUc4L56VtEYHO ohOXECUc4L56VtEYHO in ienumerable_0)
			{
				enumerator.MoveNext();
				OhOXECUc4L56VtEYHO ohOXECUc4L56VtEYHO2 = enumerator.Current;
				if (ohOXECUc4L56VtEYHO2.Equals(ohOXECUc4L56VtEYHO))
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

	public OhOXECUc4L56VtEYHO this[int index]
	{
		get
		{
			return this.list_1[index];
		}
	}

	public void method_30(OhOXECUc4L56VtEYHO XPhmm6NulENbTnPFqN)
	{
		this.Add(XPhmm6NulENbTnPFqN);
	}

	public bool method_31(out OhOXECUc4L56VtEYHO gparam_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			int count = this.list_1.Count;
			if (count > 0)
			{
				gparam_0 = this.jcKvkaTix(count - 1);
				return true;
			}
		}
		gparam_0 = default(OhOXECUc4L56VtEYHO);
		return false;
	}

	public void method_32(OhOXECUc4L56VtEYHO Ja0VuVPeio0McqtstQ)
	{
		this.Add(Ja0VuVPeio0McqtstQ);
	}

	public bool method_33(out OhOXECUc4L56VtEYHO gparam_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			if (this.list_1.Count > 0)
			{
				gparam_0 = this.jcKvkaTix(0);
				return true;
			}
		}
		gparam_0 = default(OhOXECUc4L56VtEYHO);
		return false;
	}

	public bool IsReadOnly
	{
		get
		{
			return false;
		}
	}

	bool ICollection<OhOXECUc4L56VtEYHO>.Remove(OhOXECUc4L56VtEYHO HbWjSyFtekODSlP8Kj)
	{
		return this.method_15(HbWjSyFtekODSlP8Kj);
	}

	public void CopyTo(Array array, int index)
	{
		object obj = this.object_0;
		lock (obj)
		{
			foreach (OhOXECUc4L56VtEYHO ohOXECUc4L56VtEYHO in this.list_1)
			{
				array.SetValue(ohOXECUc4L56VtEYHO, index++);
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

	private List<OhOXECUc4L56VtEYHO> list_0;

	private List<OhOXECUc4L56VtEYHO> QgWenHojs;

	private bool bool_0;

	private readonly object object_0;

	protected List<OhOXECUc4L56VtEYHO> list_1;

	private readonly ObservableCollection<OhOXECUc4L56VtEYHO> observableCollection_0;

	private readonly ConcurrentQueue<NotifyCollectionChangedEventArgs> concurrentQueue_0;

	[CompilerGenerated]
	private GDelegate0 gdelegate0_0;

	[CompilerGenerated]
	private Dispatcher dispatcher_0;
}
