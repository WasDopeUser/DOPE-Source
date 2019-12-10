using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass629 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22710;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass629(GClass135 gclass135_1 = null, int int_2 = 0, int int_3 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass135_1 == null)
		{
			this.gclass135_0 = new GClass135(0U);
		}
		else
		{
			this.gclass135_0 = gclass135_1;
		}
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 22710;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		this.gclass135_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass135);
		this.gclass135_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 3 | U.smethod_0(this.int_1, 29));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(22710);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		this.gclass135_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-13565);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 3) | this.int_1 << 29);
	}

	public int int_0;

	public GClass135 gclass135_0;

	public int int_1;
}
