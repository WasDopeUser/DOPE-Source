using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass483 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18391;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass483(Vector<GClass377> vector_1 = null, int int_1 = 0, uint uint_1 = 0U)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass377>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.int_0 = int_1;
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 18391;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass377 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass377;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(18391);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass377 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.smethod_3(this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		binaryStream_0.smethod_6(5178);
	}

	public Vector<GClass377> vector_0;

	public uint uint_0;

	public int int_0;
}
