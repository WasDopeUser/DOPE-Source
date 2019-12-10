using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass424 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1688;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass424(int int_1 = 0, int int_2 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_0 = int_1;
		this.FlYqstAmJV = int_2;
	}

	public virtual int vmethod_0()
	{
		return 1688;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.FlYqstAmJV = binaryStream_0.smethod_0();
		this.FlYqstAmJV = (this.FlYqstAmJV << 5 | U.smethod_0(this.FlYqstAmJV, 27));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 10 | U.smethod_0(this.int_0, 22));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(1688);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(-16959);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.FlYqstAmJV, 5) | this.FlYqstAmJV << 27);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 10) | this.int_0 << 22);
	}

	public int FlYqstAmJV;

	public int int_0;
}
