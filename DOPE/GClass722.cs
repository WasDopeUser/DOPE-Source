using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass722 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 183;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass722(int int_3 = 0, int int_4 = 0, int int_5 = 0, string string_0 = "")
	{
		Class13.xnk8ImWzpOt04();
		this.GsnyzFeslK = "";
		base..ctor();
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.int_2 = int_5;
		this.GsnyzFeslK = string_0;
	}

	public virtual int vmethod_0()
	{
		return 183;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.int_1 = (int)binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		this.GsnyzFeslK = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(183);
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.smethod_7(this.int_1);
		binaryStream_0.smethod_4(this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		binaryStream_0.smethod_3(this.GsnyzFeslK);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public string GsnyzFeslK;
}
