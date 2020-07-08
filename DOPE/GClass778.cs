using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass778 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 222;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass778(int int_1 = 0, int int_2 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_1;
		this.MapId = int_2;
	}

	public virtual int vmethod_0()
	{
		return 222;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 14 | U.smethod_0(this.MapId, 18));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(222);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 14) | this.MapId << 18);
	}

	public int int_0;

	public int MapId;
}
