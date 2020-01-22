using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass540 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12558;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass540(string string_1 = "", double double_1 = 0.0, Vector<GClass778> vector_1 = null)
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.double_0 = double_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass778>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 12558;
	}

	public virtual int vmethod_1()
	{
		return 14;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.double_0 = binaryStream_0.ReadDouble();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass778 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass778;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(12558);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass778 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public string string_0;

	public double double_0;

	public Vector<GClass778> vector_0;
}
