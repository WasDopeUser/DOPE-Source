using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass620 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5164;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass620(GClass761 gclass761_1 = null, GClass318 gclass318_1 = null, int int_1 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (gclass761_1 == null)
		{
			this.gclass761_0 = new GClass761(0U);
		}
		else
		{
			this.gclass761_0 = gclass761_1;
		}
		if (gclass318_1 == null)
		{
			this.gclass318_0 = new GClass318(0U);
		}
		else
		{
			this.gclass318_0 = gclass318_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 5164;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass761_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass761);
		this.gclass761_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.gclass318_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass318);
		this.gclass318_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5164);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass761_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		this.gclass318_0.imethod_2(binaryStream_0);
	}

	public GClass761 gclass761_0;

	public int int_0;

	public GClass318 gclass318_0;
}
