using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass690 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1917;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass690(GClass681 gclass681_1 = null, int int_2 = 0, int int_3 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass681_1 == null)
		{
			this.gclass681_0 = new GClass681();
		}
		else
		{
			this.gclass681_0 = gclass681_1;
		}
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 1917;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 8 | U.smethod_0(this.int_1, 24));
		this.gclass681_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass681);
		this.gclass681_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(1917);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(18176);
		binaryStream_0.fUeiimuocMk(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 8) | this.int_1 << 24);
		this.gclass681_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public int int_1;

	public GClass681 gclass681_0;
}
