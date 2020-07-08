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

	public GClass547(Vector<GClass376> vector_1 = null, GClass692 gclass692_1 = null, int int_0 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass376>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass692_1 == null)
		{
			this.gclass692_0 = new GClass692(0, 0);
		}
		else
		{
			this.gclass692_0 = gclass692_1;
		}
		this.lVuMbHuGju = int_0;
	}

	public virtual int vmethod_0()
	{
		return -15125;
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
			GClass376 gclass = (GClass376)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.gclass692_0 = (GClass692)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass692_0 != null)
		{
			this.gclass692_0.imethod_1(binaryStream_0);
		}
		this.lVuMbHuGju = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-15125);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass376 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		if (this.gclass692_0 != null)
		{
			this.gclass692_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_7(this.lVuMbHuGju);
	}

	public Vector<GClass376> vector_0;

	public GClass692 gclass692_0;

	public int lVuMbHuGju;
}
