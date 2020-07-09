using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass334 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -9857;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass334(Vector<GClass347> vector_1 = null, GClass347 gclass347_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass347>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass347_1 == null)
		{
			this.gclass347_0 = new GClass347(0, "", "", 0);
			return;
		}
		this.gclass347_0 = gclass347_1;
	}

	public virtual int vmethod_0()
	{
		return -9857;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass347 gclass = (GClass347)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.gclass347_0 = (GClass347)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass347_0 != null)
		{
			this.gclass347_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-9857);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass347 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		if (this.gclass347_0 != null)
		{
			this.gclass347_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public Vector<GClass347> vector_0;

	public GClass347 gclass347_0;
}
