using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass414 : GClass409, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17124;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 22;
		}
	}

	public GClass414(uint uint_1 = 0U, int int_2 = 0, int int_3 = 0, string string_1 = "", double double_2 = 0.0, double double_3 = 0.0, Vector<GClass385> vector_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		this.uint_0 = uint_1;
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.string_0 = string_1;
		this.double_1 = double_2;
		this.double_0 = double_3;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass385>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public override int vmethod_0()
	{
		return 17124;
	}

	public override int vmethod_1()
	{
		return 22;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		binaryStream_0.smethod_1();
		this.double_0 = (double)binaryStream_0.smethod_10();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass385 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass385;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.double_1 = (double)binaryStream_0.smethod_10();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(17124);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.smethod_4(this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		binaryStream_0.smethod_7(12673);
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass385 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_9(this.double_1);
	}

	public int int_0;

	public int int_1;

	public double double_0;

	public Vector<GClass385> vector_0;

	public uint uint_0;

	public string string_0;

	public double double_1;
}
