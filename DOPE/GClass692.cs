using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass692 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28753;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass692(uint uint_2 = 0U, uint uint_3 = 0U, GClass338 gclass338_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.uint_0 = uint_2;
		this.uint_1 = uint_3;
		if (gclass338_1 == null)
		{
			this.gclass338_0 = new GClass338();
			return;
		}
		this.gclass338_0 = gclass338_1;
	}

	public virtual int vmethod_0()
	{
		return 28753;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass338_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass338);
		this.gclass338_0.imethod_1(binaryStream_0);
		this.uint_1 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(28753);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		this.gclass338_0.imethod_2(binaryStream_0);
		binaryStream_0.lwAiiEjwcUm(this.uint_1);
	}

	public uint uint_0;

	public GClass338 gclass338_0;

	public uint uint_1;
}
