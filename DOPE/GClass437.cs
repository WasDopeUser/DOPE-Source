using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass437 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2446;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass437(int int_1 = 0, int int_2 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_0 = int_1;
		this.MapId = int_2;
	}

	public virtual int vmethod_0()
	{
		return 2446;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 12 | U.smethod_0(this.MapId, 20));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2446);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 12) | this.MapId << 20);
	}

	public int int_0;

	public int MapId;
}
