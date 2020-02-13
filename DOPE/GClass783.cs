using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass783 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18301;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass783(GClass388 gclass388_0 = null, int int_1 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass388_0 == null)
		{
			this.jEhFpDkuCs = new GClass388();
		}
		else
		{
			this.jEhFpDkuCs = gclass388_0;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 18301;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.jEhFpDkuCs = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass388);
		this.jEhFpDkuCs.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(18301);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.smethod_6(3972);
		binaryStream_0.smethod_6(24214);
		this.jEhFpDkuCs.imethod_2(binaryStream_0);
	}

	public int int_0;

	public GClass388 jEhFpDkuCs;
}
