using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass163 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5509;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass163(GClass258 gclass258_1 = null, int int_1 = 0)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		if (gclass258_1 == null)
		{
			this.gclass258_0 = new GClass258(0U);
		}
		else
		{
			this.gclass258_0 = gclass258_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 5509;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.gclass258_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass258);
		this.gclass258_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5509);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(this.int_0);
		this.gclass258_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public GClass258 gclass258_0;
}
