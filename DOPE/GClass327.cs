using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass327 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6003;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass327(Vector<GClass344> vector_1 = null, GClass344 gclass344_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass344>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass344_1 == null)
		{
			this.gclass344_0 = new GClass344(0, "", "", 0);
			return;
		}
		this.gclass344_0 = gclass344_1;
	}

	public virtual int vmethod_0()
	{
		return 6003;
	}

	public virtual int vmethod_1()
	{
		return 4;
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
			GClass344 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass344;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass344_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass344);
		this.gclass344_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(6003);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass344 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		this.gclass344_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(9988);
	}

	public Vector<GClass344> vector_0;

	public GClass344 gclass344_0;
}
