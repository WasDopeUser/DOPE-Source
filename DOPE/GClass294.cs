using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass294 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1655;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass294(GClass403 gclass403_1 = null, uint uint_1 = 0U)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass403_1 == null)
		{
			this.gclass403_0 = new GClass403();
		}
		else
		{
			this.gclass403_0 = gclass403_1;
		}
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 1655;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass403_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass403);
		this.gclass403_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(1655);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(this.uint_0);
		this.gclass403_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(-13207);
	}

	public uint uint_0;

	public GClass403 gclass403_0;
}
