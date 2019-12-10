using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass138 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16470;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass138(int int_2 = 0, int int_3 = 0, int int_4 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Id = int_2;
		this.int_0 = int_3;
		this.int_1 = int_4;
	}

	public virtual int vmethod_0()
	{
		return 16470;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 14 | U.smethod_0(this.int_1, 18));
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 4) | this.Id << 28);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(16470);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 14) | this.int_1 << 18);
		binaryStream_0.fUeiimuocMk(this.Id << 4 | U.smethod_0(this.Id, 28));
	}

	public int int_0;

	public int int_1;

	public int Id;
}
