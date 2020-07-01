using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass474 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2017;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass474(GClass490 gclass490_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass490_1 == null)
		{
			this.gclass490_0 = new GClass490(0, null, null, null, null, "", "");
			return;
		}
		this.gclass490_0 = gclass490_1;
	}

	public virtual int vmethod_0()
	{
		return 2017;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass490_0 = (GClass490)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass490_0 != null)
		{
			this.gclass490_0.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2017);
		if (this.gclass490_0 != null)
		{
			this.gclass490_0.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass490 gclass490_0;
}
