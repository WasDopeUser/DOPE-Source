using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass502 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16460;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass502(string string_1 = "", GClass336 gclass336_1 = null, Vector<GClass319> vector_1 = null)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (gclass336_1 == null)
		{
			this.gclass336_0 = new GClass336(0U);
		}
		else
		{
			this.gclass336_0 = gclass336_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass319>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 16460;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass319 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass319;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass336_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass336);
		this.gclass336_0.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(16460);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-20374);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass319 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		this.gclass336_0.imethod_2(binaryStream_0);
		binaryStream_0.MoioCjQkqp0(this.string_0);
	}

	public Vector<GClass319> vector_0;

	public GClass336 gclass336_0;

	public string string_0;
}
