using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass458 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32449;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass458(int int_2 = 0, int int_3 = 0, double double_1 = 0.0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.double_0 = double_1;
		this.int_0 = int_3;
		this.int_1 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 32449;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 12) | this.int_1 << 20);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32449);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_4(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_4(this.int_1 << 12 | U.smethod_0(this.int_1, 20));
	}

	public double double_0;

	public int int_0;

	public int int_1;
}
