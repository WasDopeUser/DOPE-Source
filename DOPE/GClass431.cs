using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass431 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17004;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass431(GClass304 gclass304_1 = null, int int_1 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass304_1 == null)
		{
			this.gclass304_0 = new GClass304(0U);
		}
		else
		{
			this.gclass304_0 = gclass304_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 17004;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		binaryStream_0.smethod_1();
		this.gclass304_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass304);
		this.gclass304_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(17004);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(-27547);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.smethod_5(13193);
		this.gclass304_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public GClass304 gclass304_0;
}
