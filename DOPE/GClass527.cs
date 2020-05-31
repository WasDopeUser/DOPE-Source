using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass527 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14128;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass527(int int_1 = 0, GClass666 gclass666_0 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.int_0 = int_1;
		if (gclass666_0 == null)
		{
			this.State = new GClass666(0.0, false, false);
			return;
		}
		this.State = gclass666_0;
	}

	public virtual int vmethod_0()
	{
		return 14128;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.State = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass666);
		this.State.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 6) | this.int_0 << 26);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14128);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.State.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(2060);
		binaryStream_0.smethod_4(this.int_0 << 6 | U.smethod_0(this.int_0, 26));
	}

	public GClass666 State;

	public int int_0;
}
