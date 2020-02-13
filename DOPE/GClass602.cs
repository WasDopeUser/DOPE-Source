using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass602 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27724;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass602(GClass459 gclass459_1 = null, GClass353 gclass353_1 = null, Vector<GClass755> vector_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass459_1 == null)
		{
			this.gclass459_0 = new GClass459(false, 0);
		}
		else
		{
			this.gclass459_0 = gclass459_1;
		}
		if (gclass353_1 == null)
		{
			this.gclass353_0 = new GClass353(0, 0);
		}
		else
		{
			this.gclass353_0 = gclass353_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass755>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 27724;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass353_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass353);
		this.gclass353_0.imethod_1(binaryStream_0);
		this.gclass459_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass459);
		this.gclass459_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass755 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass755;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(27724);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass353_0.imethod_2(binaryStream_0);
		this.gclass459_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(-16106);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass755 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public GClass353 gclass353_0;

	public GClass459 gclass459_0;

	public Vector<GClass755> vector_0;
}
