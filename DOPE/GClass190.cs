using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass190 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19574;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 26;
		}
	}

	public GClass190(int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, bool bool_2 = false, bool bool_3 = false, Vector<int> vector_1 = null)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.Id = int_3;
		this.FkSnJfSiLa = int_4;
		this.int_2 = int_5;
		this.int_1 = int_6;
		this.int_0 = int_7;
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
		return 19574;
	}

	public virtual int vmethod_1()
	{
		return 26;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.FkSnJfSiLa = binaryStream_0.smethod_0();
		this.FkSnJfSiLa = (U.smethod_0(this.FkSnJfSiLa, 3) | this.FkSnJfSiLa << 29);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 5 | U.smethod_0(this.Id, 27));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		this.bool_1 = binaryStream_0.ReadBoolean();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			int num3 = binaryStream_0.smethod_0();
			num3 = (U.smethod_0(num3, 7) | num3 << 25);
			this.vector_0.method_0(num3);
			num++;
		}
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 3) | this.int_2 << 29);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19574);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.FkSnJfSiLa << 3 | U.smethod_0(this.FkSnJfSiLa, 29));
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 5) | this.Id << 27);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(num << 7 | U.smethod_0(num, 25));
		}
		binaryStream_0.smethod_4(this.int_2 << 3 | U.smethod_0(this.int_2, 29));
	}

	public bool bool_0;

	public int FkSnJfSiLa;

	public int int_0;

	public int Id;

	public int int_1;

	public bool bool_1;

	public Vector<int> vector_0;

	public int int_2;
}
