using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass276 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6736;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass276(uint uint_1 = 0U, GClass247 gclass247_1 = null, string string_1 = "")
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		this.uint_0 = uint_1;
		if (gclass247_1 == null)
		{
			this.gclass247_0 = new GClass247(0U);
		}
		else
		{
			this.gclass247_0 = gclass247_1;
		}
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 6736;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass247_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass247);
		this.gclass247_0.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(6736);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass247_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
	}

	public GClass247 gclass247_0;

	public string string_0;

	public uint uint_0;
}
