using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass721 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17418;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 19;
		}
	}

	public GClass721(string string_1 = "", int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0, bool bool_1 = false)
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_3;
		this.bool_0 = bool_1;
		this.int_1 = int_4;
		this.string_0 = string_1;
		this.Width = int_5;
		this.int_2 = int_6;
	}

	public virtual int vmethod_0()
	{
		return 17418;
	}

	public virtual int vmethod_1()
	{
		return 19;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		this.string_0 = binaryStream_0.smethod_2();
		this.Width = binaryStream_0.smethod_0();
		this.Width = (U.smethod_0(this.Width, 10) | this.Width << 22);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 2) | this.int_2 << 30);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(17418);
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.Width << 10 | U.smethod_0(this.Width, 22));
		binaryStream_0.smethod_4(this.int_2 << 2 | U.smethod_0(this.int_2, 30));
	}

	public int int_0;

	public bool bool_0;

	public int int_1;

	public string string_0;

	public int Width;

	public int int_2;
}
