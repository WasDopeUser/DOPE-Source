using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass837 : GClass836, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -804;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass837(int int_0 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.fPebCdZojN = int_0;
	}

	public override int vmethod_0()
	{
		return -804;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_0(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_0(binaryStream_0);
		this.fPebCdZojN = binaryStream_0.smethod_0();
		this.fPebCdZojN = (this.fPebCdZojN << 13 | U.smethod_0(this.fPebCdZojN, 19));
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-804);
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.fPebCdZojN, 13) | this.fPebCdZojN << 19);
	}

	public int fPebCdZojN;
}
