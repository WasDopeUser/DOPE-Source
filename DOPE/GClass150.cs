using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass150 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17165;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass150(int int_0 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.FromId = int_0;
	}

	public virtual int vmethod_0()
	{
		return 17165;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.FromId = binaryStream_0.smethod_0();
		this.FromId = (this.FromId << 14 | U.smethod_0(this.FromId, 18));
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(17165);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.FromId, 14) | this.FromId << 18);
		binaryStream_0.smethod_7(-5022);
		binaryStream_0.smethod_7(22292);
	}

	public int FromId;
}
