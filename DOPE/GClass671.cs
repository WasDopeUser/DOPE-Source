using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass671 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12826;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass671(uint uint_1 = 0U, GClass347 gclass347_1 = null, int int_1 = 0, bool bool_1 = false)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.uint_0 = uint_1;
		if (gclass347_1 == null)
		{
			this.gclass347_0 = new GClass347(0U);
		}
		else
		{
			this.gclass347_0 = gclass347_1;
		}
		this.int_0 = int_1;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 12826;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass347_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass347);
		this.gclass347_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(12826);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		binaryStream_0.smethod_7(17976);
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass347_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(21722);
		binaryStream_0.smethod_6(this.uint_0);
	}

	public int int_0;

	public bool bool_0;

	public GClass347 gclass347_0;

	public uint uint_0;
}
