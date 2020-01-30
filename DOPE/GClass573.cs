using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass573 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23632;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass573(GClass284 gclass284_1 = null, bool bool_1 = false)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass284_1 == null)
		{
			this.gclass284_0 = new GClass284(0U);
		}
		else
		{
			this.gclass284_0 = gclass284_1;
		}
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 23632;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass284_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass284);
		this.gclass284_0.imethod_1(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23632);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3644);
		this.gclass284_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public GClass284 gclass284_0;

	public bool bool_0;
}
