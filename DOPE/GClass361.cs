using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass361 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25734;
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
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.MapId = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 25734;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 12 | U.smethod_0(this.MapId, 20));
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25734);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 12) | this.MapId << 20);
		binaryStream_0.smethod_7(6507);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.smethod_7(12190);
	}

	public int MapId;

	public int int_0;
}
