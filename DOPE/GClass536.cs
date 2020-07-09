using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass536 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14616;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass536(GClass674 gclass674_1 = null, string string_1 = "", Vector<GClass341> vector_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		base..ctor();
		if (gclass674_1 == null)
		{
			this.gclass674_0 = new GClass674(false, null);
		}
		else
		{
			this.gclass674_0 = gclass674_1;
		}
		this.string_0 = string_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass341>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 14616;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass674_0 = (GClass674)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass674_0 != null)
		{
			this.gclass674_0.imethod_1(binaryStream_0);
		}
		this.string_0 = binaryStream_0.smethod_2();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = (int)binaryStream_0.smethod_1();
		while (i < num)
		{
			GClass341 gclass = (GClass341)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14616);
		if (this.gclass674_0 != null)
		{
			this.gclass674_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(this.vector_0.Length);
		foreach (GClass341 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public GClass674 gclass674_0;

	public string string_0;

	public Vector<GClass341> vector_0;
}
