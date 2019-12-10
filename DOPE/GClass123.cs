using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass123 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27310;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass123(GClass126 gclass126_1 = null, int int_1 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass126_1 == null)
		{
			this.gclass126_0 = new GClass126(0U);
		}
		else
		{
			this.gclass126_0 = gclass126_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 27310;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		this.gclass126_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass126);
		this.gclass126_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(27310);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		this.gclass126_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public GClass126 gclass126_0;
}
