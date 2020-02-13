using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass293 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4422;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass293(Vector<GClass607> vector_3 = null, Vector<GClass607> vector_4 = null, Vector<GClass607> vector_5 = null, GClass607 gclass607_1 = null, GClass201 gclass201_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass607>();
		}
		else
		{
			this.vector_1 = vector_3;
		}
		if (vector_4 == null)
		{
			this.vector_0 = new Vector<GClass607>();
		}
		else
		{
			this.vector_0 = vector_4;
		}
		if (vector_5 == null)
		{
			this.vector_2 = new Vector<GClass607>();
		}
		else
		{
			this.vector_2 = vector_5;
		}
		if (gclass607_1 == null)
		{
			this.gclass607_0 = new GClass607(0, 0, "", "", "", 0);
		}
		else
		{
			this.gclass607_0 = gclass607_1;
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
		return 4422;
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
			GClass607 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass607;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass607 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass607;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		this.gclass607_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass607);
		this.gclass607_0.imethod_1(binaryStream_0);
		while (this.vector_2.Length > 0)
		{
			this.vector_2.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass607 gclass3 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass607;
			gclass3.imethod_1(binaryStream_0);
			this.vector_2.method_0(gclass3);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(4422);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass607 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		this.gclass201_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(-26546);
		binaryStream_0.smethod_3(this.vector_1.Length);
		foreach (GClass607 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		this.gclass607_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.vector_2.Length);
		foreach (GClass607 gclass3 in this.vector_2)
		{
			gclass3.imethod_2(binaryStream_0);
		}
	}

	public Vector<GClass607> vector_0;

	public GClass201 gclass201_0;

	public Vector<GClass607> vector_1;

	public GClass607 gclass607_0;

	public Vector<GClass607> vector_2;
}
