using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass257 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 244;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass257(bool bool_0 = false, int int_1 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.Enabled = bool_0;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 244;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.Enabled = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(244);
		binaryStream_0.WriteBoolean(this.Enabled);
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
	}

	public bool Enabled;

	public int int_0;
}
