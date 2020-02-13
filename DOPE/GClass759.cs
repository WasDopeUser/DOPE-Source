using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass759 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27501;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass759(Vector<GClass759> vector_1 = null, string string_0 = "", GClass587 gclass587_0 = null)
	{
		Class13.igxcIukzfpare();
		this.Name = "";
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass759>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.Name = string_0;
		if (gclass587_0 == null)
		{
			this.Value = new GClass587("");
			return;
		}
		this.Value = gclass587_0;
	}

	public virtual int vmethod_0()
	{
		return 27501;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Value = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass587);
		this.Value.imethod_1(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass759 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass759;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.Name = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(27501);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.Value.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass759 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.MoioCjQkqp0(this.Name);
	}

	public GClass587 Value;

	public Vector<GClass759> vector_0;

	public string Name;
}
