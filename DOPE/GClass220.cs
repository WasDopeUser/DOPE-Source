using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass220 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12414;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass220(GClass476 gclass476_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass476_1 == null)
		{
			this.gclass476_0 = new GClass476();
			return;
		}
		this.gclass476_0 = gclass476_1;
	}

	public virtual int vmethod_0()
	{
		return 12414;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass476_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass476);
		this.gclass476_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(12414);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass476_0.imethod_2(binaryStream_0);
	}

	public GClass476 gclass476_0;
}
