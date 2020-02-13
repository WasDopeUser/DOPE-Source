using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass520 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15783;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass520(GClass633 gclass633_1 = null, string string_1 = "", Vector<GClass334> vector_1 = null)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		if (gclass633_1 == null)
		{
			this.gclass633_0 = new GClass633(false, null);
		}
		else
		{
			this.gclass633_0 = gclass633_1;
		}
		this.string_0 = string_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass334>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 15783;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass633_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass633);
		this.gclass633_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass334 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass334;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(15783);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass633_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(-22117);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass334 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_6(25997);
	}

	public GClass633 gclass633_0;

	public Vector<GClass334> vector_0;

	public string string_0;
}
