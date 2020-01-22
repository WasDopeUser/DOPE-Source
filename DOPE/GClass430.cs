using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass430 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1586;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass430(int int_2 = 0, int int_3 = 0, int int_4 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.MapId = int_2;
		this.int_0 = int_3;
		this.int_1 = int_4;
	}

	public virtual int vmethod_0()
	{
		return 1586;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 12) | this.MapId << 20);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1586);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.MapId << 12 | U.smethod_0(this.MapId, 20));
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_7(23296);
		binaryStream_0.smethod_4(this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		binaryStream_0.smethod_7(-16921);
	}

	public int MapId;

	public int int_0;

	public int int_1;
}
