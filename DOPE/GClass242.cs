using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass242 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25970;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass242(uint uint_1 = 0U, uint uint_2 = 0U, GClass500 gclass500_1 = null)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.Visibility = uint_1;
		this.uint_0 = uint_2;
		if (gclass500_1 == null)
		{
			this.gclass500_0 = new GClass500("", null, null);
			return;
		}
		this.gclass500_0 = gclass500_1;
	}

	public virtual int vmethod_0()
	{
		return 25970;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass500_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass500);
		this.gclass500_0.imethod_1(binaryStream_0);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.Visibility = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25970);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass500_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(-4364);
		binaryStream_0.smethod_6(this.Visibility);
	}

	public GClass500 gclass500_0;

	public uint uint_0;

	public uint Visibility;
}
