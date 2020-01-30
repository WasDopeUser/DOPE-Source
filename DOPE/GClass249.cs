using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass249 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5077;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 23;
		}
	}

	public GClass249(string string_1 = "", int int_2 = 0, int int_3 = 0, uint uint_1 = 0U, int int_4 = 0, double double_2 = 0.0, double double_3 = 0.0, bool bool_1 = false, GClass480 gclass480_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.uint_0 = uint_1;
		this.Count = int_4;
		this.double_0 = double_2;
		this.double_1 = double_3;
		this.bool_0 = bool_1;
		if (gclass480_1 == null)
		{
			this.gclass480_0 = new GClass480(false, 0);
			return;
		}
		this.gclass480_0 = gclass480_1;
	}

	public virtual int vmethod_0()
	{
		return 5077;
	}

	public virtual int vmethod_1()
	{
		return 23;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass480_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass480);
		this.gclass480_0.imethod_1(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.double_1 = (double)binaryStream_0.smethod_10();
		this.Count = binaryStream_0.smethod_0();
		this.Count = (U.smethod_0(this.Count, 12) | this.Count << 20);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5077);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_4(this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		binaryStream_0.smethod_6(this.uint_0);
		this.gclass480_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(10611);
		binaryStream_0.smethod_7(-21360);
		binaryStream_0.smethod_9(this.double_1);
		binaryStream_0.smethod_4(this.Count << 12 | U.smethod_0(this.Count, 20));
	}

	public int int_0;

	public double double_0;

	public int int_1;

	public uint uint_0;

	public GClass480 gclass480_0;

	public bool bool_0;

	public string string_0;

	public double double_1;

	public int Count;
}
