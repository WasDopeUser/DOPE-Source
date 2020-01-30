using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass348 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10211;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass348(string string_0 = "", Vector<GClass758> vector_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		this.Name = "";
		base..ctor();
		this.Name = string_0;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass758>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 10211;
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
			GClass758 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass758;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.Name = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10211);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass758 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.Name);
	}

	public Vector<GClass758> vector_0;

	public string Name;
}
