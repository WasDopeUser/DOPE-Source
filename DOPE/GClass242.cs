using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass242 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -19699;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass242(Vector<GClass240> vector_0 = null, int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (vector_0 == null)
		{
			this.Items = new Vector<GClass240>();
		}
		else
		{
			this.Items = vector_0;
		}
		this.int_0 = int_5;
		this.int_1 = int_4;
		this.int_2 = int_3;
	}

	public virtual int vmethod_0()
	{
		return -19699;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.Items.Length > 0)
		{
			this.Items.method_1();
		}
		int i = 0;
		int num = (int)binaryStream_0.smethod_1();
		while (i < num)
		{
			GClass240 gclass = (GClass240)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.Items.method_0(gclass);
			i++;
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 8) | this.int_1 << 24);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 10 | U.smethod_0(this.int_2, 22));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-19699);
		binaryStream_0.smethod_7(this.Items.Length);
		foreach (GClass240 gclass in this.Items)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		binaryStream_0.smethod_4(this.int_1 << 8 | U.smethod_0(this.int_1, 24));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 10) | this.int_2 << 22);
	}

	public Vector<GClass240> Items;

	public int int_0;

	public int int_1;

	public int int_2;
}
