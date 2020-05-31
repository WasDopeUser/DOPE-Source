using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass705 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18075;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass705(GClass799 gclass799_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass799_1 == null)
		{
			this.gclass799_0 = new GClass799(0U);
			return;
		}
		this.gclass799_0 = gclass799_1;
	}

	public virtual int vmethod_0()
	{
		return 18075;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass799_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass799);
		this.gclass799_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18075);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1013);
		binaryStream_0.smethod_7(23264);
		this.gclass799_0.imethod_1(binaryStream_0);
	}

	public GClass799 gclass799_0;
}
