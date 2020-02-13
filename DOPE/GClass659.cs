using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass659 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7265;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass659(GClass763 gclass763_1 = null, uint uint_1 = 0U)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass763_1 == null)
		{
			this.gclass763_0 = new GClass763(0U);
		}
		else
		{
			this.gclass763_0 = gclass763_1;
		}
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 7265;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass763_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass763);
		this.gclass763_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(7265);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.smethod_6(15453);
		this.gclass763_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(26534);
	}

	public uint uint_0;

	public GClass763 gclass763_0;
}
