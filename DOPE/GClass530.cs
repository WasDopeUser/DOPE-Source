using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass530 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2001;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass530(GClass512 gclass512_1 = null, GClass462 gclass462_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass512_1 == null)
		{
			this.gclass512_0 = new GClass512(0, false, false, false, 0, null);
		}
		else
		{
			this.gclass512_0 = gclass512_1;
		}
		if (gclass462_1 == null)
		{
			this.gclass462_0 = new GClass462(0, null, 0, 0, 0.0, false, null, null);
			return;
		}
		this.gclass462_0 = gclass462_1;
	}

	public virtual int vmethod_0()
	{
		return 2001;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass512_0 = (GClass512)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass512_0 != null)
		{
			this.gclass512_0.imethod_1(binaryStream_0);
		}
		this.gclass462_0 = (GClass462)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass462_0 != null)
		{
			this.gclass462_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2001);
		if (this.gclass512_0 != null)
		{
			this.gclass512_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass462_0 != null)
		{
			this.gclass462_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass512 gclass512_0;

	public GClass462 gclass462_0;
}
