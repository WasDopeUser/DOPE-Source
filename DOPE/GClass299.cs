using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass299 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16526;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass299(GClass409 gclass409_1 = null, uint uint_1 = 0U)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass409_1 == null)
		{
			this.gclass409_0 = new GClass409();
		}
		else
		{
			this.gclass409_0 = gclass409_1;
		}
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 16526;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass409_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass409);
		this.gclass409_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16526);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.uint_0);
		this.gclass409_0.imethod_1(binaryStream_0);
	}

	public uint uint_0;

	public GClass409 gclass409_0;
}
