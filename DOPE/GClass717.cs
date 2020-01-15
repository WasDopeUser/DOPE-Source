using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass717 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11656;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass717(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, Vector<GClass316> vector_1 = null)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.int_3 = int_4;
		this.int_2 = int_5;
		this.int_1 = int_6;
		this.int_0 = int_7;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass316>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 11656;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 14 | U.smethod_0(this.int_1, 18));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 4) | this.int_2 << 28);
		binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 2) | this.int_3 << 30);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass316 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass316;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11656);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 14) | this.int_1 << 18);
		binaryStream_0.smethod_4(this.int_2 << 4 | U.smethod_0(this.int_2, 28));
		binaryStream_0.smethod_7(-22373);
		binaryStream_0.smethod_4(this.int_3 << 2 | U.smethod_0(this.int_3, 30));
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass316 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public Vector<GClass316> vector_0;
}
