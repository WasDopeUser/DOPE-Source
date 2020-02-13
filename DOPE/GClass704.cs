using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass704 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16986;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass704(uint uint_2 = 0U, uint uint_3 = 0U, GClass356 gclass356_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.uint_1 = uint_2;
		this.uint_0 = uint_3;
		if (gclass356_1 == null)
		{
			this.gclass356_0 = new GClass356();
			return;
		}
		this.gclass356_0 = gclass356_1;
	}

	public virtual int vmethod_0()
	{
		return 16986;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass356_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass356);
		this.gclass356_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.uint_1 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(16986);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-15037);
		binaryStream_0.smethod_5(this.uint_0);
		this.gclass356_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(14434);
		binaryStream_0.smethod_5(this.uint_1);
	}

	public uint uint_0;

	public GClass356 gclass356_0;

	public uint uint_1;
}
