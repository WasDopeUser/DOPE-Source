using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass462 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30462;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass462(uint uint_1 = 0U, Vector<GClass653> vector_1 = null, bool bool_1 = false)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.uint_0 = uint_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass653>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 30462;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass653 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass653;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(30462);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass653 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.smethod_6(-1368);
	}

	public bool bool_0;

	public Vector<GClass653> vector_0;

	public uint uint_0;
}
