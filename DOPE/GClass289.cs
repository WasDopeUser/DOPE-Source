using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass289 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2845;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass289(uint uint_1 = 0U, int int_0 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.uint_0 = uint_1;
		this.Value = int_0;
	}

	public virtual int vmethod_0()
	{
		return 2845;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.Value = binaryStream_0.smethod_0();
		this.Value = (this.Value << 11 | U.smethod_0(this.Value, 21));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2845);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(13320);
		binaryStream_0.smethod_7(-4771);
		binaryStream_0.smethod_4(U.smethod_0(this.Value, 11) | this.Value << 21);
	}

	public uint uint_0;

	public int Value;
}
