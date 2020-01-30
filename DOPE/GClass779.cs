using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass779 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4039;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass779(string string_1 = "", Vector<GClass375> vector_0 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (vector_0 == null)
		{
			this.Items = new Vector<GClass375>();
			return;
		}
		this.Items = vector_0;
	}

	public virtual int vmethod_0()
	{
		return 4039;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.Items.Length > 0)
		{
			this.Items.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass375 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass375;
			gclass.imethod_1(binaryStream_0);
			this.Items.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4039);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.Items.Length);
		foreach (GClass375 gclass in this.Items)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_7(25196);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(-20446);
	}

	public Vector<GClass375> Items;

	public string string_0;
}
