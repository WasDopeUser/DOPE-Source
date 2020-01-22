using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass369 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27673;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass369(Vector<GClass284> vector_0 = null)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (vector_0 == null)
		{
			this.rVauDuYdkZ = new Vector<GClass284>();
			return;
		}
		this.rVauDuYdkZ = vector_0;
	}

	public virtual int vmethod_0()
	{
		return 27673;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		while (this.rVauDuYdkZ.Length > 0)
		{
			this.rVauDuYdkZ.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass284 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass284;
			gclass.imethod_1(binaryStream_0);
			this.rVauDuYdkZ.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27673);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13489);
		binaryStream_0.smethod_4(this.rVauDuYdkZ.Length);
		foreach (GClass284 gclass in this.rVauDuYdkZ)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public Vector<GClass284> rVauDuYdkZ;
}
