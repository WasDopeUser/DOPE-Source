using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass798 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11007;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass798(GClass394 gclass394_1 = null, int int_1 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass394_1 == null)
		{
			this.gclass394_0 = new GClass394();
		}
		else
		{
			this.gclass394_0 = gclass394_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 11007;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass394_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass394);
		this.gclass394_0.HrqIugnatr8(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11007);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass394_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
	}

	public GClass394 gclass394_0;

	public int int_0;
}
