using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass687 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4388;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass687(GClass271 gclass271_1 = null, GClass530 gclass530_1 = null, GClass417 gclass417_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass271_1 == null)
		{
			this.gclass271_0 = new GClass271(null);
		}
		else
		{
			this.gclass271_0 = gclass271_1;
		}
		if (gclass530_1 == null)
		{
			this.gclass530_0 = new GClass530(false, false, false, false);
		}
		else
		{
			this.gclass530_0 = gclass530_1;
		}
		if (gclass417_1 == null)
		{
			this.gclass417_0 = new GClass417(false);
			return;
		}
		this.gclass417_0 = gclass417_1;
	}

	public virtual int vmethod_0()
	{
		return 4388;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass530_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass530);
		this.gclass530_0.imethod_1(binaryStream_0);
		this.gclass417_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass417);
		this.gclass417_0.imethod_1(binaryStream_0);
		this.gclass271_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass271);
		this.gclass271_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(4388);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass530_0.imethod_2(binaryStream_0);
		this.gclass417_0.imethod_2(binaryStream_0);
		this.gclass271_0.imethod_2(binaryStream_0);
	}

	public GClass530 gclass530_0;

	public GClass417 gclass417_0;

	public GClass271 gclass271_0;
}
