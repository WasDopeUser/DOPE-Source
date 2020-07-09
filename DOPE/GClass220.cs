using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass220 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 239;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass220(int int_1 = 0, int int_2 = 0, Vector<int> vector_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.State = int_1;
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
		return 239;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.State = (int)binaryStream_0.smethod_1();
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.int_0 = (65535 & ((65535 & this.int_0) << 13 | U.smethod_0(65535 & this.int_0, 3)));
		this.int_0 = ((this.int_0 > 32767) ? (this.int_0 - 65536) : this.int_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			int num2 = binaryStream_0.smethod_0();
			num2 = (num2 << 4 | U.smethod_0(num2, 28));
			this.vector_0.method_0(num2);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(239);
		binaryStream_0.smethod_7(this.State);
		binaryStream_0.smethod_7(65535 & (U.smethod_0(65535 & this.int_0, 13) | (65535 & this.int_0) << 3));
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(U.smethod_0(num, 4) | num << 28);
		}
	}

	public int State;

	public int int_0;

	public Vector<int> vector_0;
}
