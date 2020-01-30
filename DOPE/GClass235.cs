using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass235 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22040;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass235(GClass178 gclass178_1 = null, GClass753 gclass753_1 = null, double double_2 = 0.0, double double_3 = 0.0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass178_1 == null)
		{
			this.gclass178_0 = new GClass178(0U);
		}
		else
		{
			this.gclass178_0 = gclass178_1;
		}
		if (gclass753_1 == null)
		{
			this.gclass753_0 = new GClass753(0U);
		}
		else
		{
			this.gclass753_0 = gclass753_1;
		}
		this.double_1 = double_2;
		this.double_0 = double_3;
	}

	public virtual int vmethod_0()
	{
		return 22040;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
		this.gclass753_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass753);
		this.gclass753_0.imethod_1(binaryStream_0);
		this.gclass178_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass178);
		this.gclass178_0.imethod_1(binaryStream_0);
		this.double_1 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22040);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-16713);
		binaryStream_0.WriteDouble(this.double_0);
		this.gclass753_0.imethod_2(binaryStream_0);
		this.gclass178_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.double_1);
	}

	public double double_0;

	public GClass753 gclass753_0;

	public GClass178 gclass178_0;

	public double double_1;
}
