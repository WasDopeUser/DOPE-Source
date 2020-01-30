using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass217 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31320;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass217(string string_1 = "", string string_2 = "", string string_3 = "", GClass617 gclass617_1 = null, Vector<GClass559> vector_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		this.uYxSwVoieM = "";
		this.string_0 = "";
		this.tawSrisLpr = "";
		base..ctor();
		this.tawSrisLpr = string_1;
		this.uYxSwVoieM = string_2;
		this.string_0 = string_3;
		if (gclass617_1 == null)
		{
			this.gclass617_0 = new GClass617(0U);
		}
		else
		{
			this.gclass617_0 = gclass617_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass559>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 31320;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uYxSwVoieM = binaryStream_0.smethod_2();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass559 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass559;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.tawSrisLpr = binaryStream_0.smethod_2();
		this.gclass617_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass617);
		this.gclass617_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31320);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.uYxSwVoieM);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass559 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_7(21486);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.tawSrisLpr);
		this.gclass617_0.imethod_2(binaryStream_0);
	}

	public string uYxSwVoieM;

	public Vector<GClass559> vector_0;

	public string string_0;

	public string tawSrisLpr;

	public GClass617 gclass617_0;
}
