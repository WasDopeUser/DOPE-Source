using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass229 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11132;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass229(uint uint_1 = 0U, uint uint_2 = 0U, GClass488 gclass488_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Visibility = uint_1;
		this.uint_0 = uint_2;
		if (gclass488_1 == null)
		{
			this.gclass488_0 = new GClass488("", null, null);
			return;
		}
		this.gclass488_0 = gclass488_1;
	}

	public virtual int vmethod_0()
	{
		return 11132;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass488_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass488);
		this.gclass488_0.imethod_1(binaryStream_0);
		this.Visibility = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(11132);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		this.gclass488_0.imethod_2(binaryStream_0);
		binaryStream_0.lwAiiEjwcUm(this.Visibility);
		binaryStream_0.smethod_5(-14925);
	}

	public uint uint_0;

	public GClass488 gclass488_0;

	public uint Visibility;
}
