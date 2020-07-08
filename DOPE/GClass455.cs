using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass455 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2090;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass455(GClass490 gclass490_1 = null, Vector<GClass679> vector_1 = null, GClass679 gclass679_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass490_1 == null)
		{
			this.gclass490_0 = new GClass490(0, null, null, null, null, "", "");
		}
		else
		{
			this.gclass490_0 = gclass490_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass679>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass679_1 == null)
		{
			this.gclass679_0 = new GClass679("", "", 0, 0, 0);
			return;
		}
		this.gclass679_0 = gclass679_1;
	}

	public virtual int vmethod_0()
	{
		return 2090;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass490_0 = (GClass490)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass490_0 != null)
		{
			this.gclass490_0.imethod_1(binaryStream_0);
		}
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass679 gclass = (GClass679)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.gclass679_0 = (GClass679)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass679_0 != null)
		{
			this.gclass679_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2090);
		if (this.gclass490_0 != null)
		{
			this.gclass490_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass679 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		if (this.gclass679_0 != null)
		{
			this.gclass679_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass490 gclass490_0;

	public Vector<GClass679> vector_0;

	public GClass679 gclass679_0;
}
