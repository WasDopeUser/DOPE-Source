using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass654 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1265;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass654(int int_2 = 0, double double_1 = 0.0, int int_3 = 0, int int_4 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.int_0 = int_2;
		this.double_0 = double_1;
		this.int_1 = int_3;
		this.cshQqiZyal = int_4;
	}

	public virtual int vmethod_0()
	{
		return 1265;
	}

	public virtual int vmethod_1()
	{
		return 14;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		this.cshQqiZyal = (int)binaryStream_0.smethod_1();
		this.int_0 = (int)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_1 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1265);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_7(this.cshQqiZyal);
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.smethod_7(15054);
		binaryStream_0.smethod_7(this.int_1);
	}

	public double double_0;

	public int cshQqiZyal;

	public int int_0;

	public int int_1;
}
