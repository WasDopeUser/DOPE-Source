using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass603 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -5347;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass603(GClass286 gclass286_1 = null, bool bool_1 = false)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass286_1 == null)
		{
			this.gclass286_0 = new GClass286(0);
		}
		else
		{
			this.gclass286_0 = gclass286_1;
		}
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return -5347;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass286_0 = (GClass286)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass286_0 != null)
		{
			this.gclass286_0.imethod_0(binaryStream_0);
		}
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-5347);
		if (this.gclass286_0 != null)
		{
			this.gclass286_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public GClass286 gclass286_0;

	public bool bool_0;
}
