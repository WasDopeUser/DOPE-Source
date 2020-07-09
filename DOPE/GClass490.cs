using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass490 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2279;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass490(Vector<GClass377> vector_1 = null, int int_1 = 0, int int_2 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.YclZumLmFp = int_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass377>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 2279;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.YclZumLmFp = binaryStream_0.smethod_0();
		this.YclZumLmFp = (this.YclZumLmFp << 8 | U.smethod_0(this.YclZumLmFp, 24));
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass377 gclass = (GClass377)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.int_0 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2279);
		binaryStream_0.smethod_4(U.smethod_0(this.YclZumLmFp, 8) | this.YclZumLmFp << 24);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass377 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_7(this.int_0);
	}

	public int YclZumLmFp;

	public Vector<GClass377> vector_0;

	public int int_0;
}
