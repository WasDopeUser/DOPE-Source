using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass511 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2000;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 15;
		}
	}

	public GClass511(int int_1 = 0, bool bool_3 = false, bool bool_4 = false, bool bool_5 = false, int int_2 = 0, Vector<GClass529> vector_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.Id = int_1;
		this.bool_0 = bool_3;
		this.bool_1 = bool_4;
		this.bool_2 = bool_5;
		this.int_0 = int_2;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass529>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 2000;
	}

	public virtual int vmethod_1()
	{
		return 15;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 11) | this.Id << 21);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass529 gclass = (GClass529)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2000);
		binaryStream_0.smethod_4(this.Id << 11 | U.smethod_0(this.Id, 21));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass529 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public int Id;

	public bool bool_0;

	public bool bool_1;

	public bool bool_2;

	public int int_0;

	public Vector<GClass529> vector_0;
}
