using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass773 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10818;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass773(string string_1 = "", Vector<GClass543> vector_1 = null)
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass543>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 10818;
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
			GClass543 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass543;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10818);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass543 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(15294);
		binaryStream_0.smethod_7(12254);
	}

	public Vector<GClass543> vector_0;

	public string string_0;
}
