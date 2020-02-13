using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass614 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16752;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass614(int int_1 = 0, Vector<int> vector_1 = null, int int_2 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_0 = int_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.sLpDjoOngD = int_2;
	}

	public virtual int vmethod_0()
	{
		return 16752;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			int num3 = binaryStream_0.smethod_0();
			num3 = (U.smethod_0(num3, 1) | num3 << 31);
			this.vector_0.method_0(num3);
			num++;
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		this.sLpDjoOngD = binaryStream_0.smethod_0();
		this.sLpDjoOngD = (this.sLpDjoOngD << 10 | U.smethod_0(this.sLpDjoOngD, 22));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(16752);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_3(num << 1 | U.smethod_0(num, 31));
		}
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.smethod_3(U.smethod_0(this.sLpDjoOngD, 10) | this.sLpDjoOngD << 22);
		binaryStream_0.smethod_6(-30615);
	}

	public Vector<int> vector_0;

	public int int_0;

	public int sLpDjoOngD;
}
