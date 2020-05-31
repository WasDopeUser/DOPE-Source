using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass772 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18614;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass772(Vector<GClass772> vector_1 = null, string string_0 = "", GClass602 gclass602_0 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.Name = "";
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass772>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.Name = string_0;
		if (gclass602_0 == null)
		{
			this.Value = new GClass602("");
			return;
		}
		this.Value = gclass602_0;
	}

	public virtual int vmethod_0()
	{
		return 18614;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.Name = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.Value = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass602);
		this.Value.HrqIugnatr8(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass772 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass772;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18614);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_7(13881);
		this.Value.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass772 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_7(-140);
	}

	public string Name;

	public GClass602 Value;

	public Vector<GClass772> vector_0;
}
