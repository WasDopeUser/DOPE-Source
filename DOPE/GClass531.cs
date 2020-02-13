using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass531 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3583;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass531(int int_2 = 0, int int_3 = 0, Vector<int> vector_0 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_1 = int_2;
		this.int_0 = int_3;
		if (vector_0 == null)
		{
			this.chSukvTpYl = new Vector<int>();
			return;
		}
		this.chSukvTpYl = vector_0;
	}

	public virtual int vmethod_0()
	{
		return 3583;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.chSukvTpYl.Length > 0)
		{
			this.chSukvTpYl.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			int num3 = binaryStream_0.smethod_0();
			num3 = (U.smethod_0(num3, 9) | num3 << 23);
			this.chSukvTpYl.method_0(num3);
			num++;
		}
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(3583);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.chSukvTpYl.Length);
		foreach (int num in this.chSukvTpYl)
		{
			binaryStream_0.smethod_3(num << 9 | U.smethod_0(num, 23));
		}
		binaryStream_0.smethod_6(-2142);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		binaryStream_0.smethod_6(-11680);
	}

	public Vector<int> chSukvTpYl;

	public int int_0;

	public int int_1;
}
