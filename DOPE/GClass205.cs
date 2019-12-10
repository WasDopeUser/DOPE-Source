using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass205 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24240;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass205(ByteArray byteArray_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.byteArray_0 = new ByteArray();
		if (byteArray_1 != null)
		{
			this.byteArray_0 = byteArray_1;
		}
	}

	public virtual int vmethod_0()
	{
		return 24240;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.byteArray_0.Clear();
		binaryStream_0.smethod_9(this.byteArray_0, 0, binaryStream_0.smethod_0());
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(24240);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.byteArray_0.Length);
		binaryStream_0.smethod_10(this.byteArray_0, 0, this.byteArray_0.Length);
		binaryStream_0.smethod_5(-25862);
	}

	public ByteArray byteArray_0;
}
