using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass247 : GClass246, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5449;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 37;
		}
	}

	public GClass247(string string_1 = "", GClass141 gclass141_1 = null, string string_2 = "", GClass684 gclass684_1 = null, uint uint_1 = 0U, Vector<int> vector_1 = null, bool bool_3 = false, bool bool_4 = false, GClass201 gclass201_1 = null, int int_2 = 0, int int_3 = 0, double double_0 = 0.0, bool bool_5 = false)
	{
		Class13.nIxas2ezryi9b();
		base..ctor(string_1, gclass141_1, string_2, gclass684_1, uint_1, vector_1, bool_3, bool_4);
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0U);
		}
		else
		{
			this.gclass201_0 = gclass201_1;
		}
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.LwjtIcGkeU = double_0;
		this.bool_2 = bool_5;
	}

	public override int vmethod_0()
	{
		return 5449;
	}

	public override int vmethod_1()
	{
		return 37;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.LwjtIcGkeU = binaryStream_0.ReadDouble();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
		this.bool_2 = binaryStream_0.ReadBoolean();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5449);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.LwjtIcGkeU);
		binaryStream_0.smethod_4(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		binaryStream_0.smethod_4(this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		this.gclass201_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_2);
	}

	public double LwjtIcGkeU;

	public int int_0;

	public int int_1;

	public GClass201 gclass201_0;

	public bool bool_2;
}
