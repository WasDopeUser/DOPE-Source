using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass308 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -29263;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass308(GClass522 gclass522_0 = null, int int_1 = 0, string string_1 = "", Vector<GClass692> vector_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.int_0 = int_1;
		if (gclass522_0 == null)
		{
			this.Status = new GClass522(0, 0.0, 0);
		}
		else
		{
			this.Status = gclass522_0;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass692>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return -29263;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.Status = (GClass522)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.Status != null)
		{
			this.Status.imethod_1(binaryStream_0);
		}
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass692 gclass = (GClass692)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-29263);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		if (this.Status != null)
		{
			this.Status.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass692 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public string string_0;

	public int int_0;

	public GClass522 Status;

	public Vector<GClass692> vector_0;
}
