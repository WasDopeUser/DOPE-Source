using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass650 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20230;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass650(string string_0 = "", int int_1 = 0, int int_2 = 0)
	{
		Class13.NP5bWyNzLwONS();
		this.Id = "";
		base..ctor();
		this.Id = string_0;
		this.Progress = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 20230;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		this.Id = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.Progress = binaryStream_0.smethod_0();
		this.Progress = (this.Progress << 15 | U.smethod_0(this.Progress, 17));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20230);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.smethod_3(this.Id);
		binaryStream_0.smethod_7(-1090);
		binaryStream_0.smethod_4(U.smethod_0(this.Progress, 15) | this.Progress << 17);
		binaryStream_0.smethod_7(21225);
	}

	public int int_0;

	public string Id;

	public int Progress;
}
