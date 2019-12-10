using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass227 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass227(uint uint_1 = 0U, Vector<int> vector_1 = null, int int_2 = 0, int int_3 = 0)
	{
		Class8.xDph7tozmh5WD();
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
		this.int_1 = int_2;
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 28;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			int num3 = binaryStream_0.smethod_0();
			num3 = (num3 << 9 | U.smethod_0(num3, 23));
			this.vector_0.method_0(num3);
			num++;
		}
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(28);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(this.int_0);
		binaryStream_0.smethod_5(-13821);
		binaryStream_0.fUeiimuocMk(this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.fUeiimuocMk(U.smethod_0(num, 9) | num << 23);
		}
		binaryStream_0.smethod_5(23848);
	}

	public int int_0;

	public int int_1;

	public uint uint_0;

	public Vector<int> vector_0;
}
