using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass472 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13095;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass472(int int_2 = 0, int int_3 = 0, GClass343 gclass343_0 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_1 = int_2;
		this.int_0 = int_3;
		if (gclass343_0 == null)
		{
			this.ToolTip = new GClass343(null);
			return;
		}
		this.ToolTip = gclass343_0;
	}

	public virtual int vmethod_0()
	{
		return 13095;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.ToolTip = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass343);
		this.ToolTip.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 7) | this.int_1 << 25);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(13095);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(7737);
		this.ToolTip.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.fUeiimuocMk(this.int_1 << 7 | U.smethod_0(this.int_1, 25));
	}

	public GClass343 ToolTip;

	public int int_0;

	public int int_1;
}
