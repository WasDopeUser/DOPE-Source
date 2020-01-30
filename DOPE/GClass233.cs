using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass233 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 373;
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
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.Unknown = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 373;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Unknown = binaryStream_0.smethod_0();
		this.Unknown = (this.Unknown << 10 | U.smethod_0(this.Unknown, 22));
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 4) | this.int_0 << 28);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(373);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.Unknown, 10) | this.Unknown << 22);
		binaryStream_0.smethod_7(757);
		binaryStream_0.smethod_4(this.int_0 << 4 | U.smethod_0(this.int_0, 28));
	}

	public int Unknown;

	public int int_0;
}
