using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass744 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18103;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass744(GClass556 gclass556_1 = null, uint uint_1 = 0U)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass556_1 == null)
		{
			this.gclass556_0 = new GClass556(null, 0U);
		}
		else
		{
			this.gclass556_0 = gclass556_1;
		}
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 18103;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass556_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass556);
		this.gclass556_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(18103);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.smethod_6(2221);
		this.gclass556_0.imethod_2(binaryStream_0);
	}

	public uint uint_0;

	public GClass556 gclass556_0;
}
