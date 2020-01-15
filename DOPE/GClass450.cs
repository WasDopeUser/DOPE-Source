using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass450 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15191;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass450(int int_2 = 0, int int_3 = 0, double double_1 = 0.0)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 15191;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		this.double_0 = binaryStream_0.ReadDouble();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 6) | this.int_1 << 26);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(15191);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_4(this.int_1 << 6 | U.smethod_0(this.int_1, 26));
	}

	public int int_0;

	public double double_0;

	public int int_1;
}
