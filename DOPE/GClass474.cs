using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass474 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17412;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass474(GClass718 gclass718_1 = null, GClass569 gclass569_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass718_1 == null)
		{
			this.gclass718_0 = new GClass718(0, null);
		}
		else
		{
			this.gclass718_0 = gclass718_1;
		}
		if (gclass569_1 == null)
		{
			this.gclass569_0 = new GClass569(0, null);
			return;
		}
		this.gclass569_0 = gclass569_1;
	}

	public virtual int vmethod_0()
	{
		return 17412;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass718_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass718);
		this.gclass718_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass569_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass569);
		this.gclass569_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(17412);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass718_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(15153);
		binaryStream_0.smethod_5(27528);
		this.gclass569_0.imethod_2(binaryStream_0);
	}

	public GClass718 gclass718_0;

	public GClass569 gclass569_0;
}
