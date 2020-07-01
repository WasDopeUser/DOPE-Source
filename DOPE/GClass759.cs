using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass759 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 114;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass759(int int_1 = 0, int int_2 = 0, double double_1 = 0.0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_1;
		this.axVvCbnxeD = int_2;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 114;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		this.axVvCbnxeD = binaryStream_0.smethod_0();
		this.axVvCbnxeD = (this.axVvCbnxeD << 2 | U.smethod_0(this.axVvCbnxeD, 30));
		this.double_0 = (double)binaryStream_0.smethod_10();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(114);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.smethod_4(U.smethod_0(this.axVvCbnxeD, 2) | this.axVvCbnxeD << 30);
		binaryStream_0.smethod_9(this.double_0);
	}

	public int int_0;

	public int axVvCbnxeD;

	public double double_0;
}
