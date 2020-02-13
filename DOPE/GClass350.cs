using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass350 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12546;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass350(string string_0 = "", Vector<GClass759> vector_1 = null)
	{
		Class13.igxcIukzfpare();
		this.Name = "";
		base..ctor();
		this.Name = string_0;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass759>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 12546;
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
			GClass759 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass759;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.Name = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(12546);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass759 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.MoioCjQkqp0(this.Name);
		binaryStream_0.smethod_6(22135);
	}

	public Vector<GClass759> vector_0;

	public string Name;
}
