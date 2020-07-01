using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass547 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -15125;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass547(Vector<GClass376> vector_1 = null, GClass693 gclass693_1 = null, int int_1 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass376>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass693_1 == null)
		{
			this.gclass693_0 = new GClass693(0, 0);
		}
		else
		{
			this.gclass693_0 = gclass693_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return -15125;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass376 gclass = (GClass376)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_0(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.gclass693_0 = (GClass693)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass693_0 != null)
		{
			this.gclass693_0.imethod_0(binaryStream_0);
		}
		this.int_0 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-15125);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass376 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		if (this.gclass693_0 != null)
		{
			this.gclass693_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_7(this.int_0);
	}

	public Vector<GClass376> vector_0;

	public GClass693 gclass693_0;

	public int int_0;
}
