using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass842 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 64;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass842(int int_1 = 0, int int_2 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.MapId = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 64;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 11) | this.MapId << 21);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(64);
		binaryStream_0.smethod_4(this.MapId << 11 | U.smethod_0(this.MapId, 21));
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
	}

	public int MapId;

	public int int_0;
}
