using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass361 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17882;
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
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.MapId = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 17882;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 8 | U.smethod_0(this.MapId, 24));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(17882);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16427);
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 8) | this.MapId << 24);
		binaryStream_0.smethod_4(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.smethod_7(12426);
	}

	public int MapId;

	public int int_0;
}
