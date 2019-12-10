using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass668 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23481;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass668(int int_4 = 0, int int_5 = 0, string string_2 = "", int int_6 = 0, int int_7 = 0, string string_3 = "", GClass191 gclass191_1 = null)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_2 = int_4;
		this.int_1 = int_5;
		this.string_1 = string_2;
		this.int_0 = int_6;
		this.int_3 = int_7;
		this.string_0 = string_3;
		if (gclass191_1 == null)
		{
			this.gclass191_0 = new GClass191(0U);
			return;
		}
		this.gclass191_0 = gclass191_1;
	}

	public virtual int vmethod_0()
	{
		return 23481;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass191_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass191);
		this.gclass191_0.imethod_1(binaryStream_0);
		this.string_1 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 4) | this.int_1 << 28);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 2) | this.int_2 << 30);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 2 | U.smethod_0(this.int_3, 30));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(23481);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.smethod_3(this.string_0);
		this.gclass191_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.fUeiimuocMk(this.int_1 << 4 | U.smethod_0(this.int_1, 28));
		binaryStream_0.fUeiimuocMk(this.int_2 << 2 | U.smethod_0(this.int_2, 30));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_3, 2) | this.int_3 << 30);
	}

	public int int_0;

	public string string_0;

	public GClass191 gclass191_0;

	public string string_1;

	public int int_1;

	public int int_2;

	public int int_3;
}
