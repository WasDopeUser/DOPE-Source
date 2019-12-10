using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass539 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11867;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass539(bool bool_1 = false, GClass349 gclass349_2 = null, GClass349 gclass349_3 = null, GClass500 gclass500_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.bool_0 = bool_1;
		if (gclass349_2 == null)
		{
			this.gclass349_1 = new GClass349("", 0, 0, 0, 0, 0, 0, 0.0);
		}
		else
		{
			this.gclass349_1 = gclass349_2;
		}
		if (gclass349_3 == null)
		{
			this.gclass349_0 = new GClass349("", 0, 0, 0, 0, 0, 0, 0.0);
		}
		else
		{
			this.gclass349_0 = gclass349_3;
		}
		if (gclass500_1 == null)
		{
			this.gclass500_0 = new GClass500("");
			return;
		}
		this.gclass500_0 = gclass500_1;
	}

	public virtual int vmethod_0()
	{
		return 11867;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass500_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass500);
		this.gclass500_0.imethod_1(binaryStream_0);
		this.gclass349_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass349);
		this.gclass349_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass349_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass349);
		this.gclass349_1.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(11867);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass500_0.imethod_2(binaryStream_0);
		this.gclass349_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-2068);
		this.gclass349_1.imethod_2(binaryStream_0);
	}

	public bool bool_0;

	public GClass500 gclass500_0;

	public GClass349 gclass349_0;

	public GClass349 gclass349_1;
}
