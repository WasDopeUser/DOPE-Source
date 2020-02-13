using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass575 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29006;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass575(string string_1 = "", GClass201 gclass201_1 = null, Vector<GClass201> vector_1 = null, int int_1 = 0, double double_1 = 0.0, uint uint_1 = 0U)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0U);
		}
		else
		{
			this.gclass201_0 = gclass201_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass201>();
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
		return 29006;
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
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass201 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(29006);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_3(this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass201 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		this.gclass201_0.imethod_2(binaryStream_0);
	}

	public uint uint_0;

	public string string_0;

	public double double_0;

	public int int_0;

	public Vector<GClass201> vector_0;

	public GClass201 gclass201_0;
}
