using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass259 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9206;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass259(bool bool_0 = false, int int_1 = 0)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.Enabled = bool_0;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 9206;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Enabled = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9206);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.Enabled);
		binaryStream_0.smethod_4(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
	}

	public bool Enabled;

	public int int_0;
}
