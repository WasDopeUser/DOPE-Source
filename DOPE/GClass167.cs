using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass167 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 255;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass167(GClass258 gclass258_1 = null, GClass238 gclass238_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass258_1 == null)
		{
			this.gclass258_0 = new GClass258(0);
		}
		else
		{
			this.gclass258_0 = gclass258_1;
		}
		if (gclass238_1 == null)
		{
			this.gclass238_0 = new GClass238(0, 0, "", "", 0);
			return;
		}
		this.gclass238_0 = gclass238_1;
	}

	public virtual int vmethod_0()
	{
		return 255;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass258_0 = (GClass258)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass258_0 != null)
		{
			this.gclass258_0.imethod_0(binaryStream_0);
		}
		this.gclass238_0 = (GClass238)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass238_0 != null)
		{
			this.gclass238_0.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(255);
		if (this.gclass258_0 != null)
		{
			this.gclass258_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass238_0 != null)
		{
			this.gclass238_0.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass258 gclass258_0;

	public GClass238 gclass238_0;
}
