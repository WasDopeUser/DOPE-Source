using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass737 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30885;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass737(GClass196 gclass196_0 = null)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (gclass196_0 == null)
		{
			this.Mode = new GClass196(0U);
			return;
		}
		this.Mode = gclass196_0;
	}

	public virtual int vmethod_0()
	{
		return 30885;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Mode = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass196);
		this.Mode.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30885);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.Mode.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-20339);
	}

	public GClass196 Mode;
}
