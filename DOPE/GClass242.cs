using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass242 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12666;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass242(uint uint_1 = 0U, uint uint_2 = 0U, GClass501 gclass501_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.Visibility = uint_1;
		this.uint_0 = uint_2;
		if (gclass501_1 == null)
		{
			this.gclass501_0 = new GClass501("", null, null);
			return;
		}
		this.gclass501_0 = gclass501_1;
	}

	public virtual int vmethod_0()
	{
		return 12666;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Visibility = (uint)binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass501_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass501);
		this.gclass501_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(12666);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.Visibility);
		binaryStream_0.smethod_6(this.uint_0);
		this.gclass501_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(9622);
	}

	public uint Visibility;

	public uint uint_0;

	public GClass501 gclass501_0;
}
