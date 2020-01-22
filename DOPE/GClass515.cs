using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass515 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22977;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass515(int int_1 = 0, GClass650 gclass650_0 = null)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_0 = int_1;
		if (gclass650_0 == null)
		{
			this.State = new GClass650(0.0, false, false);
			return;
		}
		this.State = gclass650_0;
	}

	public virtual int vmethod_0()
	{
		return 22977;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		this.State = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass650);
		this.State.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22977);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.State.imethod_2(binaryStream_0);
	}

	public int int_0;

	public GClass650 State;
}
