using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass258 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18091;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass258(uint uint_0 = 0U)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.Mode = uint_0;
	}

	public virtual int vmethod_0()
	{
		return 18091;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Mode = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18091);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.Mode);
		binaryStream_0.smethod_7(4619);
	}

	public uint Mode;
}
