using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass272 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24050;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass272(int int_1 = 0, GClass467 gclass467_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_0 = int_1;
		if (gclass467_1 == null)
		{
			this.gclass467_0 = new GClass467(false, 0);
			return;
		}
		this.gclass467_0 = gclass467_1;
	}

	public virtual int vmethod_0()
	{
		return 24050;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.smethod_1();
		this.gclass467_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass467);
		this.gclass467_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(24050);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		binaryStream_0.smethod_5(-3436);
		this.gclass467_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public GClass467 gclass467_0;
}
