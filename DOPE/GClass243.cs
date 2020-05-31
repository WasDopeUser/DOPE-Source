using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass243 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20059;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass243(uint uint_1 = 0U, uint uint_2 = 0U, GClass512 gclass512_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.Visibility = uint_1;
		this.uint_0 = uint_2;
		if (gclass512_1 == null)
		{
			this.gclass512_0 = new GClass512("", null, null);
			return;
		}
		this.gclass512_0 = gclass512_1;
	}

	public virtual int vmethod_0()
	{
		return 20059;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass512_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass512);
		this.gclass512_0.HrqIugnatr8(binaryStream_0);
		this.Visibility = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20059);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(-23848);
		this.gclass512_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_6(this.Visibility);
		binaryStream_0.smethod_7(13200);
	}

	public uint uint_0;

	public GClass512 gclass512_0;

	public uint Visibility;
}
