using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass525 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 327;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass525(GClass496 gclass496_1 = null, Vector<GClass661> vector_1 = null, Vector<GClass661> vector_2 = null, double double_2 = 0.0, double double_3 = 0.0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass496_1 == null)
		{
			this.gclass496_0 = new GClass496(0, 0, 0);
		}
		else
		{
			this.gclass496_0 = gclass496_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass661>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (vector_2 == null)
		{
			this.taoZarxkgL = new Vector<GClass661>();
		}
		else
		{
			this.taoZarxkgL = vector_2;
		}
		this.double_0 = double_2;
		this.double_1 = double_3;
	}

	public virtual int vmethod_0()
	{
		return 327;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass661 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass661;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.double_0 = binaryStream_0.ReadDouble();
		while (this.taoZarxkgL.Length > 0)
		{
			this.taoZarxkgL.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass661 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass661;
			gclass2.HrqIugnatr8(binaryStream_0);
			this.taoZarxkgL.method_0(gclass2);
			num++;
		}
		this.gclass496_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass496);
		this.gclass496_0.HrqIugnatr8(binaryStream_0);
		this.double_1 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(327);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass661 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_4(this.taoZarxkgL.Length);
		foreach (GClass661 gclass2 in this.taoZarxkgL)
		{
			gclass2.imethod_1(binaryStream_0);
		}
		this.gclass496_0.imethod_1(binaryStream_0);
		binaryStream_0.WriteDouble(this.double_1);
	}

	public Vector<GClass661> vector_0;

	public double double_0;

	public Vector<GClass661> taoZarxkgL;

	public GClass496 gclass496_0;

	public double double_1;
}
