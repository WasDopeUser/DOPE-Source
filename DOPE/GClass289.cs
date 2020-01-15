using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass289 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26719;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass289(uint uint_1 = 0U, GClass261 gclass261_1 = null, string string_1 = "")
	{
		Class13.nIxas2ezryi9b();
		this.string_0 = "";
		base..ctor();
		this.uint_0 = uint_1;
		if (gclass261_1 == null)
		{
			this.gclass261_0 = new GClass261(0U);
		}
		else
		{
			this.gclass261_0 = gclass261_1;
		}
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 26719;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.gclass261_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass261);
		this.gclass261_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(26719);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(11740);
		this.gclass261_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-16898);
	}

	public uint uint_0;

	public string string_0;

	public GClass261 gclass261_0;
}
