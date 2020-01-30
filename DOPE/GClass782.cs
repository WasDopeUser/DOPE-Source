using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass782 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13101;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass782(GClass386 gclass386_1 = null, int int_1 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass386_1 == null)
		{
			this.gclass386_0 = new GClass386();
		}
		else
		{
			this.gclass386_0 = gclass386_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 13101;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass386_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass386);
		this.gclass386_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 10) | this.int_0 << 22);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13101);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass386_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 10 | U.smethod_0(this.int_0, 22));
	}

	public GClass386 gclass386_0;

	public int int_0;
}
