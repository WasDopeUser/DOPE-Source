using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass707 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26239;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass707(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, Vector<GClass302> vector_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_3 = int_4;
		this.int_2 = int_5;
		this.int_0 = int_6;
		this.int_1 = int_7;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass302>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 26239;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 11) | this.int_2 << 21);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 6) | this.int_3 << 26);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass302 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass302;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(26239);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		binaryStream_0.fUeiimuocMk(this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		binaryStream_0.fUeiimuocMk(this.int_2 << 11 | U.smethod_0(this.int_2, 21));
		binaryStream_0.fUeiimuocMk(this.int_3 << 6 | U.smethod_0(this.int_3, 26));
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass302 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public Vector<GClass302> vector_0;
}
