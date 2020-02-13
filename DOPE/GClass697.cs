using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass697 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17906;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass697(Vector<GClass731> vector_2 = null, int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, Vector<GClass731> vector_3 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (vector_2 == null)
		{
			this.vector_0 = new Vector<GClass731>();
		}
		else
		{
			this.vector_0 = vector_2;
		}
		this.int_3 = int_4;
		this.int_0 = int_5;
		this.int_2 = int_6;
		this.int_1 = int_7;
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass731>();
			return;
		}
		this.vector_1 = vector_3;
	}

	public virtual int vmethod_0()
	{
		return 17906;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass731 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass731;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 16) | this.int_2 << 16);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 13) | this.int_3 << 19);
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass731 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass731;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(17906);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.smethod_3(this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass731 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_6(-18426);
		binaryStream_0.smethod_3(this.int_2 << 16 | U.smethod_0(this.int_2, 16));
		binaryStream_0.smethod_3(this.int_3 << 13 | U.smethod_0(this.int_3, 19));
		binaryStream_0.smethod_3(this.vector_1.Length);
		foreach (GClass731 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
	}

	public int int_0;

	public int int_1;

	public Vector<GClass731> vector_0;

	public int int_2;

	public int int_3;

	public Vector<GClass731> vector_1;
}
