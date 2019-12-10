using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass280 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6566;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass280(GClass387 gclass387_1 = null, uint uint_1 = 0U)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass387_1 == null)
		{
			this.gclass387_0 = new GClass387();
		}
		else
		{
			this.gclass387_0 = gclass387_1;
		}
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 6566;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass387_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass387);
		this.gclass387_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(6566);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		this.gclass387_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(788);
	}

	public uint uint_0;

	public GClass387 gclass387_0;
}
