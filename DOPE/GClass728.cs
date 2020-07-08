using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass728 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6003;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass728(int int_4 = 0, int int_5 = 0, string string_2 = "", int int_6 = 0, int int_7 = 0, string string_3 = "", GClass200 gclass200_0 = null)
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_0 = int_4;
		this.int_1 = int_5;
		this.string_0 = string_2;
		this.int_2 = int_6;
		this.int_3 = int_7;
		this.string_1 = string_3;
		if (gclass200_0 == null)
		{
			this.GQSICYNPRI = new GClass200(0);
			return;
		}
		this.GQSICYNPRI = gclass200_0;
	}

	public virtual int vmethod_0()
	{
		return 6003;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		this.string_0 = binaryStream_0.smethod_2();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 16) | this.int_2 << 16);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 10) | this.int_3 << 22);
		this.string_1 = binaryStream_0.smethod_2();
		this.GQSICYNPRI = (GClass200)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.GQSICYNPRI != null)
		{
			this.GQSICYNPRI.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6003);
		binaryStream_0.smethod_4(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_2 << 16 | U.smethod_0(this.int_2, 16));
		binaryStream_0.smethod_4(this.int_3 << 10 | U.smethod_0(this.int_3, 22));
		binaryStream_0.smethod_3(this.string_1);
		if (this.GQSICYNPRI != null)
		{
			this.GQSICYNPRI.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public int int_0;

	public int int_1;

	public string string_0;

	public int int_2;

	public int int_3;

	public string string_1;

	public GClass200 GQSICYNPRI;
}
