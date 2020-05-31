using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass252 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32739;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass252(string string_1 = "", Vector<GClass253> vector_0 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (vector_0 == null)
		{
			this.Items = new Vector<GClass253>();
			return;
		}
		this.Items = vector_0;
	}

	public virtual int vmethod_0()
	{
		return 32739;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		while (this.Items.Length > 0)
		{
			this.Items.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass253 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass253;
			gclass.HrqIugnatr8(binaryStream_0);
			this.Items.method_0(gclass);
			num++;
		}
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32739);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.Items.Length);
		foreach (GClass253 gclass in this.Items)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.string_0);
	}

	public Vector<GClass253> Items;

	public string string_0;
}
