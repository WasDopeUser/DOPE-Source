using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass333 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5168;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass333(int int_1 = 0, int int_2 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.Id = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 5168;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 4) | this.Id << 28);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(5168);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.Id << 4 | U.smethod_0(this.Id, 28));
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		binaryStream_0.smethod_6(-23975);
	}

	public int Id;

	public int int_0;
}
