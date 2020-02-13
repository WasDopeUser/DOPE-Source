using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass148 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26426;
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
		Class13.igxcIukzfpare();
		base..ctor();
		this.FromId = int_0;
	}

	public virtual int vmethod_0()
	{
		return 26426;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.FromId = binaryStream_0.smethod_0();
		this.FromId = (U.smethod_0(this.FromId, 12) | this.FromId << 20);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(26426);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-14192);
		binaryStream_0.smethod_6(-1596);
		binaryStream_0.smethod_3(this.FromId << 12 | U.smethod_0(this.FromId, 20));
	}

	public int FromId;
}
