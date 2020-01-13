using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass517 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22547;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass517(uint uint_1 = 0U, GClass532 gclass532_1 = null, int int_1 = 0, bool bool_1 = false)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.uint_0 = uint_1;
		if (gclass532_1 == null)
		{
			this.gclass532_0 = new GClass532(0U);
		}
		else
		{
			this.gclass532_0 = gclass532_1;
		}
		this.int_0 = int_1;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 22547;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass532_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass532);
		this.gclass532_0.imethod_1(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22547);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass532_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		binaryStream_0.smethod_6(this.uint_0);
	}

	public GClass532 gclass532_0;

	public bool bool_0;

	public int int_0;

	public uint uint_0;
}
