using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass354 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18844;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass354(string string_0 = "", Vector<GClass820> vector_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		this.Name = "";
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass820>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.Name = string_0;
	}

	public virtual int vmethod_0()
	{
		return 18844;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = (int)binaryStream_0.smethod_1();
		while (i < num)
		{
			GClass820 gclass = (GClass820)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.Name = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18844);
		binaryStream_0.smethod_7(this.vector_0.Length);
		foreach (GClass820 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.Name);
	}

	public Vector<GClass820> vector_0;

	public string Name;
}
