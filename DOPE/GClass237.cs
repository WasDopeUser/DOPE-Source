using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass237 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25049;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass237(int int_1 = 0, int int_2 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.MapId = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 25049;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 6) | this.MapId << 26);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 2) | this.int_0 << 30);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(25049);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-13367);
		binaryStream_0.smethod_3(this.MapId << 6 | U.smethod_0(this.MapId, 26));
		binaryStream_0.smethod_3(this.int_0 << 2 | U.smethod_0(this.int_0, 30));
	}

	public int MapId;

	public int int_0;
}
