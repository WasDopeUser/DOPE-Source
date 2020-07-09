using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass292 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -23181;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass292(int int_1 = 0, int int_2 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.Value = int_2;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return -23181;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Value = binaryStream_0.smethod_0();
		this.Value = (U.smethod_0(this.Value, 4) | this.Value << 28);
		this.int_0 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-23181);
		binaryStream_0.smethod_4(this.Value << 4 | U.smethod_0(this.Value, 28));
		binaryStream_0.smethod_7(this.int_0);
	}

	public int Value;

	public int int_0;
}
