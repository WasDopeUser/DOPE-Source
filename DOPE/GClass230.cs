using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass230 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11892;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 22;
		}
	}

	public GClass230(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, bool bool_4 = false, bool bool_5 = false, bool bool_6 = false, string string_1 = "", bool bool_7 = false)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		this.int_2 = int_4;
		this.int_1 = int_5;
		this.int_3 = int_6;
		this.int_0 = int_7;
		this.bool_1 = bool_4;
		this.bool_3 = bool_5;
		this.bool_0 = bool_6;
		this.string_0 = string_1;
		this.bool_2 = bool_7;
	}

	public virtual int vmethod_0()
	{
		return 11892;
	}

	public virtual int vmethod_1()
	{
		return 22;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 15 | U.smethod_0(this.int_2, 17));
		this.bool_3 = binaryStream_0.ReadBoolean();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 2) | this.int_3 << 30);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11892);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-13580);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.smethod_4(this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 15) | this.int_2 << 17);
		binaryStream_0.WriteBoolean(this.bool_3);
		binaryStream_0.smethod_4(this.int_3 << 2 | U.smethod_0(this.int_3, 30));
	}

	public int int_0;

	public bool bool_0;

	public string string_0;

	public bool bool_1;

	public bool bool_2;

	public int int_1;

	public int int_2;

	public bool bool_3;

	public int int_3;
}
