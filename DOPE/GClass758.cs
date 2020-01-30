using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass758 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25795;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass758(Vector<GClass758> vector_1 = null, string string_0 = "", GClass586 gclass586_0 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		this.Name = "";
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass758>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.Name = string_0;
		if (gclass586_0 == null)
		{
			this.Value = new GClass586("");
			return;
		}
		this.Value = gclass586_0;
	}

	public virtual int vmethod_0()
	{
		return 25795;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.Name = binaryStream_0.smethod_2();
		this.Value = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass586);
		this.Value.imethod_1(binaryStream_0);
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
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25795);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-3379);
		binaryStream_0.smethod_3(this.Name);
		this.Value.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass758 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public string Name;

	public GClass586 Value;

	public Vector<GClass758> vector_0;
}
