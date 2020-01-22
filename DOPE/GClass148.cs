using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass148 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27354;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass148(int int_0 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.FromId = int_0;
	}

	public virtual int vmethod_0()
	{
		return 27354;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.FromId = binaryStream_0.smethod_0();
		this.FromId = (this.FromId << 7 | U.smethod_0(this.FromId, 25));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27354);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27598);
		binaryStream_0.smethod_4(U.smethod_0(this.FromId, 7) | this.FromId << 25);
	}

	public int FromId;
}
