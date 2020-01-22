using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass358 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12347;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass358(string string_1 = "", int int_2 = 0, int int_3 = 0, Vector<int> vector_1 = null)
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
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
		return 12347;
	}

	public virtual int vmethod_1()
	{
		return 14;
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
			num3 = (U.smethod_0(num3, 15) | num3 << 17);
			this.vector_0.method_0(num3);
			num++;
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 6 | U.smethod_0(this.int_1, 26));
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(12347);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11929);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(num << 15 | U.smethod_0(num, 17));
		}
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 6) | this.int_1 << 26);
		binaryStream_0.smethod_3(this.string_0);
	}

	public Vector<int> vector_0;

	public int int_0;

	public int int_1;

	public string string_0;
}
