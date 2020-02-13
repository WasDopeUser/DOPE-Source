using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass643 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10241;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass643(Vector<GClass668> vector_1 = null, bool bool_1 = false, int int_2 = 0, int int_3 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass668>();
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
		return 10241;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass668 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass668;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(10241);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass668 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public bool bool_0;

	public int int_0;

	public int int_1;

	public Vector<GClass668> vector_0;
}
