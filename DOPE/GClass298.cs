using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass298 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15453;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass298(Vector<GClass622> vector_3 = null, Vector<GClass622> vector_4 = null, Vector<GClass622> vector_5 = null, GClass622 gclass622_0 = null, GClass202 gclass202_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass622>();
		}
		else
		{
			this.vector_1 = vector_3;
		}
		if (vector_4 == null)
		{
			this.vector_0 = new Vector<GClass622>();
		}
		else
		{
			this.vector_0 = vector_4;
		}
		if (vector_5 == null)
		{
			this.vector_2 = new Vector<GClass622>();
		}
		else
		{
			this.vector_2 = vector_5;
		}
		if (gclass622_0 == null)
		{
			this.fnZebuyjtc = new GClass622(0, 0, "", "", "", 0);
		}
		else
		{
			this.fnZebuyjtc = gclass622_0;
		}
		if (gclass202_1 == null)
		{
			this.gclass202_0 = new GClass202(0U);
			return;
		}
		this.gclass202_0 = gclass202_1;
	}

	public virtual int vmethod_0()
	{
		return 15453;
	}

	public virtual int vmethod_1()
	{
		return 12;
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
			GClass622 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass622;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass202_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass202);
		this.gclass202_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.fnZebuyjtc = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass622);
		this.fnZebuyjtc.HrqIugnatr8(binaryStream_0);
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass622 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass622;
			gclass2.HrqIugnatr8(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		while (this.vector_2.Length > 0)
		{
			this.vector_2.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass622 gclass3 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass622;
			gclass3.HrqIugnatr8(binaryStream_0);
			this.vector_2.method_0(gclass3);
			num++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(15453);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass622 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		this.gclass202_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(-32111);
		this.fnZebuyjtc.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(this.vector_1.Length);
		foreach (GClass622 gclass2 in this.vector_1)
		{
			gclass2.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_4(this.vector_2.Length);
		foreach (GClass622 gclass3 in this.vector_2)
		{
			gclass3.imethod_1(binaryStream_0);
		}
	}

	public Vector<GClass622> vector_0;

	public GClass202 gclass202_0;

	public GClass622 fnZebuyjtc;

	public Vector<GClass622> vector_1;

	public Vector<GClass622> vector_2;
}
