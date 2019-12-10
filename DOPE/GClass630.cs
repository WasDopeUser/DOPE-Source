using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass630 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14573;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass630(Vector<GClass655> vector_1 = null, bool bool_1 = false, int int_2 = 0, int int_3 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass655>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.bool_0 = bool_1;
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 14573;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass655 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass655;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(14573);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.fUeiimuocMk(this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass655 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public bool bool_0;

	public int int_0;

	public int int_1;

	public Vector<GClass655> vector_0;
}
