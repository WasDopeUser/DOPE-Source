using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass465 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12121;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass465(Vector<int> vector_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
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
		return 12121;
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
		int num = (int)binaryStream_0.smethod_1();
		while (i < num)
		{
			int num2 = binaryStream_0.smethod_0();
			num2 = (U.smethod_0(num2, 6) | num2 << 26);
			this.vector_0.method_0(num2);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(12121);
		binaryStream_0.smethod_7(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(num << 6 | U.smethod_0(num, 26));
		}
	}

	public Vector<int> vector_0;
}
