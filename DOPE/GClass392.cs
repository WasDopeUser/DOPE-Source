using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass392 : GClass387, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27025;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 22;
		}
	}

	public GClass392(uint uint_1 = 0U, int int_2 = 0, int int_3 = 0, string string_1 = "", double double_2 = 0.0, double double_3 = 0.0, Vector<GClass361> vector_1 = null)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		this.uint_0 = uint_1;
		this.int_1 = int_2;
		this.int_0 = int_3;
		this.string_0 = string_1;
		this.double_0 = double_2;
		this.double_1 = double_3;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass361>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public override int vmethod_0()
	{
		return 27025;
	}

	public override int vmethod_1()
	{
		return 22;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass361 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass361;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.string_0 = binaryStream_0.smethod_2();
		this.double_0 = (double)binaryStream_0.smethod_8();
		this.double_1 = (double)binaryStream_0.smethod_8();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(27025);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass361 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(this.double_0);
		binaryStream_0.smethod_7(this.double_1);
		binaryStream_0.fUeiimuocMk(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.fUeiimuocMk(this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		binaryStream_0.smethod_5(-8172);
	}

	public uint uint_0;

	public Vector<GClass361> vector_0;

	public string string_0;

	public double double_0;

	public double double_1;

	public int int_0;

	public int int_1;
}
