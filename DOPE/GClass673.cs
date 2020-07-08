using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass673 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16548;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass673(bool bool_1 = false, Vector<int> vector_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.bool_0 = bool_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 16548;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			int num2 = binaryStream_0.smethod_0();
			num2 = (num2 << 14 | U.smethod_0(num2, 18));
			this.vector_0.method_0(num2);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16548);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(U.smethod_0(num, 14) | num << 18);
		}
	}

	public bool bool_0;

	public Vector<int> vector_0;
}
