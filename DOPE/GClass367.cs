using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass367 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20498;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass367(int int_3 = 0, int int_4 = 0, int int_5 = 0, Vector<GClass736> vector_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_2 = int_3;
		this.int_0 = int_4;
		this.int_1 = int_5;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass736>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 20498;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 7 | U.smethod_0(this.int_2, 25));
		binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass736 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass736;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(20498);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(17677);
		binaryStream_0.fUeiimuocMk(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.fUeiimuocMk(this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 7) | this.int_2 << 25);
		binaryStream_0.smethod_5(21062);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass736 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public Vector<GClass736> vector_0;
}
