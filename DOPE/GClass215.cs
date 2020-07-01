using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass215 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 252;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass215(string string_3 = "", string string_4 = "", string string_5 = "", GClass658 gclass658_1 = null, Vector<GClass583> vector_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		base..ctor();
		this.string_0 = string_3;
		this.string_1 = string_4;
		this.string_2 = string_5;
		if (gclass658_1 == null)
		{
			this.gclass658_0 = new GClass658(0);
		}
		else
		{
			this.gclass658_0 = gclass658_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass583>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 252;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.string_2 = binaryStream_0.smethod_2();
		this.gclass658_0 = (GClass658)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass658_0 != null)
		{
			this.gclass658_0.imethod_0(binaryStream_0);
		}
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass583 gclass = (GClass583)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_0(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(252);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_3(this.string_2);
		if (this.gclass658_0 != null)
		{
			this.gclass658_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass583 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
	}

	public string string_0;

	public string string_1;

	public string string_2;

	public GClass658 gclass658_0;

	public Vector<GClass583> vector_0;
}
