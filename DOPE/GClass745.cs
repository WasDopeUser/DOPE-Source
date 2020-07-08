using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass745 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4715;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass745(GClass847 gclass847_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass847_1 == null)
		{
			this.gclass847_0 = new GClass847(0);
			return;
		}
		this.gclass847_0 = gclass847_1;
	}

	public virtual int vmethod_0()
	{
		return 4715;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass847_0 = (GClass847)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass847_0 != null)
		{
			this.gclass847_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4715);
		if (this.gclass847_0 != null)
		{
			this.gclass847_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass847 gclass847_0;
}
