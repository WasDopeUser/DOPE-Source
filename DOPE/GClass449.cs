using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass449 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25341;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass449(GClass752 gclass752_1 = null, double double_2 = 0.0, double double_3 = 0.0)
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
		this.double_1 = double_2;
		this.double_0 = double_3;
	}

	public virtual int vmethod_0()
	{
		return 25341;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass752_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass752);
		this.gclass752_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.double_0 = (double)binaryStream_0.smethod_8();
		binaryStream_0.smethod_1();
		this.double_1 = (double)binaryStream_0.smethod_8();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(25341);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass752_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(32716);
		binaryStream_0.smethod_7(this.double_0);
		binaryStream_0.smethod_5(-27539);
		binaryStream_0.smethod_7(this.double_1);
	}

	public GClass752 gclass752_0;

	public double double_0;

	public double double_1;
}
