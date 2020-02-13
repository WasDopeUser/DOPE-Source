using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass584 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27537;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass584(uint uint_1 = 0U, Vector<GClass422> vector_1 = null, string string_2 = "", string string_3 = "")
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.uint_0 = uint_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass422>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.string_0 = string_2;
		this.string_1 = string_3;
	}

	public virtual int vmethod_0()
	{
		return 27537;
	}

	public virtual int vmethod_1()
	{
		return 8;
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
			GClass422 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass422;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.string_0 = binaryStream_0.smethod_2();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.string_1 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(27537);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass422 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.MoioCjQkqp0(this.string_1);
	}

	public Vector<GClass422> vector_0;

	public string string_0;

	public uint uint_0;

	public string string_1;
}
