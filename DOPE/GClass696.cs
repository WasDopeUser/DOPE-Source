using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass696 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21432;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass696(uint uint_1 = 0U, int int_2 = 0, int int_3 = 0, GClass191 gclass191_2 = null, GClass191 gclass191_3 = null, Vector<GClass489> vector_3 = null, Vector<GClass489> vector_4 = null, Vector<GClass361> vector_5 = null, GClass763 gclass763_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.uint_0 = uint_1;
		this.int_0 = int_2;
		this.int_1 = int_3;
		if (gclass191_2 == null)
		{
			this.gclass191_1 = new GClass191(0U);
		}
		else
		{
			this.gclass191_1 = gclass191_2;
		}
		if (gclass191_3 == null)
		{
			this.gclass191_0 = new GClass191(0U);
		}
		else
		{
			this.gclass191_0 = gclass191_3;
		}
		if (vector_3 == null)
		{
			this.vector_2 = new Vector<GClass489>();
		}
		else
		{
			this.vector_2 = vector_3;
		}
		if (vector_4 == null)
		{
			this.vector_1 = new Vector<GClass489>();
		}
		else
		{
			this.vector_1 = vector_4;
		}
		if (vector_5 == null)
		{
			this.vector_0 = new Vector<GClass361>();
		}
		else
		{
			this.vector_0 = vector_5;
		}
		if (gclass763_1 == null)
		{
			this.gclass763_0 = new GClass763("", null);
			return;
		}
		this.gclass763_0 = gclass763_1;
	}

	public virtual int vmethod_0()
	{
		return 21432;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass191_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass191);
		this.gclass191_0.imethod_1(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass361 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass361;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		this.gclass191_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass191);
		this.gclass191_1.imethod_1(binaryStream_0);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass489 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass489;
			gclass2.imethod_1(binaryStream_0);
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
			GClass489 gclass3 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass489;
			gclass3.imethod_1(binaryStream_0);
			this.vector_2.method_0(gclass3);
			num++;
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		this.gclass763_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass763);
		this.gclass763_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(21432);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass191_0.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass361 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.fUeiimuocMk(this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		this.gclass191_1.imethod_2(binaryStream_0);
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		binaryStream_0.fUeiimuocMk(this.vector_1.Length);
		foreach (GClass489 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.fUeiimuocMk(this.vector_2.Length);
		foreach (GClass489 gclass3 in this.vector_2)
		{
			gclass3.imethod_2(binaryStream_0);
		}
		binaryStream_0.fUeiimuocMk(this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		this.gclass763_0.imethod_2(binaryStream_0);
	}

	public GClass191 gclass191_0;

	public Vector<GClass361> vector_0;

	public int int_0;

	public GClass191 gclass191_1;

	public uint uint_0;

	public Vector<GClass489> vector_1;

	public Vector<GClass489> vector_2;

	public int int_1;

	public GClass763 gclass763_0;
}
