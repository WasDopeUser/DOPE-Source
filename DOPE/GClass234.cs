using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass234 : GClass233, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31013;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 37;
		}
	}

	public GClass234(string string_1 = "", GClass137 gclass137_1 = null, string string_2 = "", GClass673 gclass673_1 = null, uint uint_1 = 0U, Vector<int> vector_1 = null, bool bool_3 = false, bool bool_4 = false, GClass191 gclass191_1 = null, int int_2 = 0, int int_3 = 0, double double_1 = 0.0, bool bool_5 = false)
	{
		Class8.xDph7tozmh5WD();
		base..ctor(string_1, gclass137_1, string_2, gclass673_1, uint_1, vector_1, bool_3, bool_4);
		if (gclass191_1 == null)
		{
			this.gclass191_0 = new GClass191(0U);
		}
		else
		{
			this.gclass191_0 = gclass191_1;
		}
		this.int_1 = int_2;
		this.int_0 = int_3;
		this.double_0 = double_1;
		this.bool_2 = bool_5;
	}

	public override int vmethod_0()
	{
		return 31013;
	}

	public override int vmethod_1()
	{
		return 37;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.gclass191_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass191);
		this.gclass191_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		this.double_0 = binaryStream_0.ReadDouble();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(31013);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_2);
		this.gclass191_0.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.fUeiimuocMk(this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		binaryStream_0.smethod_5(8747);
	}

	public bool bool_2;

	public GClass191 gclass191_0;

	public int int_0;

	public double double_0;

	public int int_1;
}
