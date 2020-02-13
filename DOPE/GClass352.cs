using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass352 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32327;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 17;
		}
	}

	public GClass352(uint uint_1 = 0U, int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, bool bool_1 = false)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.uint_0 = uint_1;
		this.int_3 = int_4;
		this.int_1 = int_5;
		this.int_0 = int_6;
		this.int_2 = int_7;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 32327;
	}

	public virtual int vmethod_1()
	{
		return 17;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 14) | this.int_2 << 18);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 1) | this.int_3 << 31);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(32327);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		binaryStream_0.smethod_6(16241);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_6(-15169);
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.smethod_3(this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		binaryStream_0.smethod_3(this.int_2 << 14 | U.smethod_0(this.int_2, 18));
		binaryStream_0.smethod_3(this.int_3 << 1 | U.smethod_0(this.int_3, 31));
	}

	public int int_0;

	public bool bool_0;

	public uint uint_0;

	public int int_1;

	public int int_2;

	public int int_3;
}
