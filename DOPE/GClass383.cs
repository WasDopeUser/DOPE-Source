using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass383 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28027;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass383(int int_2 = 0, int int_3 = 0, Vector<int> vector_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_0 = int_2;
		this.int_1 = int_3;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 28027;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			int num3 = binaryStream_0.smethod_0();
			num3 = (U.smethod_0(num3, 2) | num3 << 30);
			this.vector_0.method_0(num3);
			num++;
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 11) | this.int_1 << 21);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(28027);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-2750);
		binaryStream_0.smethod_6(7703);
		binaryStream_0.smethod_3(this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_3(num << 2 | U.smethod_0(num, 30));
		}
		binaryStream_0.smethod_3(this.int_1 << 11 | U.smethod_0(this.int_1, 21));
	}

	public int int_0;

	public Vector<int> vector_0;

	public int int_1;
}
