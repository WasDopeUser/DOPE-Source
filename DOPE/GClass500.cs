using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass500 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26957;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass500(int int_2 = 0, string string_1 = "", int int_3 = 0, GClass491 gclass491_1 = null, GClass492 gclass492_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_3;
		this.string_0 = string_1;
		if (gclass491_1 == null)
		{
			this.gclass491_0 = new GClass491(0.0, 0.0);
		}
		else
		{
			this.gclass491_0 = gclass491_1;
		}
		if (gclass492_1 == null)
		{
			this.gclass492_0 = new GClass492(0, 0);
		}
		else
		{
			this.gclass492_0 = gclass492_1;
		}
		this.int_1 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 26957;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass491_0 = (GClass491)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass491_0 != null)
		{
			this.gclass491_0.imethod_1(binaryStream_0);
		}
		this.gclass492_0 = (GClass492)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass492_0 != null)
		{
			this.gclass492_0.imethod_1(binaryStream_0);
		}
		this.int_1 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(26957);
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.smethod_3(this.string_0);
		if (this.gclass491_0 != null)
		{
			this.gclass491_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass492_0 != null)
		{
			this.gclass492_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_7(this.int_1);
	}

	public int int_0;

	public string string_0;

	public GClass491 gclass491_0;

	public GClass492 gclass492_0;

	public int int_1;
}
