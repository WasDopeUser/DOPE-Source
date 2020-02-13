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
public class GClass4<u7FyQN6OqtJfMHeYli> : ICollection<u7FyQN6OqtJfMHeYli>, IEnumerable<u7FyQN6OqtJfMHeYli>, IReadOnlyList<u7FyQN6OqtJfMHeYli>, IReadOnlyCollection<u7FyQN6OqtJfMHeYli>, IEnumerable, ICollection
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

	public ObservableCollection<u7FyQN6OqtJfMHeYli> ObsColl
	{
		get
		{
			return this.observableCollection_0;
		}
	}

	public GClass4()
	{
		Class13.igxcIukzfpare();
		this.list_0 = new List<u7FyQN6OqtJfMHeYli>();
		this.list_1 = new List<u7FyQN6OqtJfMHeYli>();
		this.object_0 = new object();
		this.list_2 = new List<u7FyQN6OqtJfMHeYli>();
		this.observableCollection_0 = new ObservableCollection<u7FyQN6OqtJfMHeYli>();
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

	public Tuple<List<u7FyQN6OqtJfMHeYli>, List<u7FyQN6OqtJfMHeYli>> method_6()
	{
		object obj = this.object_0;
		Tuple<List<u7FyQN6OqtJfMHeYli>, List<u7FyQN6OqtJfMHeYli>> result;
		lock (obj)
		{
			result = new Tuple<List<u7FyQN6OqtJfMHeYli>, List<u7FyQN6OqtJfMHeYli>>(this.list_0, this.list_1);
			this.list_0 = new List<u7FyQN6OqtJfMHeYli>();
			this.list_1 = new List<u7FyQN6OqtJfMHeYli>();
		}
		return result;
	}

	public u7FyQN6OqtJfMHeYli[] method_7()
	{
		object obj = this.object_0;
		u7FyQN6OqtJfMHeYli[] result;
		lock (obj)
		{
			result = this.list_0.ToArray();
		}
		return result;
	}

	public u7FyQN6OqtJfMHeYli[] method_8()
	{
		object obj = this.object_0;
		u7FyQN6OqtJfMHeYli[] result;
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
						u7FyQN6OqtJfMHeYli item = (u7FyQN6OqtJfMHeYli)((object)obj);
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
					u7FyQN6OqtJfMHeYli item2 = (u7FyQN6OqtJfMHeYli)((object)obj2);
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
			this.ObsColl[notifyCollectionChangedEventArgs.NewStartingIndex] = (u7FyQN6OqtJfMHeYli)((object)newItems[0]);
		}
	}

	public List<u7FyQN6OqtJfMHeYli> method_11()
	{
		List<u7FyQN6OqtJfMHeYli> result = null;
		object obj = this.object_0;
		lock (obj)
		{
			result = new List<u7FyQN6OqtJfMHeYli>(this.list_2);
		}
		return result;
	}

	public void method_12(IList ilist_0)
	{
		GClass4<u7FyQN6OqtJfMHeYli>.<>c__DisplayClass26_0 CS$<>8__locals1 = new GClass4<u7FyQN6OqtJfMHeYli>.<>c__DisplayClass26_0();
		CS$<>8__locals1.list = ilist_0;
		object obj = this.object_0;
		lock (obj)
		{
			this.list_2.smethod_4(new Action<u7FyQN6OqtJfMHeYli>(CS$<>8__locals1.method_0));
		}
	}

	public virtual IEnumerator<u7FyQN6OqtJfMHeYli> GetEnumerator()
	{
		return this.method_11().GetEnumerator();
	}

	public virtual IEnumerator<u7FyQN6OqtJfMHeYli> GetBlockingEnumerator()
	{
		return new GClass1<u7FyQN6OqtJfMHeYli>(this.list_2.GetEnumerator(), this.object_0);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.method_11().GetEnumerator();
	}

	public void method_13(u7FyQN6OqtJfMHeYli MhoMNw87Qy948isR6o)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			this.list_2.Insert(0, MhoMNw87Qy948isR6o);
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, MhoMNw87Qy948isR6o, 0);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	public void Add(u7FyQN6OqtJfMHeYli RybDXs4dnM9CQrNOBb)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			this.list_2.Add(RybDXs4dnM9CQrNOBb);
			if (this.bool_0)
			{
				this.list_0.Add(RybDXs4dnM9CQrNOBb);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, RybDXs4dnM9CQrNOBb, this.list_2.Count - 1);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	public void method_14(IList<u7FyQN6OqtJfMHeYli> ilist_0)
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

	public bool method_15(u7FyQN6OqtJfMHeYli aCXd2vMA9NBQb9m37t)
	{
		bool result = false;
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			result = this.list_2.Remove(aCXd2vMA9NBQb9m37t);
			if (this.bool_0)
			{
				this.list_0.Add(aCXd2vMA9NBQb9m37t);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, aCXd2vMA9NBQb9m37t);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_17(notifyCollectionChangedEventArgs_);
		return result;
	}

	public void method_16(u7FyQN6OqtJfMHeYli Ke13AtwkfR6GD06Vi6, u7FyQN6OqtJfMHeYli NfbIlvyAXZXpcqlZru)
	{
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = null;
		object obj = this.object_0;
		lock (obj)
		{
			int num = this.list_2.IndexOf(Ke13AtwkfR6GD06Vi6);
			if (num < 0 || num >= this.list_2.Count)
			{
				throw new ArgumentException("Invalid old value");
			}
			if (this.bool_0)
			{
				this.list_0.Add(NfbIlvyAXZXpcqlZru);
				this.list_1.Add(Ke13AtwkfR6GD06Vi6);
			}
			this.list_2[num] = NfbIlvyAXZXpcqlZru;
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, NfbIlvyAXZXpcqlZru, Ke13AtwkfR6GD06Vi6, num);
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

	public u7FyQN6OqtJfMHeYli method_18(int int_0)
	{
		return this.list_2[int_0];
	}

	public u7FyQN6OqtJfMHeYli method_19(int int_0, u7FyQN6OqtJfMHeYli cnu2K8l497p71ofKvm)
	{
		u7FyQN6OqtJfMHeYli u7FyQN6OqtJfMHeYli = this.list_2[int_0];
		if (this.bool_0)
		{
			this.list_0.Add(cnu2K8l497p71ofKvm);
			this.list_1.Add(u7FyQN6OqtJfMHeYli);
		}
		this.list_2[int_0] = cnu2K8l497p71ofKvm;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, cnu2K8l497p71ofKvm, u7FyQN6OqtJfMHeYli, int_0);
		this.method_9(notifyCollectionChangedEventArgs_);
		this.method_17(notifyCollectionChangedEventArgs_);
		return u7FyQN6OqtJfMHeYli;
	}

	public void method_20(int int_0, u7FyQN6OqtJfMHeYli o5rDHYOFDTFuQnI8uL)
	{
		if (this.bool_0)
		{
			this.list_0.Add(o5rDHYOFDTFuQnI8uL);
		}
		this.list_2.Insert(int_0, o5rDHYOFDTFuQnI8uL);
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, o5rDHYOFDTFuQnI8uL, int_0);
		this.method_9(notifyCollectionChangedEventArgs_);
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	public u7FyQN6OqtJfMHeYli method_21(int int_0)
	{
		u7FyQN6OqtJfMHeYli u7FyQN6OqtJfMHeYli = this.list_2[int_0];
		if (this.bool_0)
		{
			this.list_1.Add(u7FyQN6OqtJfMHeYli);
		}
		this.list_2.RemoveAt(int_0);
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, u7FyQN6OqtJfMHeYli, int_0);
		this.method_9(notifyCollectionChangedEventArgs_);
		this.method_17(notifyCollectionChangedEventArgs_);
		return u7FyQN6OqtJfMHeYli;
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

	public bool Contains(u7FyQN6OqtJfMHeYli yHlhAQpakL6hpqtFDT)
	{
		object obj = this.object_0;
		bool result;
		lock (obj)
		{
			result = this.list_2.Contains(yHlhAQpakL6hpqtFDT);
		}
		return result;
	}

	public void CopyTo(u7FyQN6OqtJfMHeYli[] array, int arrayIndex)
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
		this.method_15((u7FyQN6OqtJfMHeYli)((object)object_1));
	}

	public int method_23(object object_1)
	{
		return this.method_23((u7FyQN6OqtJfMHeYli)((object)object_1));
	}

	public object SyncRoot
	{
		get
		{
			return this.object_0;
		}
	}

	public bool method_24(IEnumerable<u7FyQN6OqtJfMHeYli> ienumerable_0)
	{
		if (this.Count != ienumerable_0.Count<u7FyQN6OqtJfMHeYli>())
		{
			return false;
		}
		object obj = this.object_0;
		lock (obj)
		{
			IEnumerator<u7FyQN6OqtJfMHeYli> enumerator = this.GetEnumerator();
			enumerator.Reset();
			foreach (u7FyQN6OqtJfMHeYli u7FyQN6OqtJfMHeYli in ienumerable_0)
			{
				enumerator.MoveNext();
				u7FyQN6OqtJfMHeYli u7FyQN6OqtJfMHeYli2 = enumerator.Current;
				if (u7FyQN6OqtJfMHeYli2.Equals(u7FyQN6OqtJfMHeYli))
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

	public u7FyQN6OqtJfMHeYli this[int index]
	{
		get
		{
			return this.list_2[index];
		}
	}

	public void method_31(u7FyQN6OqtJfMHeYli t38KxlBegCO0OKRq51)
	{
		this.Add(t38KxlBegCO0OKRq51);
	}

	public bool method_32(out u7FyQN6OqtJfMHeYli gparam_0)
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
		gparam_0 = default(u7FyQN6OqtJfMHeYli);
		return false;
	}

	public void method_33(u7FyQN6OqtJfMHeYli LhN0jQnitfnBcmSUTj)
	{
		this.Add(LhN0jQnitfnBcmSUTj);
	}

	public bool method_34(out u7FyQN6OqtJfMHeYli gparam_0)
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
		gparam_0 = default(u7FyQN6OqtJfMHeYli);
		return false;
	}

	public bool IsReadOnly
	{
		get
		{
			return false;
		}
	}

	bool ICollection<u7FyQN6OqtJfMHeYli>.Remove(u7FyQN6OqtJfMHeYli olmXWbeyc8AjngBGAI)
	{
		return this.method_15(olmXWbeyc8AjngBGAI);
	}

	public void CopyTo(Array array, int index)
	{
		object obj = this.object_0;
		lock (obj)
		{
			foreach (u7FyQN6OqtJfMHeYli u7FyQN6OqtJfMHeYli in this.list_2)
			{
				array.SetValue(u7FyQN6OqtJfMHeYli, index++);
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

	private List<u7FyQN6OqtJfMHeYli> list_0;

	private List<u7FyQN6OqtJfMHeYli> list_1;

	private bool bool_0;

	private readonly object object_0;

	protected List<u7FyQN6OqtJfMHeYli> list_2;

	private readonly ObservableCollection<u7FyQN6OqtJfMHeYli> observableCollection_0;

	private readonly ConcurrentQueue<NotifyCollectionChangedEventArgs> concurrentQueue_0;

	[CompilerGenerated]
	private GDelegate0 gdelegate0_0;

	[CompilerGenerated]
	private Dispatcher dispatcher_0;
}
