using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass370 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4175;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 23;
		}
	}

	public GClass370(string string_1 = "", int int_2 = 0, int int_3 = 0, uint uint_1 = 0U, int int_4 = 0, double double_2 = 0.0, double double_3 = 0.0, bool bool_1 = false, GClass467 gclass467_0 = null)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.int_1 = int_2;
		this.int_0 = int_3;
		this.uint_0 = uint_1;
		this.Count = int_4;
		this.double_0 = double_2;
		this.double_1 = double_3;
		this.bool_0 = bool_1;
		if (gclass467_0 == null)
		{
			this.vlpxkkIxvH = new GClass467(false, 0);
			return;
		}
		this.vlpxkkIxvH = gclass467_0;
	}

	public virtual int vmethod_0()
	{
		return 4175;
	}

	public virtual int vmethod_1()
	{
		return 23;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Count = binaryStream_0.smethod_0();
		this.Count = (U.smethod_0(this.Count, 7) | this.Count << 25);
		this.vlpxkkIxvH = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass467);
		this.vlpxkkIxvH.imethod_1(binaryStream_0);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.double_0 = (double)binaryStream_0.smethod_8();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		this.double_1 = (double)binaryStream_0.smethod_8();
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 14) | this.int_1 << 18);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(4175);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.Count << 7 | U.smethod_0(this.Count, 25));
		this.vlpxkkIxvH.imethod_2(binaryStream_0);
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(this.double_0);
		binaryStream_0.fUeiimuocMk(this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		binaryStream_0.smethod_7(this.double_1);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_5(-14915);
		binaryStream_0.fUeiimuocMk(this.int_1 << 14 | U.smethod_0(this.int_1, 18));
	}

	public int Count;

	public GClass467 vlpxkkIxvH;

	public uint uint_0;

	public string string_0;

	public double double_0;

	public int int_0;

	public double double_1;

	public bool bool_0;

	public int int_1;
}
