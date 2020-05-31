using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass571 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25647;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass571(GClass432 gclass432_1 = null, int int_2 = 0, int int_3 = 0, bool bool_1 = false, Vector<string> vector_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass432_1 == null)
		{
			this.gclass432_0 = new GClass432(0U);
		}
		else
		{
			this.gclass432_0 = gclass432_1;
		}
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.bool_0 = bool_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<string>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 25647;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			string iai2vvt4Q2e7jARe47j = binaryStream_0.smethod_2();
			this.vector_0.method_0(iai2vvt4Q2e7jARe47j);
			num++;
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		this.gclass432_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass432);
		this.gclass432_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25647);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-6738);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (string string_ in this.vector_0)
		{
			binaryStream_0.smethod_3(string_);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		binaryStream_0.smethod_4(this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		this.gclass432_0.imethod_1(binaryStream_0);
	}

	public bool bool_0;

	public Vector<string> vector_0;

	public int int_0;

	public int int_1;

	public GClass432 gclass432_0;
}
