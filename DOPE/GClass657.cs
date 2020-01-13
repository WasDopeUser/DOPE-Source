using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass657 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13802;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass657(GClass761 gclass761_1 = null, uint uint_0 = 0U)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (gclass761_1 == null)
		{
			this.gclass761_0 = new GClass761(0U);
		}
		else
		{
			this.gclass761_0 = gclass761_1;
		}
		this.TrtIsyIhcr = uint_0;
	}

	public virtual int vmethod_0()
	{
		return 13802;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.TrtIsyIhcr = (uint)binaryStream_0.smethod_1();
		this.gclass761_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass761);
		this.gclass761_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13802);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.TrtIsyIhcr);
		this.gclass761_0.imethod_2(binaryStream_0);
	}

	public uint TrtIsyIhcr;

	public GClass761 gclass761_0;
}
