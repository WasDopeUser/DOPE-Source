using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass435 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1077;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass435(int int_2 = 0, int int_3 = 0, int int_4 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.MapId = int_2;
		this.int_0 = int_4;
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 1077;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 9) | this.MapId << 23);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 6) | this.int_1 << 26);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1077);
		binaryStream_0.smethod_4(this.MapId << 9 | U.smethod_0(this.MapId, 23));
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		binaryStream_0.smethod_4(this.int_1 << 6 | U.smethod_0(this.int_1, 26));
	}

	public int MapId;

	public int int_0;

	public int int_1;
}
