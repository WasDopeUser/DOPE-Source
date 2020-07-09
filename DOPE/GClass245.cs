using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass245 : GClass244, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -8776;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 17;
		}
	}

	public GClass245(string string_1 = "", GClass141 gclass141_1 = null, string string_2 = "", GClass738 gclass738_1 = null, int int_3 = 0, Vector<int> vector_1 = null, bool bool_3 = false, bool bool_4 = false, GClass201 gclass201_1 = null, int int_4 = 0, int int_5 = 0, double double_1 = 0.0, bool bool_5 = false)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor(string_1, gclass141_1, string_2, gclass738_1, int_3, vector_1, bool_3, bool_4);
		this.int_1 = int_4;
		this.int_2 = int_5;
		this.double_0 = double_1;
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0);
		}
		else
		{
			this.gclass201_0 = gclass201_1;
		}
		this.bool_2 = bool_5;
	}

	public override int vmethod_0()
	{
		return -8776;
	}

	public override int vmethod_1()
	{
		return 17;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		this.double_0 = binaryStream_0.ReadDouble();
		this.gclass201_0 = (GClass201)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass201_0 != null)
		{
			this.gclass201_0.imethod_1(binaryStream_0);
		}
		this.bool_2 = binaryStream_0.ReadBoolean();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-8776);
		base.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		binaryStream_0.WriteDouble(this.double_0);
		if (this.gclass201_0 != null)
		{
			this.gclass201_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteBoolean(this.bool_2);
	}

	public int int_1;

	public int int_2;

	public double double_0;

	public GClass201 gclass201_0;

	public bool bool_2;
}
