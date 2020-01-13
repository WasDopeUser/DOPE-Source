using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass689 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22396;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass689(GClass782 gclass782_1 = null)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (gclass782_1 == null)
		{
			this.gclass782_0 = new GClass782(0U);
			return;
		}
		this.gclass782_0 = gclass782_1;
	}

	public virtual int vmethod_0()
	{
		return 22396;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass782_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass782);
		this.gclass782_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22396);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-18154);
		this.gclass782_0.imethod_2(binaryStream_0);
	}

	public GClass782 gclass782_0;
}
