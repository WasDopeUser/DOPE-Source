using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass443 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11357;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass443(int int_1 = 0, Vector<GClass649> vector_2 = null, Vector<GClass559> vector_3 = null, int int_2 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.fVuTkDavvL = int_1;
		if (vector_2 == null)
		{
			this.vector_0 = new Vector<GClass649>();
		}
		else
		{
			this.vector_0 = vector_2;
		}
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass559>();
		}
		else
		{
			this.vector_1 = vector_3;
		}
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 11357;
	}

	public virtual int vmethod_1()
	{
		return 16;
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
			GClass649 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass649;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.fVuTkDavvL = binaryStream_0.smethod_0();
		this.fVuTkDavvL = (U.smethod_0(this.fVuTkDavvL, 2) | this.fVuTkDavvL << 30);
		binaryStream_0.smethod_1();
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass559 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass559;
			gclass2.HrqIugnatr8(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 4) | this.int_0 << 28);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11357);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass649 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_4(this.fVuTkDavvL << 2 | U.smethod_0(this.fVuTkDavvL, 30));
		binaryStream_0.smethod_7(-28280);
		binaryStream_0.smethod_4(this.vector_1.Length);
		foreach (GClass559 gclass2 in this.vector_1)
		{
			gclass2.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_7(10526);
		binaryStream_0.smethod_4(this.int_0 << 4 | U.smethod_0(this.int_0, 28));
	}

	public Vector<GClass649> vector_0;

	public int fVuTkDavvL;

	public Vector<GClass559> vector_1;

	public int int_0;
}
