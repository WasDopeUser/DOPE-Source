using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass125 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16330;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass125(Vector<GClass741> vector_3 = null, Vector<GClass662> vector_4 = null, Vector<GClass662> vector_5 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (vector_3 == null)
		{
			this.vector_0 = new Vector<GClass741>();
		}
		else
		{
			this.vector_0 = vector_3;
		}
		if (vector_4 == null)
		{
			this.vector_1 = new Vector<GClass662>();
		}
		else
		{
			this.vector_1 = vector_4;
		}
		if (vector_5 == null)
		{
			this.vector_2 = new Vector<GClass662>();
			return;
		}
		this.vector_2 = vector_5;
	}

	public virtual int vmethod_0()
	{
		return 16330;
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
			GClass741 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass741;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass662 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass662;
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
			GClass662 gclass3 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass662;
			gclass3.imethod_1(binaryStream_0);
			this.vector_2.method_0(gclass3);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(16330);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass741 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_6(14751);
		binaryStream_0.smethod_3(this.vector_1.Length);
		foreach (GClass662 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.vector_2.Length);
		foreach (GClass662 gclass3 in this.vector_2)
		{
			gclass3.imethod_2(binaryStream_0);
		}
	}

	public Vector<GClass741> vector_0;

	public Vector<GClass662> vector_1;

	public Vector<GClass662> vector_2;
}
