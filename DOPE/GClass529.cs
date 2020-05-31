using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass529 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15217;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass529(uint uint_1 = 0U, GClass545 gclass545_1 = null, int int_1 = 0, bool bool_1 = false)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.uint_0 = uint_1;
		if (gclass545_1 == null)
		{
			this.gclass545_0 = new GClass545(0U);
		}
		else
		{
			this.gclass545_0 = gclass545_1;
		}
		this.int_0 = int_1;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 15217;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass545_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass545);
		this.gclass545_0.HrqIugnatr8(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(15217);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11248);
		binaryStream_0.smethod_7(-178);
		this.gclass545_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_6(this.uint_0);
	}

	public GClass545 gclass545_0;

	public int int_0;

	public bool bool_0;

	public uint uint_0;
}
