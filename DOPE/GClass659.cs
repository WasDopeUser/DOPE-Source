using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass659 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28704;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass659(uint uint_1 = 0U, int int_0 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.uint_0 = uint_1;
		this.MapId = int_0;
	}

	public virtual int vmethod_0()
	{
		return 28704;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 7 | U.smethod_0(this.MapId, 25));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28704);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23193);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(26516);
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 7) | this.MapId << 25);
	}

	public uint uint_0;

	public int MapId;
}
