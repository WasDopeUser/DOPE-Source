using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass781 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30781;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass781(GClass387 gclass387_1 = null, int int_1 = 0)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (gclass387_1 == null)
		{
			this.gclass387_0 = new GClass387();
		}
		else
		{
			this.gclass387_0 = gclass387_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 30781;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		this.gclass387_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass387);
		this.gclass387_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30781);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		this.gclass387_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-3563);
	}

	public int int_0;

	public GClass387 gclass387_0;
}
