using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass390 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17133;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass390(Vector<GClass346> vector_1 = null, double double_0 = 0.0, int int_1 = 0)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass346>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.Timestamp = double_0;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 17133;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Timestamp = binaryStream_0.ReadDouble();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass346 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass346;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(17133);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.Timestamp);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass346 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		binaryStream_0.smethod_7(23917);
	}

	public double Timestamp;

	public Vector<GClass346> vector_0;

	public int int_0;
}
