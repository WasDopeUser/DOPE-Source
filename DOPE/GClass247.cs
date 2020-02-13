using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass247 : GClass246, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22780;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 37;
		}
	}

	public GClass247(string string_1 = "", GClass141 gclass141_1 = null, string string_2 = "", GClass686 gclass686_1 = null, uint uint_1 = 0U, Vector<int> vector_1 = null, bool bool_3 = false, bool bool_4 = false, GClass201 gclass201_1 = null, int int_2 = 0, int int_3 = 0, double double_0 = 0.0, bool bool_5 = false)
	{
		Class13.igxcIukzfpare();
		base..ctor(string_1, gclass141_1, string_2, gclass686_1, uint_1, vector_1, bool_3, bool_4);
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0U);
		}
		else
		{
			this.gclass201_0 = gclass201_1;
		}
		this.int_1 = int_2;
		this.int_0 = int_3;
		this.YpbvvmduqE = double_0;
		this.bool_2 = bool_5;
	}

	public override int vmethod_0()
	{
		return 22780;
	}

	public override int vmethod_1()
	{
		return 37;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
		this.YpbvvmduqE = binaryStream_0.ReadDouble();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 12 | U.smethod_0(this.int_1, 20));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(22780);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass201_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.YpbvvmduqE);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.smethod_3(this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 12) | this.int_1 << 20);
	}

	public GClass201 gclass201_0;

	public double YpbvvmduqE;

	public bool bool_2;

	public int int_0;

	public int int_1;
}
