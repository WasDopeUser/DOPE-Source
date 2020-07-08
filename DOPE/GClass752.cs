using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass752 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1667;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass752(Vector<GClass790> vector_2 = null, int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, Vector<GClass790> vector_3 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (vector_2 == null)
		{
			this.vector_0 = new Vector<GClass790>();
		}
		else
		{
			this.vector_0 = vector_2;
		}
		this.int_0 = int_4;
		this.int_1 = int_5;
		this.int_2 = int_6;
		this.int_3 = int_7;
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass790>();
			return;
		}
		this.vector_1 = vector_3;
	}

	public virtual int vmethod_0()
	{
		return 1667;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass790 gclass = (GClass790)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 4 | U.smethod_0(this.int_2, 28));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 11 | U.smethod_0(this.int_3, 21));
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		i = 0;
		num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass790 gclass2 = (GClass790)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1667);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass790 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_4(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 4) | this.int_2 << 28);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 11) | this.int_3 << 21);
		binaryStream_0.WriteByte(this.vector_1.Length);
		foreach (GClass790 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
	}

	public Vector<GClass790> vector_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public Vector<GClass790> vector_1;
}
