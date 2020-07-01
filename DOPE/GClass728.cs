using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass728 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 39;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass728(GClass327 gclass327_1 = null, int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass327_1 == null)
		{
			this.gclass327_0 = new GClass327(0);
		}
		else
		{
			this.gclass327_0 = gclass327_1;
		}
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.int_2 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 39;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass327_0 = (GClass327)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass327_0 != null)
		{
			this.gclass327_0.imethod_0(binaryStream_0);
		}
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 9) | this.int_2 << 23);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(39);
		if (this.gclass327_0 != null)
		{
			this.gclass327_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		binaryStream_0.smethod_4(this.int_2 << 9 | U.smethod_0(this.int_2, 23));
	}

	public GClass327 gclass327_0;

	public int int_0;

	public int int_1;

	public int int_2;
}
