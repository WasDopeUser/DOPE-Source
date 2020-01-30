using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass240 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21709;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass240(int int_4 = 0, int int_5 = 0, int int_6 = 0, bool bool_2 = false, bool bool_3 = false, int int_7 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_1 = int_4;
		this.int_0 = int_5;
		this.int_3 = int_6;
		this.bool_0 = bool_2;
		this.bool_1 = bool_3;
		this.int_2 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 21709;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 2 | U.smethod_0(this.int_3, 30));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21709);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_4(this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		binaryStream_0.smethod_4(this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 2) | this.int_3 << 30);
	}

	public bool bool_0;

	public bool bool_1;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;
}
