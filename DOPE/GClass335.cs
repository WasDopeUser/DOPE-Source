using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass335 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22071;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass335(int int_2 = 0, int int_3 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_1 = int_2;
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 22071;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 14 | U.smethod_0(this.int_1, 18));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(22071);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(31833);
		binaryStream_0.fUeiimuocMk(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 14) | this.int_1 << 18);
	}

	public int int_0;

	public int int_1;
}
