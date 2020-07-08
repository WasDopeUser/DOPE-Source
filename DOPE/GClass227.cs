using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass227 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -26637;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 22;
		}
	}

	public GClass227(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, bool bool_4 = false, bool bool_5 = false, bool bool_6 = false, string string_1 = "", bool bool_7 = false)
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		base..ctor();
		this.bool_0 = bool_4;
		this.int_0 = int_6;
		this.bool_1 = bool_6;
		this.int_1 = int_4;
		this.string_0 = string_1;
		this.bool_2 = bool_7;
		this.int_2 = int_5;
		this.int_3 = int_7;
		this.bool_3 = bool_5;
	}

	public virtual int vmethod_0()
	{
		return -26637;
	}

	public virtual int vmethod_1()
	{
		return 22;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		this.string_0 = binaryStream_0.smethod_2();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 11 | U.smethod_0(this.int_2, 21));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 12 | U.smethod_0(this.int_3, 20));
		this.bool_3 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-26637);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 11) | this.int_2 << 21);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 12) | this.int_3 << 20);
		binaryStream_0.WriteBoolean(this.bool_3);
	}

	public bool bool_0;

	public int int_0;

	public bool bool_1;

	public int int_1;

	public string string_0;

	public bool bool_2;

	public int int_2;

	public int int_3;

	public bool bool_3;
}
