using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass348 : GInterface0
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

	public GClass348(Vector<GClass552> vector_1 = null, GClass552 gclass552_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass552_1 == null)
		{
			this.gclass552_0 = new GClass552(0, "", "", 0);
		}
		else
		{
			this.gclass552_0 = gclass552_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass552>();
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

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass552_0 = (GClass552)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass552_0 != null)
		{
			this.gclass552_0.imethod_0(binaryStream_0);
		}
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass552 gclass = (GClass552)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_0(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19388);
		if (this.gclass552_0 != null)
		{
			this.gclass552_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass552 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
	}

	public GClass552 gclass552_0;

	public Vector<GClass552> vector_0;
}
