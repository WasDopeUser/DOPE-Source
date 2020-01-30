using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass706 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9542;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass706(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, bool bool_2 = false, bool bool_3 = false)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_2 = int_4;
		this.int_0 = int_5;
		this.int_3 = int_6;
		this.int_1 = int_7;
		this.bool_1 = bool_2;
		this.bool_0 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 9542;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 7) | this.int_2 << 25);
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 1) | this.int_3 << 31);
		this.bool_1 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9542);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11691);
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.smethod_4(this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		binaryStream_0.smethod_4(this.int_2 << 7 | U.smethod_0(this.int_2, 25));
		binaryStream_0.smethod_7(-9736);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_3 << 1 | U.smethod_0(this.int_3, 31));
		binaryStream_0.WriteBoolean(this.bool_1);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public bool bool_0;

	public int int_3;

	public bool bool_1;
}
