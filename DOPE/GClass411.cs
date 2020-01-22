using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass411 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9204;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass411(Vector<GClass375> vector_1 = null, GClass521 gclass521_1 = null)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass375>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass521_1 == null)
		{
			this.gclass521_0 = new GClass521(0U, 0, 0);
			return;
		}
		this.gclass521_0 = gclass521_1;
	}

	public virtual int vmethod_0()
	{
		return 9204;
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
			GClass375 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass375;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass521_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass521);
		this.gclass521_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9204);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass375 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		this.gclass521_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(18660);
	}

	public Vector<GClass375> vector_0;

	public GClass521 gclass521_0;
}
