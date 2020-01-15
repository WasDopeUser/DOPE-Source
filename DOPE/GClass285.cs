using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass285 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16878;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass285(int int_1 = 0, GClass481 gclass481_1 = null)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.int_0 = int_1;
		if (gclass481_1 == null)
		{
			this.gclass481_0 = new GClass481(false, 0);
			return;
		}
		this.gclass481_0 = gclass481_1;
	}

	public virtual int vmethod_0()
	{
		return 16878;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		this.gclass481_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass481);
		this.gclass481_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16878);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		this.gclass481_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public GClass481 gclass481_0;
}
