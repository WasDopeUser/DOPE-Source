using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass441 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30252;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass441(Vector<int> vector_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 30252;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			int num2 = binaryStream_0.smethod_0();
			num2 = (U.smethod_0(num2, 10) | num2 << 22);
			this.vector_0.method_0(num2);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30252);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(num << 10 | U.smethod_0(num, 22));
		}
	}

	public Vector<int> vector_0;
}
