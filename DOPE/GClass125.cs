using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass125 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 101;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass125(Vector<GClass801> vector_3 = null, Vector<GClass707> vector_4 = null, Vector<GClass707> vector_5 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (vector_3 == null)
		{
			this.vector_0 = new Vector<GClass801>();
		}
		else
		{
			this.vector_0 = vector_3;
		}
		if (vector_4 == null)
		{
			this.vector_1 = new Vector<GClass707>();
		}
		else
		{
			this.vector_1 = vector_4;
		}
		if (vector_5 == null)
		{
			this.vector_2 = new Vector<GClass707>();
			return;
		}
		this.vector_2 = vector_5;
	}

	public virtual int vmethod_0()
	{
		return 101;
	}

	public virtual int vmethod_1()
	{
		return 12;
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
			GClass801 gclass = (GClass801)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		i = 0;
		num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass707 gclass2 = (GClass707)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			i++;
		}
		while (this.vector_2.Length > 0)
		{
			this.vector_2.method_1();
		}
		i = 0;
		num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass707 gclass3 = (GClass707)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass3.imethod_1(binaryStream_0);
			this.vector_2.method_0(gclass3);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(101);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass801 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteByte(this.vector_1.Length);
		foreach (GClass707 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteByte(this.vector_2.Length);
		foreach (GClass707 gclass3 in this.vector_2)
		{
			gclass3.imethod_2(binaryStream_0);
		}
	}

	public Vector<GClass801> vector_0;

	public Vector<GClass707> vector_1;

	public Vector<GClass707> vector_2;
}
