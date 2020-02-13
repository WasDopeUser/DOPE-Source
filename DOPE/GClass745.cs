using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass745 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27050;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass745(GClass178 gclass178_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass178_1 == null)
		{
			this.gclass178_0 = new GClass178(0U);
			return;
		}
		this.gclass178_0 = gclass178_1;
	}

	public virtual int vmethod_0()
	{
		return 27050;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass178_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass178);
		this.gclass178_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(27050);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass178_0.imethod_2(binaryStream_0);
	}

	public GClass178 gclass178_0;
}
