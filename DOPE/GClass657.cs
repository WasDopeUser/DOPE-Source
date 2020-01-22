using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass657 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18827;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass657(GClass761 gclass761_1 = null, uint uint_1 = 0U)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (gclass761_1 == null)
		{
			this.gclass761_0 = new GClass761(0U);
		}
		else
		{
			this.gclass761_0 = gclass761_1;
		}
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 18827;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass761_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass761);
		this.gclass761_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18827);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-28972);
		this.gclass761_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(4777);
		binaryStream_0.smethod_6(this.uint_0);
	}

	public GClass761 gclass761_0;

	public uint uint_0;
}
