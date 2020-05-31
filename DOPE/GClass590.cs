using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass590 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20902;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass590(string string_1 = "", GClass202 gclass202_1 = null, Vector<GClass202> vector_1 = null, int int_1 = 0, double double_1 = 0.0, uint uint_1 = 0U)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (gclass202_1 == null)
		{
			this.gclass202_0 = new GClass202(0U);
		}
		else
		{
			this.gclass202_0 = gclass202_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass202>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.int_0 = int_1;
		this.double_0 = double_1;
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 20902;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass202_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass202);
		this.gclass202_0.HrqIugnatr8(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		this.double_0 = binaryStream_0.ReadDouble();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass202 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass202;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20902);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		this.gclass202_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass202 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_6(this.uint_0);
	}

	public string string_0;

	public GClass202 gclass202_0;

	public int int_0;

	public double double_0;

	public Vector<GClass202> vector_0;

	public uint uint_0;
}
