using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass567 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32004;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass567(bool bool_1 = false, GClass373 gclass373_2 = null, GClass373 gclass373_3 = null, GClass524 gclass524_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.bool_0 = bool_1;
		if (gclass373_2 == null)
		{
			this.gclass373_1 = new GClass373("", 0, 0, 0, 0, 0, 0, 0.0);
		}
		else
		{
			this.gclass373_1 = gclass373_2;
		}
		if (gclass373_3 == null)
		{
			this.gclass373_0 = new GClass373("", 0, 0, 0, 0, 0, 0, 0.0);
		}
		else
		{
			this.gclass373_0 = gclass373_3;
		}
		if (gclass524_1 == null)
		{
			this.gclass524_0 = new GClass524("");
			return;
		}
		this.gclass524_0 = gclass524_1;
	}

	public virtual int vmethod_0()
	{
		return 32004;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass373_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass373);
		this.gclass373_0.HrqIugnatr8(binaryStream_0);
		this.gclass373_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass373);
		this.gclass373_1.HrqIugnatr8(binaryStream_0);
		this.gclass524_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass524);
		this.gclass524_0.HrqIugnatr8(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32004);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass373_0.imethod_1(binaryStream_0);
		this.gclass373_1.imethod_1(binaryStream_0);
		this.gclass524_0.imethod_1(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public GClass373 gclass373_0;

	public GClass373 gclass373_1;

	public GClass524 gclass524_0;

	public bool bool_0;
}
