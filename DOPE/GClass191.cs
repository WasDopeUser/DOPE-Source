using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass191 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3389;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 26;
		}
	}

	public GClass191(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0, bool bool_2 = false, bool bool_3 = false, Vector<int> vector_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.Id = int_4;
		this.int_0 = int_5;
		this.int_1 = int_6;
		this.int_2 = int_7;
		this.int_3 = int_8;
		this.bool_0 = bool_2;
		this.bool_1 = bool_3;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 3389;
	}

	public virtual int vmethod_1()
	{
		return 26;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 10) | this.Id << 22);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 11) | this.int_2 << 21);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 9) | this.int_3 << 23);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			int num2 = binaryStream_0.smethod_0();
			num2 = (num2 << 2 | U.smethod_0(num2, 30));
			this.vector_0.method_0(num2);
			i++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3389);
		binaryStream_0.smethod_4(this.Id << 10 | U.smethod_0(this.Id, 22));
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		binaryStream_0.smethod_4(this.int_2 << 11 | U.smethod_0(this.int_2, 21));
		binaryStream_0.smethod_4(this.int_3 << 9 | U.smethod_0(this.int_3, 23));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(U.smethod_0(num, 2) | num << 30);
		}
	}

	public int Id;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public bool bool_0;

	public bool bool_1;

	public Vector<int> vector_0;
}
