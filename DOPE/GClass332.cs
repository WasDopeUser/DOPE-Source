using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass332 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11928;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass332(GClass460 gclass460_1 = null, GClass483 gclass483_1 = null)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (gclass460_1 == null)
		{
			this.gclass460_0 = new GClass460(0U);
		}
		else
		{
			this.gclass460_0 = gclass460_1;
		}
		if (gclass483_1 == null)
		{
			this.gclass483_0 = new GClass483(0, null, null, null, null, "", "");
			return;
		}
		this.gclass483_0 = gclass483_1;
	}

	public virtual int vmethod_0()
	{
		return 11928;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass483_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass483);
		this.gclass483_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass460_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass460);
		this.gclass460_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11928);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass483_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(18885);
		this.gclass460_0.imethod_2(binaryStream_0);
	}

	public GClass483 gclass483_0;

	public GClass460 gclass460_0;
}
