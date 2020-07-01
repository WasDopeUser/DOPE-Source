using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass648 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2024;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass648(int int_0 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.NkWtqcqliD = int_0;
	}

	public virtual int vmethod_0()
	{
		return 2024;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.NkWtqcqliD = binaryStream_0.smethod_0();
		this.NkWtqcqliD = (this.NkWtqcqliD << 2 | U.smethod_0(this.NkWtqcqliD, 30));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2024);
		binaryStream_0.smethod_4(U.smethod_0(this.NkWtqcqliD, 2) | this.NkWtqcqliD << 30);
	}

	public int NkWtqcqliD;
}
