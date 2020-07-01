using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass654 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4900;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass654(int int_2 = 0, Vector<int> vector_1 = null, int int_3 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_2;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 4900;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			int num2 = binaryStream_0.smethod_0();
			num2 = (U.smethod_0(num2, 1) | num2 << 31);
			this.vector_0.method_0(num2);
			i++;
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 13) | this.int_1 << 19);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4900);
		binaryStream_0.smethod_4(this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(num << 1 | U.smethod_0(num, 31));
		}
		binaryStream_0.smethod_4(this.int_1 << 13 | U.smethod_0(this.int_1, 19));
	}

	public int int_0;

	public Vector<int> vector_0;

	public int int_1;
}
