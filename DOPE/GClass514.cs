using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass514 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9784;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 22;
		}
	}

	public GClass514(int int_5 = 0, int int_6 = 0, string string_1 = "", GClass631 gclass631_0 = null, GClass736 gclass736_1 = null, int int_7 = 0, int int_8 = 0, int int_9 = 0)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		this.int_4 = int_5;
		this.int_3 = int_6;
		this.string_0 = string_1;
		if (gclass631_0 == null)
		{
			this.Progress = new GClass631(0, 0.0, 0.0, "", "", null, false);
		}
		else
		{
			this.Progress = gclass631_0;
		}
		if (gclass736_1 == null)
		{
			this.gclass736_0 = new GClass736(null);
		}
		else
		{
			this.gclass736_0 = gclass736_1;
		}
		this.int_1 = int_7;
		this.int_2 = int_8;
		this.int_0 = int_9;
	}

	public virtual int vmethod_0()
	{
		return 9784;
	}

	public virtual int vmethod_1()
	{
		return 22;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.Progress = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass631);
		this.Progress.HrqIugnatr8(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 15) | this.int_2 << 17);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 3) | this.int_3 << 29);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 11 | U.smethod_0(this.int_4, 21));
		this.gclass736_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass736);
		this.gclass736_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9784);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.Progress.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		binaryStream_0.smethod_4(this.int_2 << 15 | U.smethod_0(this.int_2, 17));
		binaryStream_0.smethod_4(this.int_3 << 3 | U.smethod_0(this.int_3, 29));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 11) | this.int_4 << 21);
		this.gclass736_0.imethod_1(binaryStream_0);
	}

	public GClass631 Progress;

	public int int_0;

	public string string_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public GClass736 gclass736_0;
}
