using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass755 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6667;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass755(Vector<GClass772> vector_3 = null, Vector<GClass675> vector_4 = null, Vector<GClass566> vector_5 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (vector_3 == null)
		{
			this.vector_0 = new Vector<GClass772>();
		}
		else
		{
			this.vector_0 = vector_3;
		}
		if (vector_4 == null)
		{
			this.vector_1 = new Vector<GClass675>();
		}
		else
		{
			this.vector_1 = vector_4;
		}
		if (vector_5 == null)
		{
			this.vector_2 = new Vector<GClass566>();
			return;
		}
		this.vector_2 = vector_5;
	}

	public virtual int vmethod_0()
	{
		return 6667;
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
			GClass772 gclass = (GClass772)GClass86.smethod_2((int)binaryStream_0.smethod_1());
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
			GClass675 gclass2 = (GClass675)GClass86.smethod_2((int)binaryStream_0.smethod_1());
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
			GClass566 gclass3 = (GClass566)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass3.imethod_1(binaryStream_0);
			this.vector_2.method_0(gclass3);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6667);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass772 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteByte(this.vector_1.Length);
		foreach (GClass675 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteByte(this.vector_2.Length);
		foreach (GClass566 gclass3 in this.vector_2)
		{
			gclass3.imethod_2(binaryStream_0);
		}
	}

	public Vector<GClass772> vector_0;

	public Vector<GClass675> vector_1;

	public Vector<GClass566> vector_2;
}
