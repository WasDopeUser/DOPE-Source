using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass679 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26808;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass679(int int_4 = 0, int int_5 = 0, string string_2 = "", int int_6 = 0, int int_7 = 0, string string_3 = "", GClass201 gclass201_1 = null)
	{
		Class13.tMHx78BzgCM8j();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_0 = int_4;
		this.int_2 = int_5;
		this.string_0 = string_2;
		this.int_1 = int_6;
		this.int_3 = int_7;
		this.string_1 = string_3;
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0U);
			return;
		}
		this.gclass201_0 = gclass201_1;
	}

	public virtual int vmethod_0()
	{
		return 26808;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 16) | this.int_2 << 16);
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 4) | this.int_3 << 28);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(26808);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass201_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_4(this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		binaryStream_0.smethod_4(this.int_2 << 16 | U.smethod_0(this.int_2, 16));
		binaryStream_0.smethod_7(-19508);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_4(this.int_3 << 4 | U.smethod_0(this.int_3, 28));
	}

	public GClass201 gclass201_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public string string_0;

	public string string_1;

	public int int_3;
}
