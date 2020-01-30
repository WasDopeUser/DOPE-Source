using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass326 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5565;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass326(bool bool_2 = false, bool bool_3 = false)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.bool_0 = bool_2;
		this.bool_1 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 5565;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5565);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
	}

	public bool bool_0;

	public bool bool_1;
}
