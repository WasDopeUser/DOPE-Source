using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass468 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4155;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass468(GClass484 gclass484_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass484_1 == null)
		{
			this.gclass484_0 = new GClass484(0, null, null, null, null, "", "");
			return;
		}
		this.gclass484_0 = gclass484_1;
	}

	public virtual int vmethod_0()
	{
		return 4155;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass484_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass484);
		this.gclass484_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(4155);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass484_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(-27903);
		binaryStream_0.smethod_6(880);
	}

	public GClass484 gclass484_0;
}
