using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass589 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11875;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass589(GClass288 gclass288_1 = null, bool bool_1 = false)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass288_1 == null)
		{
			this.gclass288_0 = new GClass288(0U);
		}
		else
		{
			this.gclass288_0 = gclass288_1;
		}
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 11875;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass288_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass288);
		this.gclass288_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11875);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21278);
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass288_0.imethod_1(binaryStream_0);
	}

	public bool bool_0;

	public GClass288 gclass288_0;
}
