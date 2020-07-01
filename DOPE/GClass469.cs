using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass469 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2211;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass469(int int_1 = 0, Vector<GClass701> vector_1 = null, bool bool_1 = false)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass701>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 2211;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass701 gclass = (GClass701)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_0(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2211);
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass701 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int int_0;

	public Vector<GClass701> vector_0;

	public bool bool_0;
}
