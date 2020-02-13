using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass735 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24592;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass735(string string_0 = "", int int_1 = 0, Vector<int> vector_1 = null)
	{
		Class13.igxcIukzfpare();
		this.RnvEhnGqnc = "";
		base..ctor();
		this.RnvEhnGqnc = string_0;
		this.int_0 = int_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 24592;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			int num3 = binaryStream_0.smethod_0();
			num3 = (num3 << 8 | U.smethod_0(num3, 24));
			this.vector_0.method_0(num3);
			num++;
		}
		binaryStream_0.smethod_1();
		this.RnvEhnGqnc = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(24592);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_3(U.smethod_0(num, 8) | num << 24);
		}
		binaryStream_0.smethod_6(5076);
		binaryStream_0.MoioCjQkqp0(this.RnvEhnGqnc);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
	}

	public Vector<int> vector_0;

	public string RnvEhnGqnc;

	public int int_0;
}
