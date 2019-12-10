using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass162 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4167;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass162(GClass131 gclass131_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass131_1 == null)
		{
			this.gclass131_0 = new GClass131(null, 0.0);
			return;
		}
		this.gclass131_0 = gclass131_1;
	}

	public virtual int vmethod_0()
	{
		return 4167;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass131_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass131);
		this.gclass131_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(4167);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass131_0.imethod_2(binaryStream_0);
	}

	public GClass131 gclass131_0;
}
