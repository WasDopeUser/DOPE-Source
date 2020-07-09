using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass234 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19741;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass234(Vector<GClass249> vector_2 = null, string string_1 = "", Vector<GClass420> vector_3 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (vector_3 == null)
		{
			this.vector_0 = new Vector<GClass420>();
		}
		else
		{
			this.vector_0 = vector_3;
		}
		if (vector_2 == null)
		{
			this.vector_1 = new Vector<GClass249>();
			return;
		}
		this.vector_1 = vector_2;
	}

	public virtual int vmethod_0()
	{
		return 19741;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass420 gclass = (GClass420)GClass86.smethod_2((int)binaryStream_0.smethod_1());
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
			GClass249 gclass2 = (GClass249)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19741);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass420 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteByte(this.vector_1.Length);
		foreach (GClass249 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
	}

	public string string_0;

	public Vector<GClass420> vector_0;

	public Vector<GClass249> vector_1;
}
