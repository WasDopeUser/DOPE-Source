using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass259 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19471;
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
		Class13.igxcIukzfpare();
		base..ctor();
		this.Enabled = bool_0;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 19471;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Enabled = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(19471);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.Enabled);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
	}

	public bool Enabled;

	public int int_0;
}
