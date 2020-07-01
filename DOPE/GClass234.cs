using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass234 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass234(int int_1 = 0, int int_2 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.MapId = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 19;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 7 | U.smethod_0(this.MapId, 25));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19);
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 7) | this.MapId << 25);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
	}

	public int MapId;

	public int int_0;
}
