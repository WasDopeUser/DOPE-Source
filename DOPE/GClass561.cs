using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass561 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23067;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass561(string string_1 = "", GClass191 gclass191_1 = null, Vector<GClass191> vector_1 = null, int int_1 = 0, double double_1 = 0.0, uint uint_1 = 0U)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (gclass191_1 == null)
		{
			this.gclass191_0 = new GClass191(0U);
		}
		else
		{
			this.gclass191_0 = gclass191_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass191>();
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
		return 23067;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.double_0 = binaryStream_0.ReadDouble();
		this.gclass191_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass191);
		this.gclass191_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass191 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass191;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(23067);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteDouble(this.double_0);
		this.gclass191_0.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass191 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public uint uint_0;

	public string string_0;

	public double double_0;

	public GClass191 gclass191_0;

	public int int_0;

	public Vector<GClass191> vector_0;
}
