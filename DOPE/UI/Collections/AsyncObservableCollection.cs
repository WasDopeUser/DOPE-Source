using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Threading;

namespace DOPE.UI.Collections
{
	public class AsyncObservableCollection<T> : ObservableCollection<T>
	{
		public AsyncObservableCollection()
		{
			Class8.xDph7tozmh5WD();
			this._synchronizationContext = SynchronizationContext.Current;
			base..ctor();
		}

		public AsyncObservableCollection(IEnumerable<T> ienumerable_0)
		{
			Class8.xDph7tozmh5WD();
			this._synchronizationContext = SynchronizationContext.Current;
			base..ctor(ienumerable_0);
		}

		protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
		{
			if (SynchronizationContext.Current == this._synchronizationContext)
			{
				this.method_0(e);
				return;
			}
			this._synchronizationContext.Send(new SendOrPostCallback(this.method_0), e);
		}

		private void method_0(object object_0)
		{
			base.OnCollectionChanged((NotifyCollectionChangedEventArgs)object_0);
		}

		protected override void OnPropertyChanged(PropertyChangedEventArgs e)
		{
			if (SynchronizationContext.Current == this._synchronizationContext)
			{
				this.OruuoxoCvT(e);
				return;
			}
			this._synchronizationContext.Send(new SendOrPostCallback(this.OruuoxoCvT), e);
		}

		private void OruuoxoCvT(object object_0)
		{
			base.OnPropertyChanged((PropertyChangedEventArgs)object_0);
		}

		private SynchronizationContext _synchronizationContext;
	}
}
