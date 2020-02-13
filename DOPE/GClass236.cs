using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass236 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29702;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass236(Vector<GClass251> vector_2 = null, string string_1 = "", Vector<GClass417> vector_3 = null)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		if (vector_2 == null)
		{
			this.vector_0 = new Vector<GClass251>();
		}
		else
		{
			this.vector_0 = vector_2;
		}
		this.string_0 = string_1;
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass417>();
			return;
		}
		this.vector_1 = vector_3;
	}

	public virtual int vmethod_0()
	{
		return 29702;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass251 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass251;
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
			GClass417 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass417;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(29702);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass251 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.vector_1.Length);
		foreach (GClass417 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
	}

	public string string_0;

	public Vector<GClass251> vector_0;

	public Vector<GClass417> vector_1;
}
