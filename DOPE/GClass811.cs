using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass811 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1521;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass811(int int_3 = 0, int int_4 = 0, int int_5 = 0, Vector<GClass808> vector_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.int_2 = int_5;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass808>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 1521;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 7) | this.int_2 << 25);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass808 gclass = (GClass808)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_0(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1521);
		binaryStream_0.smethod_4(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_4(this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		binaryStream_0.smethod_4(this.int_2 << 7 | U.smethod_0(this.int_2, 25));
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass808 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public Vector<GClass808> vector_0;
}
