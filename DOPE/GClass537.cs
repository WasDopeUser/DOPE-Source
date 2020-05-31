using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass537 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17204;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass537(Vector<GClass334> vector_1 = null, bool bool_1 = false)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass334>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 17204;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass334 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass334;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(17204);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass334 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
	}

	public bool bool_0;

	public Vector<GClass334> vector_0;
}
