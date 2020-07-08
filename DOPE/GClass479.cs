using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass479 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14697;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 26;
		}
	}

	public GClass479(double double_1 = 0.0, int int_2 = 0, int int_3 = 0, string string_1 = "", Vector<GClass692> vector_2 = null, Vector<GClass692> vector_3 = null)
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (vector_3 == null)
		{
			this.vector_0 = new Vector<GClass692>();
		}
		else
		{
			this.vector_0 = vector_3;
		}
		if (vector_2 == null)
		{
			this.vector_1 = new Vector<GClass692>();
		}
		else
		{
			this.vector_1 = vector_2;
		}
		this.double_0 = double_1;
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 14697;
	}

	public virtual int vmethod_1()
	{
		return 26;
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
			GClass692 gclass = (GClass692)GClass86.smethod_2((int)binaryStream_0.smethod_1());
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
			GClass692 gclass2 = (GClass692)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			i++;
		}
		this.double_0 = binaryStream_0.ReadDouble();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 1 | U.smethod_0(this.int_1, 31));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14697);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass692 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteByte(this.vector_1.Length);
		foreach (GClass692 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 1) | this.int_1 << 31);
	}

	public string string_0;

	public Vector<GClass692> vector_0;

	public Vector<GClass692> vector_1;

	public double double_0;

	public int int_0;

	public int int_1;
}
