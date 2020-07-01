using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass796 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -13705;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass796(string string_1 = "", int int_1 = 0, Vector<int> vector_0 = null)
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		base..ctor();
		if (vector_0 == null)
		{
			this.puTgEpvgye = new Vector<int>();
		}
		else
		{
			this.puTgEpvgye = vector_0;
		}
		this.string_0 = string_1;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return -13705;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		while (this.puTgEpvgye.Length > 0)
		{
			this.puTgEpvgye.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			int num2 = binaryStream_0.smethod_0();
			num2 = (num2 << 9 | U.smethod_0(num2, 23));
			this.puTgEpvgye.method_0(num2);
			i++;
		}
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 12) | this.int_0 << 20);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-13705);
		binaryStream_0.WriteByte(this.puTgEpvgye.Length);
		foreach (int num in this.puTgEpvgye)
		{
			binaryStream_0.smethod_4(U.smethod_0(num, 9) | num << 23);
		}
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_0 << 12 | U.smethod_0(this.int_0, 20));
	}

	public Vector<int> puTgEpvgye;

	public string string_0;

	public int int_0;
}
