using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass709 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29692;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass709(Vector<GClass366> vector_0 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (vector_0 == null)
		{
			this.eoAwjbtdHw = new Vector<GClass366>();
			return;
		}
		this.eoAwjbtdHw = vector_0;
	}

	public virtual int vmethod_0()
	{
		return 29692;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.eoAwjbtdHw.Length > 0)
		{
			this.eoAwjbtdHw.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass366 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass366;
			gclass.imethod_1(binaryStream_0);
			this.eoAwjbtdHw.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29692);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.eoAwjbtdHw.Length);
		foreach (GClass366 gclass in this.eoAwjbtdHw)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_7(25892);
	}

	public Vector<GClass366> eoAwjbtdHw;
}
