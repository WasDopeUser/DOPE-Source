using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass344 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7167;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass344(uint uint_0 = 0U, int int_2 = 0, int int_3 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.RydJzxvUtQ = uint_0;
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 7167;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.RydJzxvUtQ = (uint)binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 7 | U.smethod_0(this.int_1, 25));
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(7167);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.lwAiiEjwcUm(this.RydJzxvUtQ);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 7) | this.int_1 << 25);
		binaryStream_0.smethod_5(9509);
		binaryStream_0.smethod_5(-31656);
	}

	public int int_0;

	public uint RydJzxvUtQ;

	public int int_1;
}
