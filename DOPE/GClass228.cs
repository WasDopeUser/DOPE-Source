using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass228 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3164;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass228(int int_3 = 0, int int_4 = 0, string string_2 = "", string string_3 = "", int int_5 = 0)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_2 = int_3;
		this.int_1 = int_4;
		this.string_0 = string_2;
		this.string_1 = string_3;
		this.int_0 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 3164;
	}

	public virtual int vmethod_1()
	{
		return 14;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_1 = (int)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		this.string_1 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(3164);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_5(this.int_1);
		binaryStream_0.smethod_5(-16813);
		binaryStream_0.fUeiimuocMk(this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		binaryStream_0.smethod_3(this.string_1);
	}

	public int int_0;

	public string string_0;

	public int int_1;

	public int int_2;

	public string string_1;
}
