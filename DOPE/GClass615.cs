using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass615 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15548;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass615(string string_1 = "", double double_1 = 0.0, GClass638 gclass638_1 = null, GClass738 gclass738_0 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.double_0 = double_1;
		if (gclass638_1 == null)
		{
			this.gclass638_0 = new GClass638();
		}
		else
		{
			this.gclass638_0 = gclass638_1;
		}
		if (gclass738_0 == null)
		{
			this.Status = new GClass738();
			return;
		}
		this.Status = gclass738_0;
	}

	public virtual int vmethod_0()
	{
		return 15548;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.Status = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass738);
		this.Status.HrqIugnatr8(binaryStream_0);
		this.gclass638_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass638);
		this.gclass638_0.HrqIugnatr8(binaryStream_0);
		this.double_0 = binaryStream_0.ReadDouble();
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(15548);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.Status.imethod_1(binaryStream_0);
		this.gclass638_0.imethod_1(binaryStream_0);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(-11928);
	}

	public GClass738 Status;

	public GClass638 gclass638_0;

	public double double_0;

	public string string_0;
}
