using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass437 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 415;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass437(int int_2 = 0, int int_3 = 0, double double_1 = 0.0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_1 = int_2;
		this.int_0 = int_3;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 415;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.double_0 = binaryStream_0.ReadDouble();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(415);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(-7764);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		binaryStream_0.smethod_5(25651);
	}

	public int int_0;

	public double double_0;

	public int int_1;
}
