using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass236 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 800;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass236(int int_3 = 0, Vector<int> vector_1 = null, int int_4 = 0, int int_5 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_3;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.int_1 = int_4;
		this.int_2 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 800;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			int num2 = binaryStream_0.smethod_0();
			num2 = (num2 << 7 | U.smethod_0(num2, 25));
			this.vector_0.method_0(num2);
			i++;
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 14 | U.smethod_0(this.int_1, 18));
		this.int_2 = (int)binaryStream_0.smethod_1();
		this.int_2 = (65535 & (U.smethod_0(65535 & this.int_2, 14) | (65535 & this.int_2) << 2));
		this.int_2 = ((this.int_2 > 32767) ? (this.int_2 - 65536) : this.int_2);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(800);
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(U.smethod_0(num, 7) | num << 25);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 14) | this.int_1 << 18);
		binaryStream_0.smethod_7(65535 & ((65535 & this.int_2) << 14 | U.smethod_0(65535 & this.int_2, 2)));
	}

	public int int_0;

	public Vector<int> vector_0;

	public int int_1;

	public int int_2;
}
