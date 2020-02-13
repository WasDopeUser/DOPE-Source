using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass719 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 638;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass719(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, Vector<GClass318> vector_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_2 = int_4;
		this.int_0 = int_5;
		this.int_1 = int_6;
		this.int_3 = int_7;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass318>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 638;
	}

	public virtual int vmethod_1()
	{
		return 20;
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
			GClass318 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass318;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 11) | this.int_2 << 21);
		binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 8) | this.int_3 << 24);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(638);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass318 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		binaryStream_0.smethod_3(this.int_2 << 11 | U.smethod_0(this.int_2, 21));
		binaryStream_0.smethod_6(-11163);
		binaryStream_0.smethod_3(this.int_3 << 8 | U.smethod_0(this.int_3, 24));
	}

	public Vector<GClass318> vector_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;
}
