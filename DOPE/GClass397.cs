using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass397 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27507;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass397(Vector<GClass354> vector_1 = null, double double_0 = 0.0, int int_1 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass354>();
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
		return 27507;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
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
			GClass354 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass354;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 10 | U.smethod_0(this.int_0, 22));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27507);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.Timestamp);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass354 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 10) | this.int_0 << 22);
	}

	public double Timestamp;

	public Vector<GClass354> vector_0;

	public int int_0;
}
