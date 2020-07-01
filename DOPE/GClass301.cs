using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass301 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4145;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass301(GClass406 gclass406_1 = null, int int_1 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass406_1 == null)
		{
			this.gclass406_0 = new GClass406();
		}
		else
		{
			this.gclass406_0 = gclass406_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 4145;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass406_0 = (GClass406)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass406_0 != null)
		{
			this.gclass406_0.imethod_0(binaryStream_0);
		}
		this.int_0 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4145);
		if (this.gclass406_0 != null)
		{
			this.gclass406_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_7(this.int_0);
	}

	public GClass406 gclass406_0;

	public int int_0;
}
