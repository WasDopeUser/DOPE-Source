using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass664 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 251;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass664(bool bool_0 = false, int int_1 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.ycItEaUnoU = bool_0;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 251;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.ycItEaUnoU = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 12) | this.int_0 << 20);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(251);
		binaryStream_0.WriteBoolean(this.ycItEaUnoU);
		binaryStream_0.smethod_4(this.int_0 << 12 | U.smethod_0(this.int_0, 20));
	}

	public bool ycItEaUnoU;

	public int int_0;
}
