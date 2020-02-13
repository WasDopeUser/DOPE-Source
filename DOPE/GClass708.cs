using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass708 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10715;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass708(uint uint_1 = 0U, int int_2 = 0, int int_3 = 0, GClass201 gclass201_2 = null, GClass201 gclass201_3 = null, Vector<GClass503> vector_3 = null, Vector<GClass503> vector_4 = null, Vector<GClass379> vector_5 = null, GClass775 gclass775_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.uint_0 = uint_1;
		this.int_0 = int_2;
		this.int_1 = int_3;
		if (gclass201_2 == null)
		{
			this.gclass201_0 = new GClass201(0U);
		}
		else
		{
			this.gclass201_0 = gclass201_2;
		}
		if (gclass201_3 == null)
		{
			this.gclass201_1 = new GClass201(0U);
		}
		else
		{
			this.gclass201_1 = gclass201_3;
		}
		if (vector_3 == null)
		{
			this.vector_2 = new Vector<GClass503>();
		}
		else
		{
			this.vector_2 = vector_3;
		}
		if (vector_4 == null)
		{
			this.vector_0 = new Vector<GClass503>();
		}
		else
		{
			this.vector_0 = vector_4;
		}
		if (vector_5 == null)
		{
			this.vector_1 = new Vector<GClass379>();
		}
		else
		{
			this.vector_1 = vector_5;
		}
		if (gclass775_1 == null)
		{
			this.gclass775_0 = new GClass775("", null);
			return;
		}
		this.gclass775_0 = gclass775_1;
	}

	public virtual int vmethod_0()
	{
		return 10715;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass503 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass503;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass379 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass379;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		this.gclass201_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_1.imethod_1(binaryStream_0);
		this.gclass775_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass775);
		this.gclass775_0.imethod_1(binaryStream_0);
		while (this.vector_2.Length > 0)
		{
			this.vector_2.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass503 gclass3 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass503;
			gclass3.imethod_1(binaryStream_0);
			this.vector_2.method_0(gclass3);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(10715);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.smethod_5(this.uint_0);
		this.gclass201_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass503 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.vector_1.Length);
		foreach (GClass379 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		this.gclass201_1.imethod_2(binaryStream_0);
		this.gclass775_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.vector_2.Length);
		foreach (GClass503 gclass3 in this.vector_2)
		{
			gclass3.imethod_2(binaryStream_0);
		}
	}

	public int int_0;

	public uint uint_0;

	public GClass201 gclass201_0;

	public Vector<GClass503> vector_0;

	public Vector<GClass379> vector_1;

	public int int_1;

	public GClass201 gclass201_1;

	public GClass775 gclass775_0;

	public Vector<GClass503> vector_2;
}
