using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass245 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31946;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass245(Vector<GClass243> vector_0 = null, int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (vector_0 == null)
		{
			this.Items = new Vector<GClass243>();
		}
		else
		{
			this.Items = vector_0;
		}
		this.int_2 = int_3;
		this.int_0 = int_4;
		this.int_1 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 31946;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_1();
		while (this.Items.Length > 0)
		{
			this.Items.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass243 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass243;
			gclass.imethod_1(binaryStream_0);
			this.Items.method_0(gclass);
			num++;
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 4 | U.smethod_0(this.int_2, 28));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(31946);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.smethod_6(17668);
		binaryStream_0.smethod_3(this.Items.Length);
		foreach (GClass243 gclass in this.Items)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		binaryStream_0.smethod_6(29663);
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 4) | this.int_2 << 28);
	}

	public int int_0;

	public Vector<GClass243> Items;

	public int int_1;

	public int int_2;
}
