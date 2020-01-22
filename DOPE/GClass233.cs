using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass233 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8340;
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
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.Unknown = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 8340;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		binaryStream_0.smethod_1();
		this.Unknown = binaryStream_0.smethod_0();
		this.Unknown = (this.Unknown << 4 | U.smethod_0(this.Unknown, 28));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8340);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		binaryStream_0.smethod_7(25526);
		binaryStream_0.smethod_4(U.smethod_0(this.Unknown, 4) | this.Unknown << 28);
		binaryStream_0.smethod_7(-20264);
	}

	public int int_0;

	public int Unknown;
}
