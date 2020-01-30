using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass285 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29843;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass285(int int_1 = 0, GClass480 gclass480_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_0 = int_1;
		if (gclass480_1 == null)
		{
			this.gclass480_0 = new GClass480(false, 0);
			return;
		}
		this.gclass480_0 = gclass480_1;
	}

	public virtual int vmethod_0()
	{
		return 29843;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass480_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass480);
		this.gclass480_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 16 | U.smethod_0(this.int_0, 16));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29843);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass480_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 16) | this.int_0 << 16);
	}

	public GClass480 gclass480_0;

	public int int_0;
}
