using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass428 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3506;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass428(int int_2 = 0, int int_3 = 0, int int_4 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.YgkiNcVwaj = int_2;
		this.int_1 = int_3;
		this.int_0 = int_4;
	}

	public virtual int vmethod_0()
	{
		return 3506;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.YgkiNcVwaj = binaryStream_0.smethod_0();
		this.YgkiNcVwaj = (this.YgkiNcVwaj << 5 | U.smethod_0(this.YgkiNcVwaj, 27));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 9 | U.smethod_0(this.int_1, 23));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3506);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.YgkiNcVwaj, 5) | this.YgkiNcVwaj << 27);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 9) | this.int_1 << 23);
	}

	public int YgkiNcVwaj;

	public int int_0;

	public int int_1;
}
