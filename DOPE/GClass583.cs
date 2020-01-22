using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass583 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18719;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass583(int int_0 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.Id = int_0;
	}

	public virtual int vmethod_0()
	{
		return 18719;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 12 | U.smethod_0(this.Id, 20));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18719);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 12) | this.Id << 20);
		binaryStream_0.smethod_7(-28694);
	}

	public int Id;
}
