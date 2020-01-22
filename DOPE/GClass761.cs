using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass761 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25398;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass761(uint uint_0 = 0U)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.hGfvEkoOv9 = uint_0;
	}

	public virtual int vmethod_0()
	{
		return 25398;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.hGfvEkoOv9 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25398);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.hGfvEkoOv9);
		binaryStream_0.smethod_7(-28346);
	}

	public uint hGfvEkoOv9;
}
