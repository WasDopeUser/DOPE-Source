using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass333 : GInterface0
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

	public GClass333(Vector<GClass346> vector_1 = null, GClass346 gclass346_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass346>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass346_1 == null)
		{
			this.gclass346_0 = new GClass346(0, "", "", 0);
			return;
		}
		this.gclass346_0 = gclass346_1;
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
			GClass346 gclass = (GClass346)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.gclass346_0 = (GClass346)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass346_0 != null)
		{
			this.gclass346_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-9857);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass346 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		if (this.gclass346_0 != null)
		{
			this.gclass346_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public Vector<GClass346> vector_0;

	public GClass346 gclass346_0;
}
