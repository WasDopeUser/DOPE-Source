using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass339 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16457;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass339(string string_1 = "", double double_1 = 0.0, GClass723 gclass723_0 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.double_0 = double_1;
		if (gclass723_0 == null)
		{
			this.Status = new GClass723();
			return;
		}
		this.Status = gclass723_0;
	}

	public virtual int vmethod_0()
	{
		return 16457;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.Status = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass723);
		this.Status.imethod_1(binaryStream_0);
		this.double_0 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16457);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(-16461);
		binaryStream_0.smethod_7(-5076);
		this.Status.imethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.double_0);
	}

	public string string_0;

	public GClass723 Status;

	public double double_0;
}
