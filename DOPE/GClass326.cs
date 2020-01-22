using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass326 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21401;
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
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.bool_0 = bool_2;
		this.bool_1 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 21401;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21401);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_7(1479);
	}

	public bool bool_0;

	public bool bool_1;
}
