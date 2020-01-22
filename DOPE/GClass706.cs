using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass706 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28099;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass706(uint uint_1 = 0U, int int_2 = 0, int int_3 = 0, GClass201 gclass201_2 = null, GClass201 gclass201_3 = null, Vector<GClass501> vector_3 = null, Vector<GClass501> vector_4 = null, Vector<GClass377> vector_5 = null, GClass773 gclass773_1 = null)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.uint_0 = uint_1;
		this.int_0 = int_2;
		this.int_1 = int_3;
		if (gclass201_2 == null)
		{
			this.gclass201_1 = new GClass201(0U);
		}
		else
		{
			this.gclass201_1 = gclass201_2;
		}
		if (gclass201_3 == null)
		{
			this.gclass201_0 = new GClass201(0U);
		}
		else
		{
			this.gclass201_0 = gclass201_3;
		}
		if (vector_3 == null)
		{
			this.vector_0 = new Vector<GClass501>();
		}
		else
		{
			this.vector_0 = vector_3;
		}
		if (vector_4 == null)
		{
			this.vector_1 = new Vector<GClass501>();
		}
		else
		{
			this.vector_1 = vector_4;
		}
		if (vector_5 == null)
		{
			this.vector_2 = new Vector<GClass377>();
		}
		else
		{
			this.vector_2 = vector_5;
		}
		if (gclass773_1 == null)
		{
			this.gclass773_0 = new GClass773("", null);
			return;
		}
		this.gclass773_0 = gclass773_1;
	}

	public virtual int vmethod_0()
	{
		return 28099;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass501 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass501;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass201_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_1.imethod_1(binaryStream_0);
		this.gclass773_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass773);
		this.gclass773_0.imethod_1(binaryStream_0);
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass501 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass501;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		while (this.vector_2.Length > 0)
		{
			this.vector_2.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass377 gclass3 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass377;
			gclass3.imethod_1(binaryStream_0);
			this.vector_2.method_0(gclass3);
			num++;
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 11) | this.int_1 << 21);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28099);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass201_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass501 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		this.gclass201_1.imethod_2(binaryStream_0);
		this.gclass773_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.vector_1.Length);
		foreach (GClass501 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(12907);
		binaryStream_0.smethod_4(this.vector_2.Length);
		foreach (GClass377 gclass3 in this.vector_2)
		{
			gclass3.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_4(this.int_1 << 11 | U.smethod_0(this.int_1, 21));
	}

	public GClass201 gclass201_0;

	public Vector<GClass501> vector_0;

	public GClass201 gclass201_1;

	public GClass773 gclass773_0;

	public Vector<GClass501> vector_1;

	public int int_0;

	public uint uint_0;

	public Vector<GClass377> vector_2;

	public int int_1;
}
