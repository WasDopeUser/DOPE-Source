using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass487 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28336;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass487(int int_2 = 0, int int_3 = 0, GClass361 gclass361_0 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_1 = int_2;
		this.int_0 = int_3;
		if (gclass361_0 == null)
		{
			this.ToolTip = new GClass361(null);
			return;
		}
		this.ToolTip = gclass361_0;
	}

	public virtual int vmethod_0()
	{
		return 28336;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		this.ToolTip = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass361);
		this.ToolTip.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 13) | this.int_1 << 19);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(28336);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		this.ToolTip.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.int_1 << 13 | U.smethod_0(this.int_1, 19));
	}

	public int int_0;

	public GClass361 ToolTip;

	public int int_1;
}
