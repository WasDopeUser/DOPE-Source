using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass435 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11529;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass435(GClass469 gclass469_0 = null, Vector<GClass622> vector_1 = null, GClass622 gclass622_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass469_0 == null)
		{
			this.vmDqpkiZlr = new GClass469(0, null, null, null, null, "", "");
		}
		else
		{
			this.vmDqpkiZlr = gclass469_0;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass622>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass622_1 == null)
		{
			this.gclass622_0 = new GClass622("", "", 0, 0, 0);
			return;
		}
		this.gclass622_0 = gclass622_1;
	}

	public virtual int vmethod_0()
	{
		return 11529;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass622_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass622);
		this.gclass622_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass622 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass622;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.vmDqpkiZlr = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass469);
		this.vmDqpkiZlr.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(11529);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(8371);
		this.gclass622_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(25509);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass622 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		this.vmDqpkiZlr.imethod_2(binaryStream_0);
	}

	public GClass622 gclass622_0;

	public Vector<GClass622> vector_0;

	public GClass469 vmDqpkiZlr;
}
