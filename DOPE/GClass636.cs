using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass636 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11966;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass636(string string_1 = "", string string_2 = "", int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.igxcIukzfpare();
		this.Name = "";
		this.string_0 = "";
		base..ctor();
		this.Name = string_1;
		this.string_0 = string_2;
		this.int_2 = int_3;
		this.int_0 = int_4;
		this.int_1 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 11966;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Name = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		this.string_0 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 8 | U.smethod_0(this.int_1, 24));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 9) | this.int_2 << 23);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(11966);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.MoioCjQkqp0(this.Name);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 8) | this.int_1 << 24);
		binaryStream_0.smethod_3(this.int_2 << 9 | U.smethod_0(this.int_2, 23));
	}

	public string Name;

	public int int_0;

	public string string_0;

	public int int_1;

	public int int_2;
}
