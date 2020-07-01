using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass604 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -27768;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass604(string string_1 = "", GClass201 gclass201_1 = null, Vector<GClass201> vector_1 = null, int int_2 = 0, double double_1 = 0.0, int int_3 = 0)
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_3;
		this.double_0 = double_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass201>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0);
		}
		else
		{
			this.gclass201_0 = gclass201_1;
		}
		this.int_1 = int_2;
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return -27768;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass201 gclass = (GClass201)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_0(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.gclass201_0 = (GClass201)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass201_0 != null)
		{
			this.gclass201_0.imethod_0(binaryStream_0);
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-27768);
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass201 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		if (this.gclass201_0 != null)
		{
			this.gclass201_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		binaryStream_0.smethod_3(this.string_0);
	}

	public int int_0;

	public double double_0;

	public Vector<GClass201> vector_0;

	public GClass201 gclass201_0;

	public int int_1;

	public string string_0;
}
