using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass193 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -28189;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass193(int int_2 = 0, int int_3 = 0, int int_4 = 0, Vector<GClass194> vector_1 = null, GClass196 gclass196_0 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass196_0 == null)
		{
			this.Mode = new GClass196(0);
		}
		else
		{
			this.Mode = gclass196_0;
		}
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.Id = int_2;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass194>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return -28189;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Mode = (GClass196)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.Mode != null)
		{
			this.Mode.imethod_1(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 12) | this.Id << 20);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass194 gclass = (GClass194)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-28189);
		if (this.Mode != null)
		{
			this.Mode.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_4(this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		binaryStream_0.smethod_4(this.Id << 12 | U.smethod_0(this.Id, 20));
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass194 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public GClass196 Mode;

	public int int_0;

	public int int_1;

	public int Id;

	public Vector<GClass194> vector_0;
}
