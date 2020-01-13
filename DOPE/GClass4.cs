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
public class GClass4<EO7mWD9YUpZxmymouh> : ICollection<EO7mWD9YUpZxmymouh>, IEnumerable<EO7mWD9YUpZxmymouh>, IReadOnlyList<EO7mWD9YUpZxmymouh>, IReadOnlyCollection<EO7mWD9YUpZxmymouh>, IEnumerable, ICollection
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

	public ObservableCollection<EO7mWD9YUpZxmymouh> ObsColl
	{
		get
		{
			return this.observableCollection_0;
		}
	}

	public GClass4()
	{
		Class13.tMHx78BzgCM8j();
		this.list_0 = new List<EO7mWD9YUpZxmymouh>();
		this.list_1 = new List<EO7mWD9YUpZxmymouh>();
		this.object_0 = new object();
		this.list_2 = new List<EO7mWD9YUpZxmymouh>();
		this.observableCollection_0 = new ObservableCollection<EO7mWD9YUpZxmymouh>();
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

	public Tuple<List<EO7mWD9YUpZxmymouh>, List<EO7mWD9YUpZxmymouh>> method_6()
	{
		object obj = this.object_0;
		Tuple<List<EO7mWD9YUpZxmymouh>, List<EO7mWD9YUpZxmymouh>> result;
		lock (obj)
		{
			result = new Tuple<List<EO7mWD9YUpZxmymouh>, List<EO7mWD9YUpZxmymouh>>(this.list_0, this.list_1);
			this.list_0 = new List<EO7mWD9YUpZxmymouh>();
			this.list_1 = new List<EO7mWD9YUpZxmymouh>();
		}
		return result;
	}

	public EO7mWD9YUpZxmymouh[] method_7()
	{
		object obj = this.object_0;
		EO7mWD9YUpZxmymouh[] result;
		lock (obj)
		{
			result = this.list_0.ToArray();
		}
		return result;
	}

	public EO7mWD9YUpZxmymouh[] method_8()
	{
		object obj = this.object_0;
		EO7mWD9YUpZxmymouh[] result;
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
						EO7mWD9YUpZxmymouh item = (EO7mWD9YUpZxmymouh)((object)obj);
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
					EO7mWD9YUpZxmymouh item2 = (EO7mWD9YUpZxmymouh)((object)obj2);
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
			this.ObsColl[notifyCollectionChangedEventArgs.NewStartingIndex] = (EO7mWD9YUpZxmymouh)((object)newItems[0]);
		}
	}

	public List<EO7mWD9YUpZxmymouh> method_11()
	{
		List<EO7mWD9YUpZxmymouh> result = null;
		object obj = this.object_0;
		lock (obj)
		{
			result = new List<EO7mWD9YUpZxmymouh>(this.list_2);
		}
		return result;
	}

	public void method_12(IList ilist_0)
	{
		GClass4<EO7mWD9YUpZxmymouh>.<>c__DisplayClass26_0 CS$<>8__locals1 = new GClass4<EO7mWD9YUpZxmymouh>.<>c__DisplayClass26_0();
		CS$<>8__locals1.list = ilist_0;
		object obj = this.object_0;
		lock (obj)
		{
			this.list_2.smethod_4(new Action<EO7mWD9YUpZxmymouh>(CS$<>8__locals1.method_0));
		}
	}

	public virtual IEnumerator<EO7mWD9YUpZxmymouh> GetEnumerator()
	{
		return this.method_11().GetEnumerator();
	}

	public virtual IEnumerator<EO7mWD9YUpZxmymouh> GetBlockingEnumerator()
	{
		return new GClass1<EO7mWD9YUpZxmymouh>(this.list_2.GetEnumerator(), this.object_0);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.method_11().GetEnumerator();
	}

	public void method_13(EO7mWD9YUpZxmymouh p3Q61x1pC4bYD7mJ3A)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			this.list_2.Insert(0, p3Q61x1pC4bYD7mJ3A);
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, p3Q61x1pC4bYD7mJ3A, 0);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	public void Add(EO7mWD9YUpZxmymouh yqjwjomKXFr6yak4nf)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			this.list_2.Add(yqjwjomKXFr6yak4nf);
			if (this.bool_0)
			{
				this.list_0.Add(yqjwjomKXFr6yak4nf);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, yqjwjomKXFr6yak4nf, this.list_2.Count - 1);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	public void method_14(IList<EO7mWD9YUpZxmymouh> ilist_0)
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

	public bool method_15(EO7mWD9YUpZxmymouh gju8DFatqgXxIJd9LS)
	{
		bool result = false;
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			result = this.list_2.Remove(gju8DFatqgXxIJd9LS);
			if (this.bool_0)
			{
				this.list_0.Add(gju8DFatqgXxIJd9LS);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, gju8DFatqgXxIJd9LS);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_17(notifyCollectionChangedEventArgs_);
		return result;
	}

	public void method_16(EO7mWD9YUpZxmymouh casHNDCKvbstghtXGs, EO7mWD9YUpZxmymouh aDY9VMKTv9CQe60CSo)
	{
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = null;
		object obj = this.object_0;
		lock (obj)
		{
			int num = this.list_2.IndexOf(casHNDCKvbstghtXGs);
			if (num < 0 || num >= this.list_2.Count)
			{
				throw new ArgumentException("Invalid old value");
			}
			if (this.bool_0)
			{
				this.list_0.Add(aDY9VMKTv9CQe60CSo);
				this.list_1.Add(casHNDCKvbstghtXGs);
			}
			this.list_2[num] = aDY9VMKTv9CQe60CSo;
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, aDY9VMKTv9CQe60CSo, casHNDCKvbstghtXGs, num);
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

	public EO7mWD9YUpZxmymouh method_18(int int_0)
	{
		return this.list_2[int_0];
	}

	public EO7mWD9YUpZxmymouh method_19(int int_0, EO7mWD9YUpZxmymouh ujkGAx352fAHsQ938p)
	{
		EO7mWD9YUpZxmymouh eo7mWD9YUpZxmymouh = this.list_2[int_0];
		if (this.bool_0)
		{
			this.list_0.Add(ujkGAx352fAHsQ938p);
			this.list_1.Add(eo7mWD9YUpZxmymouh);
		}
		this.list_2[int_0] = ujkGAx352fAHsQ938p;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, ujkGAx352fAHsQ938p, eo7mWD9YUpZxmymouh, int_0);
		this.method_9(notifyCollectionChangedEventArgs_);
		this.method_17(notifyCollectionChangedEventArgs_);
		return eo7mWD9YUpZxmymouh;
	}

	public void method_20(int int_0, EO7mWD9YUpZxmymouh ih1Nntcqube58D5Sm8)
	{
		if (this.bool_0)
		{
			this.list_0.Add(ih1Nntcqube58D5Sm8);
		}
		this.list_2.Insert(int_0, ih1Nntcqube58D5Sm8);
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, ih1Nntcqube58D5Sm8, int_0);
		this.method_9(notifyCollectionChangedEventArgs_);
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	public EO7mWD9YUpZxmymouh method_21(int int_0)
	{
		EO7mWD9YUpZxmymouh eo7mWD9YUpZxmymouh = this.list_2[int_0];
		if (this.bool_0)
		{
			this.list_1.Add(eo7mWD9YUpZxmymouh);
		}
		this.list_2.RemoveAt(int_0);
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, eo7mWD9YUpZxmymouh, int_0);
		this.method_9(notifyCollectionChangedEventArgs_);
		this.method_17(notifyCollectionChangedEventArgs_);
		return eo7mWD9YUpZxmymouh;
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

	public bool Contains(EO7mWD9YUpZxmymouh eQZesaMbQrSGZ3rriq)
	{
		object obj = this.object_0;
		bool result;
		lock (obj)
		{
			result = this.list_2.Contains(eQZesaMbQrSGZ3rriq);
		}
		return result;
	}

	public void CopyTo(EO7mWD9YUpZxmymouh[] array, int arrayIndex)
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
		this.method_15((EO7mWD9YUpZxmymouh)((object)object_1));
	}

	public int method_23(object object_1)
	{
		return this.method_23((EO7mWD9YUpZxmymouh)((object)object_1));
	}

	public object SyncRoot
	{
		get
		{
			return this.object_0;
		}
	}

	public bool method_24(IEnumerable<EO7mWD9YUpZxmymouh> ienumerable_0)
	{
		if (this.Count != ienumerable_0.Count<EO7mWD9YUpZxmymouh>())
		{
			return false;
		}
		object obj = this.object_0;
		lock (obj)
		{
			IEnumerator<EO7mWD9YUpZxmymouh> enumerator = this.GetEnumerator();
			enumerator.Reset();
			foreach (EO7mWD9YUpZxmymouh eo7mWD9YUpZxmymouh in ienumerable_0)
			{
				enumerator.MoveNext();
				EO7mWD9YUpZxmymouh eo7mWD9YUpZxmymouh2 = enumerator.Current;
				if (eo7mWD9YUpZxmymouh2.Equals(eo7mWD9YUpZxmymouh))
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
			this.TlOhoMoLh();
		}
	}

	private void TlOhoMoLh()
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

	public EO7mWD9YUpZxmymouh this[int index]
	{
		get
		{
			return this.list_2[index];
		}
	}

	public void method_30(EO7mWD9YUpZxmymouh cNRErVEj7JF8qR1rA1)
	{
		this.Add(cNRErVEj7JF8qR1rA1);
	}

	public bool method_31(out EO7mWD9YUpZxmymouh gparam_0)
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
		gparam_0 = default(EO7mWD9YUpZxmymouh);
		return false;
	}

	public void method_32(EO7mWD9YUpZxmymouh VskZK9xnjM67WoaATb)
	{
		this.Add(VskZK9xnjM67WoaATb);
	}

	public bool method_33(out EO7mWD9YUpZxmymouh gparam_0)
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
		gparam_0 = default(EO7mWD9YUpZxmymouh);
		return false;
	}

	public bool IsReadOnly
	{
		get
		{
			return false;
		}
	}

	bool ICollection<EO7mWD9YUpZxmymouh>.Remove(EO7mWD9YUpZxmymouh RwF9MBby2siyQq0jpU)
	{
		return this.method_15(RwF9MBby2siyQq0jpU);
	}

	public void CopyTo(Array array, int index)
	{
		object obj = this.object_0;
		lock (obj)
		{
			foreach (EO7mWD9YUpZxmymouh eo7mWD9YUpZxmymouh in this.list_2)
			{
				array.SetValue(eo7mWD9YUpZxmymouh, index++);
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

	private List<EO7mWD9YUpZxmymouh> list_0;

	private List<EO7mWD9YUpZxmymouh> list_1;

	private bool bool_0;

	private readonly object object_0;

	protected List<EO7mWD9YUpZxmymouh> list_2;

	private readonly ObservableCollection<EO7mWD9YUpZxmymouh> observableCollection_0;

	private readonly ConcurrentQueue<NotifyCollectionChangedEventArgs> concurrentQueue_0;

	[CompilerGenerated]
	private GDelegate0 gdelegate0_0;

	[CompilerGenerated]
	private Dispatcher dispatcher_0;
}
