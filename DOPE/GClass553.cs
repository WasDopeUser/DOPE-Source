using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass553 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15820;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass553(Vector<GClass289> vector_1 = null, GClass289 gclass289_3 = null, GClass289 gclass289_4 = null, GClass289 gclass289_5 = null, GClass497 gclass497_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass289>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass289_3 == null)
		{
			this.gclass289_0 = new GClass289(0U, 0);
		}
		else
		{
			this.gclass289_0 = gclass289_3;
		}
		if (gclass289_4 == null)
		{
			this.gclass289_2 = new GClass289(0U, 0);
		}
		else
		{
			this.gclass289_2 = gclass289_4;
		}
		if (gclass289_5 == null)
		{
			this.gclass289_1 = new GClass289(0U, 0);
		}
		else
		{
			this.gclass289_1 = gclass289_5;
		}
		if (gclass497_1 == null)
		{
			this.gclass497_0 = new GClass497(0);
			return;
		}
		this.gclass497_0 = gclass497_1;
	}

	public virtual int vmethod_0()
	{
		return 15820;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass289_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass289);
		this.gclass289_0.HrqIugnatr8(binaryStream_0);
		this.gclass289_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass289);
		this.gclass289_1.HrqIugnatr8(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass289 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass289;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass497_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass497);
		this.gclass497_0.HrqIugnatr8(binaryStream_0);
		this.gclass289_2 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass289);
		this.gclass289_2.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(15820);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass289_0.imethod_1(binaryStream_0);
		this.gclass289_1.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass289 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		this.gclass497_0.imethod_1(binaryStream_0);
		this.gclass289_2.imethod_1(binaryStream_0);
	}

	public GClass289 gclass289_0;

	public GClass289 gclass289_1;

	public Vector<GClass289> vector_0;

	public GClass497 gclass497_0;

	public GClass289 gclass289_2;
}
