using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass686 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 160;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass686(int int_3 = 0, double double_1 = 0.0, int int_4 = 0, int int_5 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_3;
		this.double_0 = double_1;
		this.int_1 = int_4;
		this.int_2 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 160;
	}

	public virtual int vmethod_1()
	{
		return 14;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.int_0 = (65535 & ((65535 & this.int_0) << 14 | U.smethod_0(65535 & this.int_0, 2)));
		this.int_0 = ((this.int_0 > 32767) ? (this.int_0 - 65536) : this.int_0);
		this.double_0 = binaryStream_0.ReadDouble();
		this.int_1 = (int)binaryStream_0.smethod_1();
		this.int_1 = (65535 & (U.smethod_0(65535 & this.int_1, 0) | (65535 & this.int_1) << 16));
		this.int_1 = ((this.int_1 > 32767) ? (this.int_1 - 65536) : this.int_1);
		this.int_2 = (int)binaryStream_0.smethod_1();
		this.int_2 = (65535 & (U.smethod_0(65535 & this.int_2, 3) | (65535 & this.int_2) << 13));
		this.int_2 = ((this.int_2 > 32767) ? (this.int_2 - 65536) : this.int_2);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(160);
		binaryStream_0.smethod_7(65535 & (U.smethod_0(65535 & this.int_0, 14) | (65535 & this.int_0) << 2));
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_7(65535 & ((65535 & this.int_1) | U.smethod_0(65535 & this.int_1, 16)));
		binaryStream_0.smethod_7(65535 & ((65535 & this.int_2) << 3 | U.smethod_0(65535 & this.int_2, 13)));
	}

	public int int_0;

	public double double_0;

	public int int_1;

	public int int_2;
}
