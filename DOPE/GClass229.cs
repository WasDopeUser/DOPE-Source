using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass229 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18177;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 22;
		}
	}

	public GClass229(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, bool bool_4 = false, bool bool_5 = false, bool bool_6 = false, string string_1 = "", bool bool_7 = false)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.int_3 = int_4;
		this.int_2 = int_5;
		this.int_0 = int_6;
		this.int_1 = int_7;
		this.bool_3 = bool_4;
		this.bool_2 = bool_5;
		this.bool_1 = bool_6;
		this.string_0 = string_1;
		this.bool_0 = bool_7;
	}

	public virtual int vmethod_0()
	{
		return 18177;
	}

	public virtual int vmethod_1()
	{
		return 22;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		this.string_0 = binaryStream_0.smethod_2();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 6) | this.int_2 << 26);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 1 | U.smethod_0(this.int_3, 31));
		binaryStream_0.smethod_1();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.bool_3 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(18177);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_3(this.int_2 << 6 | U.smethod_0(this.int_2, 26));
		binaryStream_0.smethod_3(U.smethod_0(this.int_3, 1) | this.int_3 << 31);
		binaryStream_0.smethod_6(17953);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.WriteBoolean(this.bool_3);
	}

	public bool bool_0;

	public int int_0;

	public bool bool_1;

	public int int_1;

	public string string_0;

	public int int_2;

	public int int_3;

	public bool bool_2;

	public bool bool_3;
}
