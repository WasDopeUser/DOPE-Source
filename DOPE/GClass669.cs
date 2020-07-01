using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass669 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3260;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass669(string string_1 = "", GClass130 gclass130_1 = null, GClass463 gclass463_1 = null, int int_2 = 0, int int_3 = 0, int int_4 = 0)
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (gclass130_1 == null)
		{
			this.gclass130_0 = new GClass130(0);
		}
		else
		{
			this.gclass130_0 = gclass130_1;
		}
		if (gclass463_1 == null)
		{
			this.gclass463_0 = new GClass463(0);
		}
		else
		{
			this.gclass463_0 = gclass463_1;
		}
		this.ovqtgXsOuP = int_2;
		this.int_0 = int_3;
		this.int_1 = int_4;
	}

	public virtual int vmethod_0()
	{
		return 3260;
	}

	public virtual int vmethod_1()
	{
		return 14;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass130_0 = (GClass130)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass130_0 != null)
		{
			this.gclass130_0.imethod_0(binaryStream_0);
		}
		this.gclass463_0 = (GClass463)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass463_0 != null)
		{
			this.gclass463_0.imethod_0(binaryStream_0);
		}
		this.ovqtgXsOuP = binaryStream_0.smethod_0();
		this.ovqtgXsOuP = (this.ovqtgXsOuP << 1 | U.smethod_0(this.ovqtgXsOuP, 31));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 9) | this.int_1 << 23);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3260);
		binaryStream_0.smethod_3(this.string_0);
		if (this.gclass130_0 != null)
		{
			this.gclass130_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass463_0 != null)
		{
			this.gclass463_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.ovqtgXsOuP, 1) | this.ovqtgXsOuP << 31);
		binaryStream_0.smethod_4(this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		binaryStream_0.smethod_4(this.int_1 << 9 | U.smethod_0(this.int_1, 23));
	}

	public string string_0;

	public GClass130 gclass130_0;

	public GClass463 gclass463_0;

	public int ovqtgXsOuP;

	public int int_0;

	public int int_1;
}
