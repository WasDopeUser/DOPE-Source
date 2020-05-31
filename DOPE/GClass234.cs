using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass234 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21695;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass234(int int_1 = 0, int int_2 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.Unknown = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 21695;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.Unknown = binaryStream_0.smethod_0();
		this.Unknown = (U.smethod_0(this.Unknown, 4) | this.Unknown << 28);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21695);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.Unknown << 4 | U.smethod_0(this.Unknown, 28));
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
	}

	public int Unknown;

	public int int_0;
}
