using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass349 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19388;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass349(Vector<GClass553> vector_1 = null, GClass553 gclass553_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass553_1 == null)
		{
			this.gclass553_0 = new GClass553(0, "", "", 0);
		}
		else
		{
			this.gclass553_0 = gclass553_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass553>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 19388;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass553_0 = (GClass553)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass553_0 != null)
		{
			this.gclass553_0.imethod_1(binaryStream_0);
		}
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass553 gclass = (GClass553)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19388);
		if (this.gclass553_0 != null)
		{
			this.gclass553_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass553 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public GClass553 gclass553_0;

	public Vector<GClass553> vector_0;
}
