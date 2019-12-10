using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass506 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20887;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass506(GClass619 gclass619_0 = null, string string_1 = "", Vector<GClass317> vector_1 = null)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		if (gclass619_0 == null)
		{
			this.bEdUuIeQdw = new GClass619(false, null);
		}
		else
		{
			this.bEdUuIeQdw = gclass619_0;
		}
		this.string_0 = string_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass317>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 20887;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass317 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass317;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.bEdUuIeQdw = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass619);
		this.bEdUuIeQdw.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(20887);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass317 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_5(22733);
		binaryStream_0.smethod_3(this.string_0);
		this.bEdUuIeQdw.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(8086);
	}

	public Vector<GClass317> vector_0;

	public string string_0;

	public GClass619 bEdUuIeQdw;
}
