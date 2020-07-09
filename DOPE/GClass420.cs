using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass420 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -4;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 11;
		}
	}

	public GClass420(string string_3 = "", Vector<GClass744> vector_1 = null, string string_4 = "", string string_5 = "", bool bool_0 = false)
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		base..ctor();
		this.string_0 = string_3;
		this.string_1 = string_5;
		this.string_2 = string_4;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass744>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.Visible = bool_0;
	}

	public virtual int vmethod_0()
	{
		return -4;
	}

	public virtual int vmethod_1()
	{
		return 11;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.string_2 = binaryStream_0.smethod_2();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = (int)binaryStream_0.smethod_1();
		while (i < num)
		{
			GClass744 gclass = (GClass744)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.Visible = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-4);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_3(this.string_2);
		binaryStream_0.smethod_7(this.vector_0.Length);
		foreach (GClass744 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteBoolean(this.Visible);
	}

	public string string_0;

	public string string_1;

	public string string_2;

	public Vector<GClass744> vector_0;

	public bool Visible;
}
