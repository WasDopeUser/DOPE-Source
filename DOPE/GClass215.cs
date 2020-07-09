using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass215 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 252;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass215(string string_2 = "", string string_3 = "", string string_4 = "", GClass659 gclass659_1 = null, Vector<GClass584> vector_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		this.string_1 = "";
		this.yTyQrtxjtv = "";
		base..ctor();
		this.string_0 = string_2;
		this.string_1 = string_3;
		this.yTyQrtxjtv = string_4;
		if (gclass659_1 == null)
		{
			this.gclass659_0 = new GClass659(0);
		}
		else
		{
			this.gclass659_0 = gclass659_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass584>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 252;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.yTyQrtxjtv = binaryStream_0.smethod_2();
		this.gclass659_0 = (GClass659)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass659_0 != null)
		{
			this.gclass659_0.imethod_1(binaryStream_0);
		}
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass584 gclass = (GClass584)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(252);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_3(this.yTyQrtxjtv);
		if (this.gclass659_0 != null)
		{
			this.gclass659_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass584 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public string string_0;

	public string string_1;

	public string yTyQrtxjtv;

	public GClass659 gclass659_0;

	public Vector<GClass584> vector_0;
}
