using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass799 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2863;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass799(GClass195 gclass195_0 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass195_0 == null)
		{
			this.Mode = new GClass195(0);
			return;
		}
		this.Mode = gclass195_0;
	}

	public virtual int vmethod_0()
	{
		return 2863;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Mode = (GClass195)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.Mode != null)
		{
			this.Mode.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2863);
		if (this.Mode != null)
		{
			this.Mode.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass195 Mode;
}
