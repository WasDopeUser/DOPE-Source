using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass218 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21617;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass218(string string_3 = "", string string_4 = "", string string_5 = "", GClass633 gclass633_1 = null, Vector<GClass574> vector_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		base..ctor();
		this.string_1 = string_3;
		this.string_0 = string_4;
		this.string_2 = string_5;
		if (gclass633_1 == null)
		{
			this.gclass633_0 = new GClass633(0U);
		}
		else
		{
			this.gclass633_0 = gclass633_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass574>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 21617;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass633_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass633);
		this.gclass633_0.HrqIugnatr8(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass574 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass574;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.string_1 = binaryStream_0.smethod_2();
		this.string_2 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21617);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass633_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass574 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_3(this.string_2);
	}

	public GClass633 gclass633_0;

	public string string_0;

	public Vector<GClass574> vector_0;

	public string string_1;

	public string string_2;
}
