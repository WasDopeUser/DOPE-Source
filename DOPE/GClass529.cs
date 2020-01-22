using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass529 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32462;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass529(int int_2 = 0, int int_3 = 0, Vector<int> vector_1 = null)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_1 = int_2;
		this.int_0 = int_3;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 32462;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			int num3 = binaryStream_0.smethod_0();
			num3 = (num3 << 7 | U.smethod_0(num3, 25));
			this.vector_0.method_0(num3);
			num++;
		}
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32462);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.smethod_4(this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(U.smethod_0(num, 7) | num << 25);
		}
		binaryStream_0.smethod_7(-28041);
	}

	public int int_0;

	public int int_1;

	public Vector<int> vector_0;
}
