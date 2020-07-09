using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass844 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19398;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass844(string string_1 = "", Vector<GClass377> vector_0 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (vector_0 == null)
		{
			this.Items = new Vector<GClass377>();
			return;
		}
		this.Items = vector_0;
	}

	public virtual int vmethod_0()
	{
		return 19398;
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
			GClass377 gclass = (GClass377)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.Items.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19398);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteByte(this.Items.Length);
		foreach (GClass377 gclass in this.Items)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public string string_0;

	public Vector<GClass377> Items;
}
