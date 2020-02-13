using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass133 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24634;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass133(int int_3 = 0, int int_4 = 0, int int_5 = 0, bool bool_1 = false)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_2 = int_3;
		this.int_0 = int_4;
		this.int_1 = int_5;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 24634;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 8) | this.int_1 << 24);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 6 | U.smethod_0(this.int_2, 26));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(24634);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		binaryStream_0.smethod_6(10303);
		binaryStream_0.smethod_6(-5229);
		binaryStream_0.smethod_3(this.int_1 << 8 | U.smethod_0(this.int_1, 24));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 6) | this.int_2 << 26);
	}

	public int int_0;

	public int int_1;

	public bool bool_0;

	public int int_2;
}
