using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass707 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19513;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass707(GClass761 gclass761_1 = null, int int_0 = 0)
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
		this.jAaWcAiZqt = int_0;
	}

	public virtual int vmethod_0()
	{
		return 19513;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.jAaWcAiZqt = binaryStream_0.smethod_0();
		this.jAaWcAiZqt = (U.smethod_0(this.jAaWcAiZqt, 14) | this.jAaWcAiZqt << 18);
		this.gclass761_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass761);
		this.gclass761_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19513);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.jAaWcAiZqt << 14 | U.smethod_0(this.jAaWcAiZqt, 18));
		this.gclass761_0.imethod_2(binaryStream_0);
	}

	public int jAaWcAiZqt;

	public GClass761 gclass761_0;
}
