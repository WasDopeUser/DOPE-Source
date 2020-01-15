using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass229 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18265;
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
		Class13.nIxas2ezryi9b();
		this.string_0 = "";
		base..ctor();
		this.int_3 = int_4;
		this.int_1 = int_5;
		this.int_0 = int_6;
		this.int_2 = int_7;
		this.bool_0 = bool_4;
		this.bool_1 = bool_5;
		this.bool_3 = bool_6;
		this.string_0 = string_1;
		this.bool_2 = bool_7;
	}

	public virtual int vmethod_0()
	{
		return 18265;
	}

	public virtual int vmethod_1()
	{
		return 22;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		binaryStream_0.smethod_1();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.bool_3 = binaryStream_0.ReadBoolean();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 9 | U.smethod_0(this.int_3, 23));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18265);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-389);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		binaryStream_0.smethod_7(-30159);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.WriteBoolean(this.bool_3);
		binaryStream_0.smethod_4(this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 9) | this.int_3 << 23);
	}

	public bool bool_0;

	public int int_0;

	public bool bool_1;

	public string string_0;

	public int int_1;

	public bool bool_2;

	public bool bool_3;

	public int int_2;

	public int int_3;
}
