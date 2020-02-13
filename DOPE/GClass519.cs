using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass519 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24453;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass519(uint uint_1 = 0U, GClass534 gclass534_1 = null, int int_1 = 0, bool bool_1 = false)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.uint_0 = uint_1;
		if (gclass534_1 == null)
		{
			this.gclass534_0 = new GClass534(0U);
		}
		else
		{
			this.gclass534_0 = gclass534_1;
		}
		this.int_0 = int_1;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 24453;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass534_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass534);
		this.gclass534_0.imethod_1(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(24453);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(11107);
		this.gclass534_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.smethod_5(this.uint_0);
	}

	public GClass534 gclass534_0;

	public bool bool_0;

	public int int_0;

	public uint uint_0;
}
