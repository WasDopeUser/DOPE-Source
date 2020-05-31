using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass390 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32426;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass390(int int_3 = 0, int int_4 = 0, int int_5 = 0, Vector<GClass761> vector_0 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.int_1 = int_3;
		this.int_2 = int_4;
		this.int_0 = int_5;
		if (vector_0 == null)
		{
			this.vPokRubYpX = new Vector<GClass761>();
			return;
		}
		this.vPokRubYpX = vector_0;
	}

	public virtual int vmethod_0()
	{
		return 32426;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		while (this.vPokRubYpX.Length > 0)
		{
			this.vPokRubYpX.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass761 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass761;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vPokRubYpX.method_0(gclass);
			num++;
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 4 | U.smethod_0(this.int_2, 28));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32426);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		binaryStream_0.smethod_4(this.vPokRubYpX.Length);
		foreach (GClass761 gclass in this.vPokRubYpX)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_4(this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		binaryStream_0.smethod_7(26400);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 4) | this.int_2 << 28);
	}

	public int int_0;

	public Vector<GClass761> vPokRubYpX;

	public int int_1;

	public int int_2;
}
