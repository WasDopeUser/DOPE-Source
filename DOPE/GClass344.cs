using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass344 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25172;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass344(int int_2 = 0, string string_1 = "", string string_2 = "", int int_3 = 0)
	{
		Class13.igxcIukzfpare();
		this.Name = "";
		this.string_0 = "";
		base..ctor();
		this.int_1 = int_2;
		this.Name = string_1;
		this.string_0 = string_2;
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 25172;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Name = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(25172);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.MoioCjQkqp0(this.Name);
		binaryStream_0.smethod_3(this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_6(-25132);
	}

	public string Name;

	public int int_0;

	public int int_1;

	public string string_0;
}
