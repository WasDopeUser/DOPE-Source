using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass240 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15012;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass240(uint uint_1 = 0U, Vector<int> vector_0 = null, int int_2 = 0, int int_3 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.uint_0 = uint_1;
		if (vector_0 == null)
		{
			this.AvuwLgfnLb = new Vector<int>();
		}
		else
		{
			this.AvuwLgfnLb = vector_0;
		}
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 15012;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		while (this.AvuwLgfnLb.Length > 0)
		{
			this.AvuwLgfnLb.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			int num3 = binaryStream_0.smethod_0();
			num3 = (num3 << 3 | U.smethod_0(num3, 29));
			this.AvuwLgfnLb.method_0(num3);
			num++;
		}
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_1 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(15012);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		binaryStream_0.smethod_4(this.AvuwLgfnLb.Length);
		foreach (int num in this.AvuwLgfnLb)
		{
			binaryStream_0.smethod_4(U.smethod_0(num, 3) | num << 29);
		}
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(this.int_1);
	}

	public int int_0;

	public Vector<int> AvuwLgfnLb;

	public uint uint_0;

	public int int_1;
}
