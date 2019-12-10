using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass748 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6464;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass748(Vector<GClass748> vector_1 = null, string string_0 = "", GClass573 gclass573_0 = null)
	{
		Class8.xDph7tozmh5WD();
		this.Name = "";
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass748>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.Name = string_0;
		if (gclass573_0 == null)
		{
			this.Value = new GClass573("");
			return;
		}
		this.Value = gclass573_0;
	}

	public virtual int vmethod_0()
	{
		return 6464;
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
			GClass748 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass748;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.Name = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.Value = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass573);
		this.Value.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(6464);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass748 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_5(22872);
		this.Value.imethod_2(binaryStream_0);
	}

	public Vector<GClass748> vector_0;

	public string Name;

	public GClass573 Value;
}
