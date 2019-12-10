using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass488 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1304;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass488(string string_1 = "", GClass319 gclass319_1 = null, Vector<GClass303> vector_1 = null)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (gclass319_1 == null)
		{
			this.gclass319_0 = new GClass319(0U);
		}
		else
		{
			this.gclass319_0 = gclass319_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass303>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 1304;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass319_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass319);
		this.gclass319_0.imethod_1(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass303 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass303;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(1304);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		this.gclass319_0.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass303 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public string string_0;

	public GClass319 gclass319_0;

	public Vector<GClass303> vector_0;
}
