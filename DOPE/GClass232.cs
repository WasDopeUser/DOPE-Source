using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass232 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5083;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass232(GClass488 gclass488_0 = null)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (gclass488_0 == null)
		{
			this.AieazdqBp0 = new GClass488();
			return;
		}
		this.AieazdqBp0 = gclass488_0;
	}

	public virtual int vmethod_0()
	{
		return 5083;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.AieazdqBp0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass488);
		this.AieazdqBp0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5083);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19600);
		this.AieazdqBp0.imethod_2(binaryStream_0);
	}

	public GClass488 AieazdqBp0;
}
