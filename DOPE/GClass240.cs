using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass240 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6117;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass240(int int_1 = 0, ByteArray byteArray_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.byteArray_0 = new ByteArray();
		this.int_0 = int_1;
		if (byteArray_1 != null)
		{
			this.byteArray_0 = byteArray_1;
		}
	}

	public virtual int vmethod_0()
	{
		return 6117;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		this.byteArray_0.Clear();
		binaryStream_0.smethod_9(this.byteArray_0, 0, binaryStream_0.smethod_0());
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(6117);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.fUeiimuocMk(this.byteArray_0.Length);
		binaryStream_0.smethod_10(this.byteArray_0, 0, this.byteArray_0.Length);
	}

	public int int_0;

	public ByteArray byteArray_0;
}
