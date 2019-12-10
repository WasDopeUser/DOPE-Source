using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass709 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10917;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass709(Vector<GClass700> vector_2 = null, Vector<GClass620> vector_3 = null, Vector<GClass532> vector_4 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (vector_2 == null)
		{
			this.vector_0 = new Vector<GClass700>();
		}
		else
		{
			this.vector_0 = vector_2;
		}
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass620>();
		}
		else
		{
			this.vector_1 = vector_3;
		}
		if (vector_4 == null)
		{
			this.kBaKfphccb = new Vector<GClass532>();
			return;
		}
		this.kBaKfphccb = vector_4;
	}

	public virtual int vmethod_0()
	{
		return 10917;
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
			GClass700 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass700;
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
			GClass620 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass620;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		while (this.kBaKfphccb.Length > 0)
		{
			this.kBaKfphccb.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass532 gclass3 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass532;
			gclass3.imethod_1(binaryStream_0);
			this.kBaKfphccb.method_0(gclass3);
			num++;
		}
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(10917);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass700 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.fUeiimuocMk(this.vector_1.Length);
		foreach (GClass620 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.fUeiimuocMk(this.kBaKfphccb.Length);
		foreach (GClass532 gclass3 in this.kBaKfphccb)
		{
			gclass3.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_5(15983);
	}

	public Vector<GClass700> vector_0;

	public Vector<GClass620> vector_1;

	public Vector<GClass532> kBaKfphccb;
}
