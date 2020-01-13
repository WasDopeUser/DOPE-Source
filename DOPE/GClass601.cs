using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass601 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27518;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass601(GClass261 gclass261_1 = null, int int_1 = 0)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (gclass261_1 == null)
		{
			this.gclass261_0 = new GClass261(0U);
		}
		else
		{
			this.gclass261_0 = gclass261_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 27518;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass261_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass261);
		this.gclass261_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 4) | this.int_0 << 28);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27518);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass261_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 4 | U.smethod_0(this.int_0, 28));
	}

	public GClass261 gclass261_0;

	public int int_0;
}
