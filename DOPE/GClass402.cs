using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass402 : GClass401, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5850;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass402(Vector<GClass617> vector_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass617>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public override int vmethod_0()
	{
		return 5850;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_0(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_0(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = (int)binaryStream_0.smethod_1();
		while (i < num)
		{
			GClass617 gclass = (GClass617)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_0(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5850);
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(this.vector_0.Length);
		foreach (GClass617 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
	}

	public Vector<GClass617> vector_0;
}
