using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass596 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3635;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass596(int int_0 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.yKmobogkf2 = int_0;
	}

	public virtual int vmethod_0()
	{
		return 3635;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.yKmobogkf2 = binaryStream_0.smethod_0();
		this.yKmobogkf2 = (this.yKmobogkf2 << 7 | U.smethod_0(this.yKmobogkf2, 25));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(3635);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.yKmobogkf2, 7) | this.yKmobogkf2 << 25);
	}

	public int yKmobogkf2;
}
