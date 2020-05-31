using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass722 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29538;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass722(uint uint_1 = 0U, int int_2 = 0, int int_3 = 0, GClass202 gclass202_2 = null, GClass202 gclass202_3 = null, Vector<GClass513> vector_3 = null, Vector<GClass513> vector_4 = null, Vector<GClass385> vector_5 = null, GClass789 gclass789_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.uint_0 = uint_1;
		this.int_0 = int_2;
		this.int_1 = int_3;
		if (gclass202_2 == null)
		{
			this.gclass202_1 = new GClass202(0U);
		}
		else
		{
			this.gclass202_1 = gclass202_2;
		}
		if (gclass202_3 == null)
		{
			this.gclass202_0 = new GClass202(0U);
		}
		else
		{
			this.gclass202_0 = gclass202_3;
		}
		if (vector_3 == null)
		{
			this.vector_2 = new Vector<GClass513>();
		}
		else
		{
			this.vector_2 = vector_3;
		}
		if (vector_4 == null)
		{
			this.vector_0 = new Vector<GClass513>();
		}
		else
		{
			this.vector_0 = vector_4;
		}
		if (vector_5 == null)
		{
			this.vector_1 = new Vector<GClass385>();
		}
		else
		{
			this.vector_1 = vector_5;
		}
		if (gclass789_1 == null)
		{
			this.gclass789_0 = new GClass789("", null);
			return;
		}
		this.gclass789_0 = gclass789_1;
	}

	public virtual int vmethod_0()
	{
		return 29538;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass789_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass789);
		this.gclass789_0.HrqIugnatr8(binaryStream_0);
		this.gclass202_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass202);
		this.gclass202_0.HrqIugnatr8(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass513 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass513;
			gclass.HrqIugnatr8(binaryStream_0);
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
			GClass385 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass385;
			gclass2.HrqIugnatr8(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		this.gclass202_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass202);
		this.gclass202_1.HrqIugnatr8(binaryStream_0);
		while (this.vector_2.Length > 0)
		{
			this.vector_2.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass513 gclass3 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass513;
			gclass3.HrqIugnatr8(binaryStream_0);
			this.vector_2.method_0(gclass3);
			num++;
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 13) | this.int_1 << 19);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29538);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.uint_0);
		this.gclass789_0.imethod_1(binaryStream_0);
		this.gclass202_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass513 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_4(this.vector_1.Length);
		foreach (GClass385 gclass2 in this.vector_1)
		{
			gclass2.imethod_1(binaryStream_0);
		}
		this.gclass202_1.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(this.vector_2.Length);
		foreach (GClass513 gclass3 in this.vector_2)
		{
			gclass3.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_4(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_4(this.int_1 << 13 | U.smethod_0(this.int_1, 19));
	}

	public uint uint_0;

	public GClass789 gclass789_0;

	public GClass202 gclass202_0;

	public Vector<GClass513> vector_0;

	public Vector<GClass385> vector_1;

	public GClass202 gclass202_1;

	public Vector<GClass513> vector_2;

	public int int_0;

	public int int_1;
}
