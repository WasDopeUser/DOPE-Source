using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass361 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7790;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass361(int int_3 = 0, int int_4 = 0, bool bool_1 = false, int int_5 = 0, GClass325 gclass325_0 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.int_1 = int_3;
		this.int_2 = int_4;
		this.bool_0 = bool_1;
		this.int_0 = int_5;
		if (gclass325_0 == null)
		{
			this.kjttbJuelk = new GClass325(0U);
			return;
		}
		this.kjttbJuelk = gclass325_0;
	}

	public virtual int vmethod_0()
	{
		return 7790;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		this.kjttbJuelk = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass325);
		this.kjttbJuelk.HrqIugnatr8(binaryStream_0);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 15 | U.smethod_0(this.int_2, 17));
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7790);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		binaryStream_0.smethod_7(31273);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		this.kjttbJuelk.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 15) | this.int_2 << 17);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int int_0;

	public int int_1;

	public GClass325 kjttbJuelk;

	public int int_2;

	public bool bool_0;
}
