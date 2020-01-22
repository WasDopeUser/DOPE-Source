using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass293 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10585;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass293(GClass402 gclass402_1 = null, uint uint_1 = 0U)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (gclass402_1 == null)
		{
			this.gclass402_0 = new GClass402();
		}
		else
		{
			this.gclass402_0 = gclass402_1;
		}
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 10585;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass402_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass402);
		this.gclass402_0.imethod_1(binaryStream_0);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10585);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass402_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(this.uint_0);
	}

	public GClass402 gclass402_0;

	public uint uint_0;
}
