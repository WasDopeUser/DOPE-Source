using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass622 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25274;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass622(int int_2 = 0, int int_3 = 0, string string_2 = "", string string_3 = "", string string_4 = "", int int_4 = 0)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		this.string_1 = "";
		this.eqionaZnxA = "";
		base..ctor();
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.eqionaZnxA = string_2;
		this.string_0 = string_3;
		this.string_1 = string_4;
		this.AfvocfDwpA = int_4;
	}

	public virtual int vmethod_0()
	{
		return 25274;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		this.AfvocfDwpA = binaryStream_0.smethod_0();
		this.AfvocfDwpA = (this.AfvocfDwpA << 12 | U.smethod_0(this.AfvocfDwpA, 20));
		this.string_0 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		this.string_1 = binaryStream_0.smethod_2();
		this.eqionaZnxA = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25274);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.smethod_4(U.smethod_0(this.AfvocfDwpA, 12) | this.AfvocfDwpA << 20);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_3(this.eqionaZnxA);
		binaryStream_0.smethod_7(-5923);
		binaryStream_0.smethod_7(-31143);
	}

	public int int_0;

	public int AfvocfDwpA;

	public string string_0;

	public int int_1;

	public string string_1;

	public string eqionaZnxA;
}
