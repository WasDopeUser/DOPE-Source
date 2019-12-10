using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass427 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19940;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass427(GClass752 gclass752_1 = null, uint uint_1 = 0U, double double_1 = 0.0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass752_1 == null)
		{
			this.gclass752_0 = new GClass752(0U);
		}
		else
		{
			this.gclass752_0 = gclass752_1;
		}
		this.uint_0 = uint_1;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 19940;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass752_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass752);
		this.gclass752_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(19940);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(-21573);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		this.gclass752_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-30335);
	}

	public double double_0;

	public uint uint_0;

	public GClass752 gclass752_0;
}
