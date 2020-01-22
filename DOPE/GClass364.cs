using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass364 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25860;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass364(string string_1 = "", int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.int_1 = int_3;
		this.int_2 = int_4;
		this.baxutsUbRZ = int_5;
		this.int_0 = int_6;
	}

	public virtual int vmethod_0()
	{
		return 25860;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 7 | U.smethod_0(this.int_2, 25));
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.baxutsUbRZ = binaryStream_0.smethod_0();
		this.baxutsUbRZ = (this.baxutsUbRZ << 9 | U.smethod_0(this.baxutsUbRZ, 23));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25860);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.smethod_4(this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 7) | this.int_2 << 25);
		binaryStream_0.smethod_7(1497);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.baxutsUbRZ, 9) | this.baxutsUbRZ << 23);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public string string_0;

	public int baxutsUbRZ;
}
