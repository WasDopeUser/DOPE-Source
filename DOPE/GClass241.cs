using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass241 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9151;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass241(int int_4 = 0, int int_5 = 0, int int_6 = 0, bool bool_1 = false, bool bool_2 = false, int int_7 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.int_3 = int_4;
		this.int_2 = int_5;
		this.int_1 = int_6;
		this.bool_0 = bool_1;
		this.jexwwYxUhq = bool_2;
		this.int_0 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 9151;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.jexwwYxUhq = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 7) | this.int_1 << 25);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 7 | U.smethod_0(this.int_3, 25));
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9151);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.jexwwYxUhq);
		binaryStream_0.smethod_4(this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		binaryStream_0.smethod_4(this.int_1 << 7 | U.smethod_0(this.int_1, 25));
		binaryStream_0.smethod_4(this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 7) | this.int_3 << 25);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public bool jexwwYxUhq;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public bool bool_0;
}
