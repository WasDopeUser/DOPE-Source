using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass165 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20738;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass165(GClass262 gclass262_1 = null, bool bool_1 = false)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass262_1 == null)
		{
			this.gclass262_0 = new GClass262(0U);
		}
		else
		{
			this.gclass262_0 = gclass262_1;
		}
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 20738;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass262_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass262);
		this.gclass262_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20738);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass262_0.imethod_1(binaryStream_0);
	}

	public bool bool_0;

	public GClass262 gclass262_0;
}
