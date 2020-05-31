using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass250 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16220;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 23;
		}
	}

	public GClass250(string string_1 = "", int int_2 = 0, int int_3 = 0, uint uint_1 = 0U, int int_4 = 0, double double_2 = 0.0, double double_3 = 0.0, bool bool_1 = false, GClass489 gclass489_1 = null)
	{
		Class13.NP5bWyNzLwONS();
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
		if (gclass489_1 == null)
		{
			this.gclass489_0 = new GClass489(false, 0);
			return;
		}
		this.gclass489_0 = gclass489_1;
	}

	public virtual int vmethod_0()
	{
		return 16220;
	}

	public virtual int vmethod_1()
	{
		return 23;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.gclass489_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass489);
		this.gclass489_0.HrqIugnatr8(binaryStream_0);
		this.Count = binaryStream_0.smethod_0();
		this.Count = (U.smethod_0(this.Count, 4) | this.Count << 28);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		this.double_1 = (double)binaryStream_0.smethod_10();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16220);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_9(this.double_0);
		this.gclass489_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(this.Count << 4 | U.smethod_0(this.Count, 28));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(21595);
		binaryStream_0.smethod_4(this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		binaryStream_0.smethod_9(this.double_1);
	}

	public bool bool_0;

	public double double_0;

	public GClass489 gclass489_0;

	public int Count;

	public string string_0;

	public int int_0;

	public uint uint_0;

	public int int_1;

	public double double_1;
}
