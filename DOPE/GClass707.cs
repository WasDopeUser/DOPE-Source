using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass707 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28350;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass707(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, bool bool_2 = false, bool bool_3 = false)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_1 = int_4;
		this.int_2 = int_5;
		this.int_0 = int_6;
		this.int_3 = int_7;
		this.bool_0 = bool_2;
		this.bool_1 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 28350;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 12 | U.smethod_0(this.int_2, 20));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 2 | U.smethod_0(this.int_3, 30));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(28350);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_3(this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 12) | this.int_2 << 20);
		binaryStream_0.smethod_3(U.smethod_0(this.int_3, 2) | this.int_3 << 30);
	}

	public bool bool_0;

	public int int_0;

	public int int_1;

	public bool bool_1;

	public int int_2;

	public int int_3;
}
