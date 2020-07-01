using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass287 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 189;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass287(int int_1 = 0, bool bool_1 = false)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_1;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 189;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(189);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int int_0;

	public bool bool_0;
}
