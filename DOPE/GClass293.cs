using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass293 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4443;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass293(GClass401 gclass401_1 = null, uint uint_1 = 0U)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass401_1 == null)
		{
			this.gclass401_0 = new GClass401();
		}
		else
		{
			this.gclass401_0 = gclass401_1;
		}
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 4443;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass401_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass401);
		this.gclass401_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4443);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.uint_0);
		this.gclass401_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-9159);
	}

	public uint uint_0;

	public GClass401 gclass401_0;
}
