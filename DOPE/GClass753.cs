using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass753 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5424;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass753(uint uint_1 = 0U, GClass770 gclass770_2 = null, GClass770 gclass770_3 = null)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.uint_0 = uint_1;
		if (gclass770_2 == null)
		{
			this.gclass770_0 = new GClass770(0, 0, false);
		}
		else
		{
			this.gclass770_0 = gclass770_2;
		}
		if (gclass770_3 == null)
		{
			this.gclass770_1 = new GClass770(0, 0, false);
			return;
		}
		this.gclass770_1 = gclass770_3;
	}

	public virtual int vmethod_0()
	{
		return 5424;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass770_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass770);
		this.gclass770_0.imethod_1(binaryStream_0);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass770_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass770);
		this.gclass770_1.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5424);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass770_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(-14780);
		this.gclass770_1.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(28306);
	}

	public GClass770 gclass770_0;

	public uint uint_0;

	public GClass770 gclass770_1;
}
