using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass411 : GClass406, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 951;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 22;
		}
	}

	public GClass411(int int_3 = 0, int int_4 = 0, int int_5 = 0, string string_1 = "", double double_2 = 0.0, double double_3 = 0.0, Vector<GClass378> vector_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		base..ctor();
		this.double_0 = double_2;
		this.int_0 = int_3;
		this.string_0 = string_1;
		this.int_1 = int_5;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass378>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.int_2 = int_4;
		this.double_1 = double_3;
	}

	public override int vmethod_0()
	{
		return 951;
	}

	public override int vmethod_1()
	{
		return 22;
	}

	public override void imethod_0(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_0(binaryStream_0);
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass378 gclass = (GClass378)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_0(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 8 | U.smethod_0(this.int_2, 24));
		this.double_1 = (double)binaryStream_0.smethod_10();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(951);
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass378 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 8) | this.int_2 << 24);
		binaryStream_0.smethod_9(this.double_1);
	}

	public double double_0;

	public int int_0;

	public string string_0;

	public int int_1;

	public Vector<GClass378> vector_0;

	public int int_2;

	public double double_1;
}
