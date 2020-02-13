using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass341 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20530;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass341(string string_1 = "", double double_1 = 0.0, GClass724 gclass724_0 = null)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.double_0 = double_1;
		if (gclass724_0 == null)
		{
			this.Status = new GClass724();
			return;
		}
		this.Status = gclass724_0;
	}

	public virtual int vmethod_0()
	{
		return 20530;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.double_0 = binaryStream_0.ReadDouble();
		this.Status = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass724);
		this.Status.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(20530);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(5001);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.WriteDouble(this.double_0);
		this.Status.imethod_2(binaryStream_0);
	}

	public string string_0;

	public double double_0;

	public GClass724 Status;
}
