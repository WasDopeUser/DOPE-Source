using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass230 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14833;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass230(int int_1 = 0, int int_2 = 0)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.int_0 = int_1;
		this.eiaBfDdiqn = int_2;
	}

	public virtual int vmethod_0()
	{
		return 14833;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		this.eiaBfDdiqn = binaryStream_0.smethod_0();
		this.eiaBfDdiqn = (this.eiaBfDdiqn << 12 | U.smethod_0(this.eiaBfDdiqn, 20));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14833);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		binaryStream_0.smethod_4(U.smethod_0(this.eiaBfDdiqn, 12) | this.eiaBfDdiqn << 20);
		binaryStream_0.smethod_7(7541);
	}

	public int int_0;

	public int eiaBfDdiqn;
}
