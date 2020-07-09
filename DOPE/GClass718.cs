using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass718 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 291;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass718(int int_1 = 0, int int_2 = 0, bool bool_1 = false, Vector<GClass793> vector_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_1;
		this.Uridium = int_2;
		this.bool_0 = bool_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass793>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 291;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.Uridium = binaryStream_0.smethod_0();
		this.Uridium = (this.Uridium << 12 | U.smethod_0(this.Uridium, 20));
		this.bool_0 = binaryStream_0.ReadBoolean();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass793 gclass = (GClass793)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(291);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_4(U.smethod_0(this.Uridium, 12) | this.Uridium << 20);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass793 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public int int_0;

	public int Uridium;

	public bool bool_0;

	public Vector<GClass793> vector_0;
}
