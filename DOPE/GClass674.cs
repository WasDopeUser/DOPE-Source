using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass674 : GInterface0
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

	public GClass674(bool bool_1 = false, Vector<int> vector_0 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.bool_0 = bool_1;
		if (vector_0 == null)
		{
			this.NpWkjwloak = new Vector<int>();
			return;
		}
		this.NpWkjwloak = vector_0;
	}

	public virtual int vmethod_0()
	{
		return 16548;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		while (this.NpWkjwloak.Length > 0)
		{
			this.NpWkjwloak.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			int num2 = binaryStream_0.smethod_0();
			num2 = (num2 << 14 | U.smethod_0(num2, 18));
			this.NpWkjwloak.method_0(num2);
			i++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16548);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteByte(this.NpWkjwloak.Length);
		foreach (int num in this.NpWkjwloak)
		{
			binaryStream_0.smethod_4(U.smethod_0(num, 14) | num << 18);
		}
	}

	public bool bool_0;

	public Vector<int> NpWkjwloak;
}
