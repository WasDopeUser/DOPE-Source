using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass777 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 521;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass777(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, Vector<GClass325> vector_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_4;
		this.int_1 = int_5;
		this.int_2 = int_6;
		this.int_3 = int_7;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass325>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 521;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 7 | U.smethod_0(this.int_1, 25));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 11 | U.smethod_0(this.int_2, 21));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 3) | this.int_3 << 29);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass325 gclass = (GClass325)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(521);
		binaryStream_0.smethod_4(this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 7) | this.int_1 << 25);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 11) | this.int_2 << 21);
		binaryStream_0.smethod_4(this.int_3 << 3 | U.smethod_0(this.int_3, 29));
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass325 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public Vector<GClass325> vector_0;
}
