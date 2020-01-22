using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass751 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31455;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass751(int int_1 = 0, int int_2 = 0, Vector<int> vector_1 = null)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.UaGvqEjcAg = int_1;
		this.int_0 = int_2;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 31455;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			int num3 = binaryStream_0.smethod_0();
			num3 = (num3 << 2 | U.smethod_0(num3, 30));
			this.vector_0.method_0(num3);
			num++;
		}
		this.UaGvqEjcAg = binaryStream_0.smethod_0();
		this.UaGvqEjcAg = (this.UaGvqEjcAg << 4 | U.smethod_0(this.UaGvqEjcAg, 28));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31455);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(U.smethod_0(num, 2) | num << 30);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.UaGvqEjcAg, 4) | this.UaGvqEjcAg << 28);
	}

	public int int_0;

	public Vector<int> vector_0;

	public int UaGvqEjcAg;
}
