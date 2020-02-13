using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass755 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19058;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass755(uint uint_1 = 0U, GClass772 gclass772_2 = null, GClass772 gclass772_3 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.uint_0 = uint_1;
		if (gclass772_2 == null)
		{
			this.gclass772_0 = new GClass772(0, 0, false);
		}
		else
		{
			this.gclass772_0 = gclass772_2;
		}
		if (gclass772_3 == null)
		{
			this.gclass772_1 = new GClass772(0, 0, false);
			return;
		}
		this.gclass772_1 = gclass772_3;
	}

	public virtual int vmethod_0()
	{
		return 19058;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass772_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass772);
		this.gclass772_0.imethod_1(binaryStream_0);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass772_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass772);
		this.gclass772_1.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(19058);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass772_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.smethod_6(26831);
		this.gclass772_1.imethod_2(binaryStream_0);
	}

	public GClass772 gclass772_0;

	public uint uint_0;

	public GClass772 gclass772_1;
}
