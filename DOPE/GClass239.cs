using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass239 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16830;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass239(uint uint_1 = 0U, Vector<int> vector_1 = null, int int_1 = 0, int int_2 = 0)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.uint_0 = uint_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.epkCplkbKx = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 16830;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
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
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.epkCplkbKx = binaryStream_0.smethod_0();
		this.epkCplkbKx = (this.epkCplkbKx << 7 | U.smethod_0(this.epkCplkbKx, 25));
		this.int_0 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16830);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19345);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(num << 2 | U.smethod_0(num, 30));
		}
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_4(U.smethod_0(this.epkCplkbKx, 7) | this.epkCplkbKx << 25);
		binaryStream_0.smethod_7(this.int_0);
	}

	public Vector<int> vector_0;

	public uint uint_0;

	public int epkCplkbKx;

	public int int_0;
}
