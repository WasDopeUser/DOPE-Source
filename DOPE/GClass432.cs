using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass432 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28218;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass432(bool bool_1 = false)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 28218;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(28218);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(12861);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_6(25365);
	}

	public bool bool_0;
}
