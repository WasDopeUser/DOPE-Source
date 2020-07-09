using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass800 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2863;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass800(GClass196 gclass196_0 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass196_0 == null)
		{
			this.Mode = new GClass196(0);
			return;
		}
		this.Mode = gclass196_0;
	}

	public virtual int vmethod_0()
	{
		return 2863;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Mode = (GClass196)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.Mode != null)
		{
			this.Mode.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2863);
		if (this.Mode != null)
		{
			this.Mode.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass196 Mode;
}
