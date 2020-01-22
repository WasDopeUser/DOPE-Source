using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass361 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23743;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass361(int int_1 = 0, int int_2 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.MapId = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 23743;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 14) | this.MapId << 18);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23743);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.MapId << 14 | U.smethod_0(this.MapId, 18));
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
	}

	public int MapId;

	public int int_0;
}
