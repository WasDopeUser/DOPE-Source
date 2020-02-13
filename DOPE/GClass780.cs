using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass780 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8199;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass780(string string_1 = "", Vector<GClass377> vector_0 = null)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (vector_0 == null)
		{
			this.Items = new Vector<GClass377>();
			return;
		}
		this.Items = vector_0;
	}

	public virtual int vmethod_0()
	{
		return 8199;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		while (this.Items.Length > 0)
		{
			this.Items.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass377 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass377;
			gclass.imethod_1(binaryStream_0);
			this.Items.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(8199);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-5729);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_3(this.Items.Length);
		foreach (GClass377 gclass in this.Items)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public string string_0;

	public Vector<GClass377> Items;
}
