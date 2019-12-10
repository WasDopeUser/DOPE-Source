using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass208 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11542;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass208(int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_1 = int_3;
		this.ViGneyvcs2 = int_4;
		this.int_0 = int_5;
		this.int_2 = int_6;
	}

	public virtual int vmethod_0()
	{
		return 11542;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 16 | U.smethod_0(this.int_2, 16));
		this.ViGneyvcs2 = binaryStream_0.smethod_0();
		this.ViGneyvcs2 = (this.ViGneyvcs2 << 5 | U.smethod_0(this.ViGneyvcs2, 27));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(11542);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		binaryStream_0.smethod_5(-18674);
		binaryStream_0.fUeiimuocMk(this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 16) | this.int_2 << 16);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.ViGneyvcs2, 5) | this.ViGneyvcs2 << 27);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int ViGneyvcs2;
}
