using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass179 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29947;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass179(string string_1 = "", int int_2 = 0, int int_3 = 0)
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_3;
		this.int_1 = int_2;
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 29947;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29947);
		binaryStream_0.smethod_4(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		binaryStream_0.smethod_3(this.string_0);
	}

	public int int_0;

	public int int_1;

	public string string_0;
}
