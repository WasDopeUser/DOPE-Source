using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass641 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13953;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass641(Vector<GClass666> vector_1 = null, bool bool_1 = false, int int_2 = 0, int int_3 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass666>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.bool_0 = bool_1;
		this.int_1 = int_2;
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 13953;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		this.bool_0 = binaryStream_0.ReadBoolean();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass666 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass666;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 8) | this.int_1 << 24);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13953);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass666 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_7(19337);
		binaryStream_0.smethod_7(-9614);
		binaryStream_0.smethod_4(this.int_1 << 8 | U.smethod_0(this.int_1, 24));
	}

	public int int_0;

	public bool bool_0;

	public Vector<GClass666> vector_0;

	public int int_1;
}
