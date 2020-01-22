using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass324 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16915;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass324(GClass761 gclass761_1 = null, int int_1 = 0)
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
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 16915;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		binaryStream_0.smethod_1();
		this.gclass761_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass761);
		this.gclass761_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16915);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27989);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.smethod_7(9540);
		this.gclass761_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public GClass761 gclass761_0;
}
