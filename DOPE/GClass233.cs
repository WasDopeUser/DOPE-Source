using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass233 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8124;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass233(int int_1 = 0, int int_2 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.Unknown = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 8124;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Unknown = binaryStream_0.smethod_0();
		this.Unknown = (U.smethod_0(this.Unknown, 7) | this.Unknown << 25);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(8124);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.Unknown << 7 | U.smethod_0(this.Unknown, 25));
		binaryStream_0.smethod_3(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_6(28794);
	}

	public int Unknown;

	public int int_0;
}
