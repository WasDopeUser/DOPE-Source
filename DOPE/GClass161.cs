using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass161 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17353;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass161(GClass244 gclass244_1 = null, bool bool_1 = false)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass244_1 == null)
		{
			this.gclass244_0 = new GClass244(0U);
		}
		else
		{
			this.gclass244_0 = gclass244_1;
		}
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 17353;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass244_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass244);
		this.gclass244_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(17353);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass244_0.imethod_2(binaryStream_0);
	}

	public bool bool_0;

	public GClass244 gclass244_0;
}
