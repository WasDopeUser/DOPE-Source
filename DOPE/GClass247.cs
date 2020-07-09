using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass247 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5568;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 23;
		}
	}

	public GClass247(string string_1 = "", int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0, double double_2 = 0.0, double double_3 = 0.0, bool bool_1 = false, GClass489 gclass489_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_3;
		this.bool_0 = bool_1;
		this.double_0 = double_3;
		this.int_1 = int_5;
		if (gclass489_1 == null)
		{
			this.gclass489_0 = new GClass489(false, 0);
		}
		else
		{
			this.gclass489_0 = gclass489_1;
		}
		this.double_1 = double_2;
		this.Count = int_6;
		this.int_2 = int_4;
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 5568;
	}

	public virtual int vmethod_1()
	{
		return 23;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.int_1 = (int)binaryStream_0.smethod_1();
		this.gclass489_0 = (GClass489)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass489_0 != null)
		{
			this.gclass489_0.imethod_1(binaryStream_0);
		}
		this.double_1 = (double)binaryStream_0.smethod_10();
		this.Count = binaryStream_0.smethod_0();
		this.Count = (U.smethod_0(this.Count, 6) | this.Count << 26);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 16) | this.int_2 << 16);
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5568);
		binaryStream_0.smethod_4(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_7(this.int_1);
		if (this.gclass489_0 != null)
		{
			this.gclass489_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_9(this.double_1);
		binaryStream_0.smethod_4(this.Count << 6 | U.smethod_0(this.Count, 26));
		binaryStream_0.smethod_4(this.int_2 << 16 | U.smethod_0(this.int_2, 16));
		binaryStream_0.smethod_3(this.string_0);
	}

	public int int_0;

	public bool bool_0;

	public double double_0;

	public int int_1;

	public GClass489 gclass489_0;

	public double double_1;

	public int Count;

	public int int_2;

	public string string_0;
}
