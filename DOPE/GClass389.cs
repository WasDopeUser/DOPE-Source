using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass389 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 37;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass389(int int_0 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.MapId = int_0;
	}

	public virtual int vmethod_0()
	{
		return 37;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 4 | U.smethod_0(this.MapId, 28));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(37);
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 4) | this.MapId << 28);
	}

	public int MapId;
}
