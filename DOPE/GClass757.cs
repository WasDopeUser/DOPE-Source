using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass757 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21789;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass757(Vector<GClass757> vector_1 = null, string string_0 = "", GClass585 gclass585_0 = null)
	{
		Class13.plZSWFPzBWWEZ();
		this.Name = "";
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass757>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.Name = string_0;
		if (gclass585_0 == null)
		{
			this.Value = new GClass585("");
			return;
		}
		this.Value = gclass585_0;
	}

	public virtual int vmethod_0()
	{
		return 21789;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Value = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass585);
		this.Value.imethod_1(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass757 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass757;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
		this.Name = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21789);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.Value.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass757 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_7(-4817);
		binaryStream_0.smethod_3(this.Name);
	}

	public GClass585 Value;

	public Vector<GClass757> vector_0;

	public string Name;
}
