using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass702 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6825;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass702(uint uint_2 = 0U, uint uint_3 = 0U, GClass354 gclass354_1 = null)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.uint_1 = uint_2;
		this.uint_0 = uint_3;
		if (gclass354_1 == null)
		{
			this.gclass354_0 = new GClass354();
			return;
		}
		this.gclass354_0 = gclass354_1;
	}

	public virtual int vmethod_0()
	{
		return 6825;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.uint_1 = (uint)binaryStream_0.smethod_1();
		this.gclass354_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass354);
		this.gclass354_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6825);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_6(this.uint_1);
		this.gclass354_0.imethod_2(binaryStream_0);
	}

	public uint uint_0;

	public uint uint_1;

	public GClass354 gclass354_0;
}
