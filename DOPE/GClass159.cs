using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass159 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14615;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass159(GClass244 gclass244_1 = null, int int_1 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass244_1 == null)
		{
			this.gclass244_0 = new GClass244(0U);
		}
		else
		{
			this.gclass244_0 = gclass244_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 14615;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.gclass244_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass244);
		this.gclass244_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(14615);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(10977);
		binaryStream_0.smethod_5(this.int_0);
		this.gclass244_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public GClass244 gclass244_0;
}
