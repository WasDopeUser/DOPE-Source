using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass222 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31273;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass222(uint uint_0 = 0U, int int_1 = 0, Vector<int> vector_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.State = uint_0;
		this.int_0 = int_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 31273;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.State = (uint)binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			int num3 = binaryStream_0.smethod_0();
			num3 = (U.smethod_0(num3, 14) | num3 << 18);
			this.vector_0.method_0(num3);
			num++;
		}
		binaryStream_0.smethod_1();
		this.int_0 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(31273);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(this.State);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_3(num << 14 | U.smethod_0(num, 18));
		}
		binaryStream_0.smethod_6(-17808);
		binaryStream_0.smethod_6(this.int_0);
	}

	public uint State;

	public Vector<int> vector_0;

	public int int_0;
}
