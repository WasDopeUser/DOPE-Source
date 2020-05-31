using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass237 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10477;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass237(Vector<GClass252> vector_2 = null, string string_1 = "", Vector<GClass423> vector_3 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		if (vector_2 == null)
		{
			this.vector_1 = new Vector<GClass252>();
		}
		else
		{
			this.vector_1 = vector_2;
		}
		this.string_0 = string_1;
		if (vector_3 == null)
		{
			this.vector_0 = new Vector<GClass423>();
			return;
		}
		this.vector_0 = vector_3;
	}

	public virtual int vmethod_0()
	{
		return 10477;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass423 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass423;
			gclass.HrqIugnatr8(binaryStream_0);
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
			GClass252 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass252;
			gclass2.HrqIugnatr8(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10477);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass423 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_7(-16035);
		binaryStream_0.smethod_4(this.vector_1.Length);
		foreach (GClass252 gclass2 in this.vector_1)
		{
			gclass2.imethod_1(binaryStream_0);
		}
	}

	public string string_0;

	public Vector<GClass423> vector_0;

	public Vector<GClass252> vector_1;
}
