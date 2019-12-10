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
public class GClass4<g1DwMNiEcPViQwTx31> : ICollection<g1DwMNiEcPViQwTx31>, IEnumerable<g1DwMNiEcPViQwTx31>, IReadOnlyList<g1DwMNiEcPViQwTx31>, IReadOnlyCollection<g1DwMNiEcPViQwTx31>, IEnumerable, ICollection
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

	public ObservableCollection<g1DwMNiEcPViQwTx31> ObsColl
	{
		get
		{
			return this.observableCollection_0;
		}
	}

	public GClass4()
	{
		Class8.xDph7tozmh5WD();
		this.list_0 = new List<g1DwMNiEcPViQwTx31>();
		this.list_1 = new List<g1DwMNiEcPViQwTx31>();
		this.object_0 = new object();
		this.list_2 = new List<g1DwMNiEcPViQwTx31>();
		this.observableCollection_0 = new ObservableCollection<g1DwMNiEcPViQwTx31>();
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

	public Tuple<List<g1DwMNiEcPViQwTx31>, List<g1DwMNiEcPViQwTx31>> method_6()
	{
		object obj = this.object_0;
		Tuple<List<g1DwMNiEcPViQwTx31>, List<g1DwMNiEcPViQwTx31>> result;
		lock (obj)
		{
			result = new Tuple<List<g1DwMNiEcPViQwTx31>, List<g1DwMNiEcPViQwTx31>>(this.list_0, this.list_1);
			this.list_0 = new List<g1DwMNiEcPViQwTx31>();
			this.list_1 = new List<g1DwMNiEcPViQwTx31>();
		}
		return result;
	}

	public g1DwMNiEcPViQwTx31[] method_7()
	{
		object obj = this.object_0;
		g1DwMNiEcPViQwTx31[] result;
		lock (obj)
		{
			result = this.list_0.ToArray();
		}
		return result;
	}

	public g1DwMNiEcPViQwTx31[] method_8()
	{
		object obj = this.object_0;
		g1DwMNiEcPViQwTx31[] result;
		lock (obj)
		{
			result = this.list_1.ToArray();
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
						g1DwMNiEcPViQwTx31 item = (g1DwMNiEcPViQwTx31)((object)obj);
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
					g1DwMNiEcPViQwTx31 item2 = (g1DwMNiEcPViQwTx31)((object)obj2);
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
			this.ObsColl[notifyCollectionChangedEventArgs.NewStartingIndex] = (g1DwMNiEcPViQwTx31)((object)newItems[0]);
		}
	}

	public List<g1DwMNiEcPViQwTx31> method_11()
	{
		List<g1DwMNiEcPViQwTx31> result = null;
		object obj = this.object_0;
		lock (obj)
		{
			result = new List<g1DwMNiEcPViQwTx31>(this.list_2);
		}
		return result;
	}

	public void method_12(IList ilist_0)
	{
		GClass4<g1DwMNiEcPViQwTx31>.<>c__DisplayClass26_0 CS$<>8__locals1 = new GClass4<g1DwMNiEcPViQwTx31>.<>c__DisplayClass26_0();
		CS$<>8__locals1.list = ilist_0;
		object obj = this.object_0;
		lock (obj)
		{
			this.list_2.smethod_4(new Action<g1DwMNiEcPViQwTx31>(CS$<>8__locals1.method_0));
		}
	}

	public virtual IEnumerator<g1DwMNiEcPViQwTx31> GetEnumerator()
	{
		return this.method_11().GetEnumerator();
	}

	public virtual IEnumerator<g1DwMNiEcPViQwTx31> GetBlockingEnumerator()
	{
		return new GClass1<g1DwMNiEcPViQwTx31>(this.list_2.GetEnumerator(), this.object_0);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.method_11().GetEnumerator();
	}

	public void method_13(g1DwMNiEcPViQwTx31 f5bDBY5Jkup0Tv1VbS)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			this.list_2.Insert(0, f5bDBY5Jkup0Tv1VbS);
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, f5bDBY5Jkup0Tv1VbS, 0);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	public void Add(g1DwMNiEcPViQwTx31 Ed6EAOs5evawWcFTK6)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			this.list_2.Add(Ed6EAOs5evawWcFTK6);
			if (this.bool_0)
			{
				this.list_0.Add(Ed6EAOs5evawWcFTK6);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, Ed6EAOs5evawWcFTK6, this.list_2.Count - 1);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	public void method_14(IList<g1DwMNiEcPViQwTx31> ilist_0)
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
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	public bool method_15(g1DwMNiEcPViQwTx31 kIT9Kw17J63tBEZSga)
	{
		bool result = false;
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			result = this.list_2.Remove(kIT9Kw17J63tBEZSga);
			if (this.bool_0)
			{
				this.list_0.Add(kIT9Kw17J63tBEZSga);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, kIT9Kw17J63tBEZSga);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_17(notifyCollectionChangedEventArgs_);
		return result;
	}

	public void method_16(g1DwMNiEcPViQwTx31 fbqpdOmNfYpXuTot81, g1DwMNiEcPViQwTx31 d0VRKxo1TxVPLRg8mP)
	{
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = null;
		object obj = this.object_0;
		lock (obj)
		{
			int num = this.list_2.IndexOf(fbqpdOmNfYpXuTot81);
			if (num < 0 || num >= this.list_2.Count)
			{
				throw new ArgumentException("Invalid old value");
			}
			if (this.bool_0)
			{
				this.list_0.Add(d0VRKxo1TxVPLRg8mP);
				this.list_1.Add(fbqpdOmNfYpXuTot81);
			}
			this.list_2[num] = d0VRKxo1TxVPLRg8mP;
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, d0VRKxo1TxVPLRg8mP, fbqpdOmNfYpXuTot81, num);
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

	public g1DwMNiEcPViQwTx31 method_18(int int_0)
	{
		return this.list_2[int_0];
	}

	public g1DwMNiEcPViQwTx31 method_19(int int_0, g1DwMNiEcPViQwTx31 t400bmBK17ovTVcLV1)
	{
		g1DwMNiEcPViQwTx31 g1DwMNiEcPViQwTx = this.list_2[int_0];
		if (this.bool_0)
		{
			this.list_0.Add(t400bmBK17ovTVcLV1);
			this.list_1.Add(g1DwMNiEcPViQwTx);
		}
		this.list_2[int_0] = t400bmBK17ovTVcLV1;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, t400bmBK17ovTVcLV1, g1DwMNiEcPViQwTx, int_0);
		this.method_9(notifyCollectionChangedEventArgs_);
		this.method_17(notifyCollectionChangedEventArgs_);
		return g1DwMNiEcPViQwTx;
	}

	public void method_20(int int_0, g1DwMNiEcPViQwTx31 FcBQixGCgXcif9Bom0)
	{
		if (this.bool_0)
		{
			this.list_0.Add(FcBQixGCgXcif9Bom0);
		}
		this.list_2.Insert(int_0, FcBQixGCgXcif9Bom0);
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, FcBQixGCgXcif9Bom0, int_0);
		this.method_9(notifyCollectionChangedEventArgs_);
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	public g1DwMNiEcPViQwTx31 method_21(int int_0)
	{
		g1DwMNiEcPViQwTx31 g1DwMNiEcPViQwTx = this.list_2[int_0];
		if (this.bool_0)
		{
			this.list_1.Add(g1DwMNiEcPViQwTx);
		}
		this.list_2.RemoveAt(int_0);
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, g1DwMNiEcPViQwTx, int_0);
		this.method_9(notifyCollectionChangedEventArgs_);
		this.method_17(notifyCollectionChangedEventArgs_);
		return g1DwMNiEcPViQwTx;
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
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	public bool Contains(g1DwMNiEcPViQwTx31 YgGNClJ4ucosqbZtg2)
	{
		object obj = this.object_0;
		bool result;
		lock (obj)
		{
			result = this.list_2.Contains(YgGNClJ4ucosqbZtg2);
		}
		return result;
	}

	public void CopyTo(g1DwMNiEcPViQwTx31[] array, int arrayIndex)
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

	public void method_22(object object_1)
	{
		this.method_15((g1DwMNiEcPViQwTx31)((object)object_1));
	}

	public int method_23(object object_1)
	{
		return this.method_23((g1DwMNiEcPViQwTx31)((object)object_1));
	}

	public object SyncRoot
	{
		get
		{
			return this.object_0;
		}
	}

	public bool method_24(IEnumerable<g1DwMNiEcPViQwTx31> ienumerable_0)
	{
		if (this.Count != ienumerable_0.Count<g1DwMNiEcPViQwTx31>())
		{
			return false;
		}
		object obj = this.object_0;
		lock (obj)
		{
			IEnumerator<g1DwMNiEcPViQwTx31> enumerator = this.GetEnumerator();
			enumerator.Reset();
			foreach (g1DwMNiEcPViQwTx31 g1DwMNiEcPViQwTx in ienumerable_0)
			{
				enumerator.MoveNext();
				g1DwMNiEcPViQwTx31 g1DwMNiEcPViQwTx2 = enumerator.Current;
				if (g1DwMNiEcPViQwTx2.Equals(g1DwMNiEcPViQwTx))
				{
					return false;
				}
			}
			GClass2.smethod_0(enumerator);
		}
		return true;
	}

	private void method_25()
	{
		if (!this.method_24(this.ObsColl))
		{
			this.method_26();
		}
	}

	private void method_26()
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
	private void method_27(StreamingContext streamingContext_0)
	{
		Monitor.Enter(this.object_0);
	}

	[OnSerialized]
	private void method_28(StreamingContext streamingContext_0)
	{
		Monitor.Exit(this.object_0);
	}

	[OnDeserializing]
	private void method_29(StreamingContext streamingContext_0)
	{
	}

	[OnDeserialized]
	private void method_30(StreamingContext streamingContext_0)
	{
	}

	public g1DwMNiEcPViQwTx31 this[int index]
	{
		get
		{
			return this.list_2[index];
		}
	}

	public void method_31(g1DwMNiEcPViQwTx31 CUm0JcqxdarTEItfpd)
	{
		this.Add(CUm0JcqxdarTEItfpd);
	}

	public bool method_32(out g1DwMNiEcPViQwTx31 gparam_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			int count = this.list_2.Count;
			if (count > 0)
			{
				gparam_0 = this.method_21(count - 1);
				return true;
			}
		}
		gparam_0 = default(g1DwMNiEcPViQwTx31);
		return false;
	}

	public void Upltljpnd(g1DwMNiEcPViQwTx31 yST91nCCHfvpAL2OOS)
	{
		this.Add(yST91nCCHfvpAL2OOS);
	}

	public bool method_33(out g1DwMNiEcPViQwTx31 gparam_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			if (this.list_2.Count > 0)
			{
				gparam_0 = this.method_21(0);
				return true;
			}
		}
		gparam_0 = default(g1DwMNiEcPViQwTx31);
		return false;
	}

	public bool IsReadOnly
	{
		get
		{
			return false;
		}
	}

	bool ICollection<g1DwMNiEcPViQwTx31>.Remove(g1DwMNiEcPViQwTx31 rtc23tkiJUvqJcsBXu)
	{
		return this.method_15(rtc23tkiJUvqJcsBXu);
	}

	public void CopyTo(Array array, int index)
	{
		object obj = this.object_0;
		lock (obj)
		{
			foreach (g1DwMNiEcPViQwTx31 g1DwMNiEcPViQwTx in this.list_2)
			{
				array.SetValue(g1DwMNiEcPViQwTx, index++);
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

	private List<g1DwMNiEcPViQwTx31> list_0;

	private List<g1DwMNiEcPViQwTx31> list_1;

	private bool bool_0;

	private readonly object object_0;

	protected List<g1DwMNiEcPViQwTx31> list_2;

	private readonly ObservableCollection<g1DwMNiEcPViQwTx31> observableCollection_0;

	private readonly ConcurrentQueue<NotifyCollectionChangedEventArgs> concurrentQueue_0;

	[CompilerGenerated]
	private GDelegate0 gdelegate0_0;

	[CompilerGenerated]
	private Dispatcher dispatcher_0;
}
