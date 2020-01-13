using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass148 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27003;
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
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.FromId = int_0;
	}

	public virtual int vmethod_0()
	{
		return 27003;
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
		this.FromId = (U.smethod_0(this.FromId, 3) | this.FromId << 29);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27003);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3959);
		binaryStream_0.smethod_7(22891);
		binaryStream_0.smethod_4(this.FromId << 3 | U.smethod_0(this.FromId, 29));
	}

	public int FromId;
}
