using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass640 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15711;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass640(int int_3 = 0, double double_1 = 0.0, int int_4 = 0, int int_5 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_0 = int_3;
		this.double_0 = double_1;
		this.int_1 = int_4;
		this.int_2 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 15711;
	}

	public virtual int vmethod_1()
	{
		return 14;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.int_1 = (int)binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
		this.int_2 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(15711);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.int_0);
		binaryStream_0.smethod_6(this.int_1);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_6(this.int_2);
	}

	public int int_0;

	public int int_1;

	public double double_0;

	public int int_2;
}
