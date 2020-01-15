using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass216 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4972;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass216(ByteArray byteArray_1 = null)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.byteArray_0 = new ByteArray();
		if (byteArray_1 != null)
		{
			this.byteArray_0 = byteArray_1;
		}
	}

	public virtual int vmethod_0()
	{
		return 4972;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.byteArray_0.Clear();
		binaryStream_0.smethod_11(this.byteArray_0, 0, binaryStream_0.smethod_0());
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4972);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-25268);
		binaryStream_0.smethod_4(this.byteArray_0.Length);
		binaryStream_0.smethod_12(this.byteArray_0, 0, this.byteArray_0.Length);
	}

	public ByteArray byteArray_0;
}
