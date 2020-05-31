using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass248 : GClass247, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27741;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 37;
		}
	}

	public GClass248(string string_1 = "", GClass141 gclass141_1 = null, string string_2 = "", GClass700 gclass700_1 = null, uint uint_1 = 0U, Vector<int> vector_1 = null, bool bool_3 = false, bool bool_4 = false, GClass202 gclass202_1 = null, int int_2 = 0, int int_3 = 0, double double_1 = 0.0, bool bool_5 = false)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor(string_1, gclass141_1, string_2, gclass700_1, uint_1, vector_1, bool_3, bool_4);
		if (gclass202_1 == null)
		{
			this.gclass202_0 = new GClass202(0U);
		}
		else
		{
			this.gclass202_0 = gclass202_1;
		}
		this.int_1 = int_2;
		this.int_0 = int_3;
		this.double_0 = double_1;
		this.bool_2 = bool_5;
	}

	public override int vmethod_0()
	{
		return 27741;
	}

	public override int vmethod_1()
	{
		return 37;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		this.gclass202_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass202);
		this.gclass202_0.HrqIugnatr8(binaryStream_0);
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27741);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(15100);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		this.gclass202_0.imethod_1(binaryStream_0);
	}

	public double double_0;

	public int int_0;

	public bool bool_2;

	public int int_1;

	public GClass202 gclass202_0;
}
