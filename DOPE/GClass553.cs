using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass553 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 653;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass553(int int_2 = 0, string string_1 = "", string string_2 = "", int int_3 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		this.Name = "";
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.Name = string_1;
		this.string_0 = string_2;
	}

	public virtual int vmethod_0()
	{
		return 653;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		this.Name = binaryStream_0.smethod_2();
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(653);
		binaryStream_0.smethod_4(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.smethod_4(this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_3(this.string_0);
	}

	public int int_0;

	public int int_1;

	public string Name;

	public string string_0;
}
