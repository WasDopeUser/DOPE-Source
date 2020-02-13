using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

public class GClass1<MOap65VGUDTxj4WfNj> : IEnumerator<MOap65VGUDTxj4WfNj>, IDisposable, IEnumerator
{
	public MOap65VGUDTxj4WfNj Current
	{
		get
		{
			return this.ienumerator_0.Current;
		}
	}

	object IEnumerator.Current
	{
		get
		{
			return this.ienumerator_0.Current;
		}
	}

	public bool MoveNext()
	{
		return this.ienumerator_0.MoveNext();
	}

	public void Reset()
	{
		this.ienumerator_0.Reset();
	}

	public GClass1(IEnumerator<MOap65VGUDTxj4WfNj> ienumerator_1, object object_1)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (ienumerator_1 == null || object_1 == null)
		{
			throw new ArgumentException();
		}
		this.ienumerator_0 = ienumerator_1;
		this.object_0 = object_1;
		Monitor.Enter(this.object_0);
	}

	public void Dispose()
	{
		this.Dispose(true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool bool_1)
	{
		if (!this.bool_0)
		{
			if (bool_1)
			{
				if (this.object_0 != null)
				{
					Monitor.Exit(this.object_0);
					this.object_0 = null;
				}
				IDisposable disposable = this.ienumerator_0;
				if (disposable != null)
				{
					disposable.Dispose();
					this.ienumerator_0 = null;
				}
			}
			this.bool_0 = true;
		}
	}

	private IEnumerator<MOap65VGUDTxj4WfNj> ienumerator_0;

	private object object_0;

	private bool bool_0;
}
