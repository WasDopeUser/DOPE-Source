using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass292 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1544;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass292(Vector<GClass605> vector_3 = null, Vector<GClass605> vector_4 = null, Vector<GClass605> vector_5 = null, GClass605 gclass605_1 = null, GClass201 gclass201_1 = null)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (vector_3 == null)
		{
			this.vector_0 = new Vector<GClass605>();
		}
		else
		{
			this.vector_0 = vector_3;
		}
		if (vector_4 == null)
		{
			this.vector_1 = new Vector<GClass605>();
		}
		else
		{
			this.vector_1 = vector_4;
		}
		if (vector_5 == null)
		{
			this.vector_2 = new Vector<GClass605>();
		}
		else
		{
			this.vector_2 = vector_5;
		}
		if (gclass605_1 == null)
		{
			this.gclass605_0 = new GClass605(0, 0, "", "", "", 0);
		}
		else
		{
			this.gclass605_0 = gclass605_1;
		}
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0U);
			return;
		}
		this.gclass201_0 = gclass201_1;
	}

	public virtual int vmethod_0()
	{
		return 1544;
	}

	public virtual int vmethod_1()
	{
		return 12;
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
			GClass605 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass605;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass605 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass605;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		this.gclass605_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass605);
		this.gclass605_0.imethod_1(binaryStream_0);
		while (this.vector_2.Length > 0)
		{
			this.vector_2.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass605 gclass3 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass605;
			gclass3.imethod_1(binaryStream_0);
			this.vector_2.method_0(gclass3);
			num++;
		}
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1544);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass605 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_4(this.vector_1.Length);
		foreach (GClass605 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		this.gclass605_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.vector_2.Length);
		foreach (GClass605 gclass3 in this.vector_2)
		{
			gclass3.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_7(-10608);
		binaryStream_0.smethod_7(-13928);
		this.gclass201_0.imethod_2(binaryStream_0);
	}

	public Vector<GClass605> vector_0;

	public Vector<GClass605> vector_1;

	public GClass605 gclass605_0;

	public Vector<GClass605> vector_2;

	public GClass201 gclass201_0;
}
