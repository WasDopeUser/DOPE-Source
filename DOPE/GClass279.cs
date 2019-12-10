using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass279 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11791;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass279(Vector<GClass593> vector_3 = null, Vector<GClass593> vector_4 = null, Vector<GClass593> vector_5 = null, GClass593 gclass593_1 = null, GClass191 gclass191_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass593>();
		}
		else
		{
			this.vector_1 = vector_3;
		}
		if (vector_4 == null)
		{
			this.vector_0 = new Vector<GClass593>();
		}
		else
		{
			this.vector_0 = vector_4;
		}
		if (vector_5 == null)
		{
			this.vector_2 = new Vector<GClass593>();
		}
		else
		{
			this.vector_2 = vector_5;
		}
		if (gclass593_1 == null)
		{
			this.gclass593_0 = new GClass593(0, 0, "", "", "", 0);
		}
		else
		{
			this.gclass593_0 = gclass593_1;
		}
		if (gclass191_1 == null)
		{
			this.gclass191_0 = new GClass191(0U);
			return;
		}
		this.gclass191_0 = gclass191_1;
	}

	public virtual int vmethod_0()
	{
		return 11791;
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
			GClass593 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass593;
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
			GClass593 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass593;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass191_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass191);
		this.gclass191_0.imethod_1(binaryStream_0);
		while (this.vector_2.Length > 0)
		{
			this.vector_2.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass593 gclass3 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass593;
			gclass3.imethod_1(binaryStream_0);
			this.vector_2.method_0(gclass3);
			num++;
		}
		this.gclass593_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass593);
		this.gclass593_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(11791);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass593 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.fUeiimuocMk(this.vector_1.Length);
		foreach (GClass593 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_5(22000);
		binaryStream_0.smethod_5(-30625);
		this.gclass191_0.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(this.vector_2.Length);
		foreach (GClass593 gclass3 in this.vector_2)
		{
			gclass3.imethod_2(binaryStream_0);
		}
		this.gclass593_0.imethod_2(binaryStream_0);
	}

	public Vector<GClass593> vector_0;

	public Vector<GClass593> vector_1;

	public GClass191 gclass191_0;

	public Vector<GClass593> vector_2;

	public GClass593 gclass593_0;
}
