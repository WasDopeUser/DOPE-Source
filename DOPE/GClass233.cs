using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass233 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12167;
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
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.Unknown = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 12167;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.Unknown = binaryStream_0.smethod_0();
		this.Unknown = (U.smethod_0(this.Unknown, 11) | this.Unknown << 21);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(12167);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_4(this.Unknown << 11 | U.smethod_0(this.Unknown, 21));
	}

	public int int_0;

	public int Unknown;
}
