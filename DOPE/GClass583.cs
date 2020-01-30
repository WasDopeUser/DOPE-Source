using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass583 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13134;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass583(uint uint_1 = 0U, Vector<GClass420> vector_1 = null, string string_2 = "", string string_3 = "")
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.uint_0 = uint_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass420>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.string_1 = string_2;
		this.string_0 = string_3;
	}

	public virtual int vmethod_0()
	{
		return 13134;
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
			GClass420 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass420;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13134);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass420 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
	}

	public Vector<GClass420> vector_0;

	public uint uint_0;

	public string string_0;

	public string string_1;
}
