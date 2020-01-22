using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass190 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32158;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 26;
		}
	}

	public GClass190(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0, bool bool_2 = false, bool bool_3 = false, Vector<int> vector_1 = null)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.Id = int_4;
		this.int_2 = int_5;
		this.int_1 = int_6;
		this.int_3 = int_7;
		this.int_0 = int_8;
		this.bool_1 = bool_2;
		this.bool_0 = bool_3;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 32158;
	}

	public virtual int vmethod_1()
	{
		return 26;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 7) | this.int_3 << 25);
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
			num3 = (num3 << 9 | U.smethod_0(num3, 23));
			this.vector_0.method_0(num3);
			num++;
		}
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 6 | U.smethod_0(this.Id, 26));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32158);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		binaryStream_0.smethod_4(this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		binaryStream_0.smethod_4(this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_4(this.int_3 << 7 | U.smethod_0(this.int_3, 25));
		binaryStream_0.smethod_7(1415);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(U.smethod_0(num, 9) | num << 23);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 6) | this.Id << 26);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public bool bool_0;

	public bool bool_1;

	public int int_3;

	public Vector<int> vector_0;

	public int Id;
}
