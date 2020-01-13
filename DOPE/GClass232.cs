using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass232 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29973;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass232(GClass488 gclass488_1 = null)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (gclass488_1 == null)
		{
			this.gclass488_0 = new GClass488();
			return;
		}
		this.gclass488_0 = gclass488_1;
	}

	public virtual int vmethod_0()
	{
		return 29973;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass488_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass488);
		this.gclass488_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29973);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass488_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(12895);
		binaryStream_0.smethod_7(6934);
	}

	public GClass488 gclass488_0;
}
