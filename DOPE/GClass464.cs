using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass464 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9792;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass464(int int_1 = 0, int int_2 = 0, bool bool_1 = false)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.MapId = int_1;
		this.int_0 = int_2;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 9792;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 6) | this.MapId << 26);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9792);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29184);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		binaryStream_0.smethod_4(this.MapId << 6 | U.smethod_0(this.MapId, 26));
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int int_0;

	public int MapId;

	public bool bool_0;
}
