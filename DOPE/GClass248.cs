using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass248 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7263;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass248(string string_1 = "", Vector<GClass249> vector_0 = null)
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (vector_0 == null)
		{
			this.Items = new Vector<GClass249>();
			return;
		}
		this.Items = vector_0;
	}

	public virtual int vmethod_0()
	{
		return 7263;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		while (this.Items.Length > 0)
		{
			this.Items.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass249 gclass = (GClass249)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.Items.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7263);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteByte(this.Items.Length);
		foreach (GClass249 gclass in this.Items)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public string string_0;

	public Vector<GClass249> Items;
}
