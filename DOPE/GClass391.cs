using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass391 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6425;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass391(Vector<GClass348> vector_1 = null, double double_0 = 0.0, int int_1 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass348>();
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
		return 6425;
	}

	public virtual int vmethod_1()
	{
		return 16;
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
			GClass348 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass348;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.Timestamp = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 7 | U.smethod_0(this.int_0, 25));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(6425);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass348 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteDouble(this.Timestamp);
		binaryStream_0.smethod_6(28057);
		binaryStream_0.smethod_6(28706);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 7) | this.int_0 << 25);
	}

	public Vector<GClass348> vector_0;

	public double Timestamp;

	public int int_0;
}
