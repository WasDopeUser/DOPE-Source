using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass523 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8897;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 28;
		}
	}

	public GClass523(double double_3 = 0.0, double double_4 = 0.0, double double_5 = 0.0, int int_1 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.double_0 = double_3;
		this.double_1 = double_4;
		this.double_2 = double_5;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 8897;
	}

	public virtual int vmethod_1()
	{
		return 28;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		this.double_1 = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
		this.double_2 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8897);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-11459);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.smethod_7(4674);
		binaryStream_0.WriteDouble(this.double_2);
	}

	public double double_0;

	public int int_0;

	public double double_1;

	public double double_2;
}
