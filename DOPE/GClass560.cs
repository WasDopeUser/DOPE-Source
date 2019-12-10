using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass560 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3374;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass560(GClass270 gclass270_1 = null, bool bool_1 = false)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass270_1 == null)
		{
			this.gclass270_0 = new GClass270(0U);
		}
		else
		{
			this.gclass270_0 = gclass270_1;
		}
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 3374;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass270_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass270);
		this.gclass270_0.imethod_1(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(3374);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass270_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public GClass270 gclass270_0;

	public bool bool_0;
}
