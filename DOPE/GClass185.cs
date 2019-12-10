using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass185 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5988;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass185(int int_2 = 0, string string_2 = "", GClass195 gclass195_2 = null, int int_3 = 0, string string_3 = "", GClass195 gclass195_3 = null)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_1 = int_2;
		this.string_1 = string_2;
		if (gclass195_2 == null)
		{
			this.gclass195_0 = new GClass195(0U);
		}
		else
		{
			this.gclass195_0 = gclass195_2;
		}
		this.int_0 = int_3;
		this.string_0 = string_3;
		if (gclass195_3 == null)
		{
			this.gclass195_1 = new GClass195(0U);
			return;
		}
		this.gclass195_1 = gclass195_3;
	}

	public virtual int vmethod_0()
	{
		return 5988;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		this.gclass195_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass195);
		this.gclass195_0.imethod_1(binaryStream_0);
		this.gclass195_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass195);
		this.gclass195_1.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 11 | U.smethod_0(this.int_1, 21));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(5988);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_5(-10927);
		binaryStream_0.fUeiimuocMk(this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		this.gclass195_0.imethod_2(binaryStream_0);
		this.gclass195_1.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 11) | this.int_1 << 21);
	}

	public string string_0;

	public string string_1;

	public int int_0;

	public GClass195 gclass195_0;

	public GClass195 gclass195_1;

	public int int_1;
}
