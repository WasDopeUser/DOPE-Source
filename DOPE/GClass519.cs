using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass519 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29262;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass519(GClass632 gclass632_1 = null, string string_1 = "", Vector<GClass332> vector_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		base..ctor();
		if (gclass632_1 == null)
		{
			this.gclass632_0 = new GClass632(false, null);
		}
		else
		{
			this.gclass632_0 = gclass632_1;
		}
		this.string_0 = string_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass332>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 29262;
	}

	public virtual int vmethod_1()
	{
		return 6;
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
			GClass332 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass332;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass632_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass632);
		this.gclass632_0.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29262);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass332 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		this.gclass632_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
	}

	public Vector<GClass332> vector_0;

	public GClass632 gclass632_0;

	public string string_0;
}
