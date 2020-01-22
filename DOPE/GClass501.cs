using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass501 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4491;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 38;
		}
	}

	public GClass501(int int_5 = 0, int int_6 = 0, int int_7 = 0, double double_1 = 0.0, double double_2 = 0.0, int int_8 = 0, int int_9 = 0, string string_0 = "")
	{
		Class13.plZSWFPzBWWEZ();
		this.Name = "";
		base..ctor();
		this.int_0 = int_5;
		this.int_1 = int_6;
		this.int_2 = int_7;
		this.double_0 = double_1;
		this.lqlTinDoiX = double_2;
		this.int_4 = int_8;
		this.int_3 = int_9;
		this.Name = string_0;
	}

	public virtual int vmethod_0()
	{
		return 4491;
	}

	public virtual int vmethod_1()
	{
		return 38;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		this.lqlTinDoiX = binaryStream_0.ReadDouble();
		this.double_0 = binaryStream_0.ReadDouble();
		this.Name = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 3 | U.smethod_0(this.int_2, 29));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 13) | this.int_3 << 19);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 1) | this.int_4 << 31);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4491);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.WriteDouble(this.lqlTinDoiX);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		binaryStream_0.smethod_7(6561);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 3) | this.int_2 << 29);
		binaryStream_0.smethod_4(this.int_3 << 13 | U.smethod_0(this.int_3, 19));
		binaryStream_0.smethod_4(this.int_4 << 1 | U.smethod_0(this.int_4, 31));
	}

	public int int_0;

	public double lqlTinDoiX;

	public double double_0;

	public string Name;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;
}
