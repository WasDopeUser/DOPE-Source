using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass345 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20042;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass345(GClass349 gclass349_1 = null, bool bool_1 = false)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass349_1 == null)
		{
			this.gclass349_0 = new GClass349(0U);
		}
		else
		{
			this.gclass349_0 = gclass349_1;
		}
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 20042;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.gclass349_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass349);
		this.gclass349_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(20042);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_6(-30862);
		this.gclass349_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(-20484);
	}

	public bool bool_0;

	public GClass349 gclass349_0;
}
