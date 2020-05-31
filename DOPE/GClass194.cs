using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass194 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18778;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass194(int int_2 = 0, int int_3 = 0, int int_4 = 0, Vector<GClass195> vector_1 = null, GClass197 gclass197_0 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.Id = int_2;
		this.int_1 = int_3;
		this.int_0 = int_4;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass195>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass197_0 == null)
		{
			this.Mode = new GClass197(0U);
			return;
		}
		this.Mode = gclass197_0;
	}

	public virtual int vmethod_0()
	{
		return 18778;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		this.Mode = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass197);
		this.Mode.HrqIugnatr8(binaryStream_0);
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 8 | U.smethod_0(this.Id, 24));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass195 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass195;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18778);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		this.Mode.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 8) | this.Id << 24);
		binaryStream_0.smethod_4(this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass195 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
	}

	public int int_0;

	public GClass197 Mode;

	public int Id;

	public int int_1;

	public Vector<GClass195> vector_0;
}
