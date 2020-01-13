using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass779 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 656;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass779(GClass347 gclass347_1 = null, int int_2 = 0, int int_3 = 0, bool bool_1 = false)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (gclass347_1 == null)
		{
			this.gclass347_0 = new GClass347(0U);
		}
		else
		{
			this.gclass347_0 = gclass347_1;
		}
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 656;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass347_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass347);
		this.gclass347_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 14 | U.smethod_0(this.int_1, 18));
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(656);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass347_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-11396);
		binaryStream_0.smethod_4(this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 14) | this.int_1 << 18);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public GClass347 gclass347_0;

	public int int_0;

	public int int_1;

	public bool bool_0;
}
