using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass387 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12868;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass387(bool bool_1 = false, int int_2 = 0, int int_3 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.bool_0 = bool_1;
		this.int_1 = int_2;
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 12868;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(12868);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		binaryStream_0.smethod_3(this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		binaryStream_0.smethod_6(-19342);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_6(-17269);
	}

	public int int_0;

	public int int_1;

	public bool bool_0;
}
