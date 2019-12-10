using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass207 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2064;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass207(string string_3 = "", string string_4 = "", string string_5 = "", GClass604 gclass604_1 = null, Vector<GClass546> vector_1 = null)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		base..ctor();
		this.string_2 = string_3;
		this.string_1 = string_4;
		this.string_0 = string_5;
		if (gclass604_1 == null)
		{
			this.gclass604_0 = new GClass604(0U);
		}
		else
		{
			this.gclass604_0 = gclass604_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass546>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 2064;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.gclass604_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass604);
		this.gclass604_0.imethod_1(binaryStream_0);
		this.string_2 = binaryStream_0.smethod_2();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass546 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass546;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(2064);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		this.gclass604_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_2);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass546 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_5(441);
	}

	public string string_0;

	public string string_1;

	public GClass604 gclass604_0;

	public string string_2;

	public Vector<GClass546> vector_0;
}
