using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass196 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7722;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass196(int int_1 = 0, string string_1 = "", GClass208 gclass208_2 = null, int int_2 = 0, string string_2 = "", GClass208 gclass208_3 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		this.FromName = "";
		base..ctor();
		this.FromId = int_1;
		this.FromName = string_1;
		if (gclass208_2 == null)
		{
			this.gclass208_1 = new GClass208(0U);
		}
		else
		{
			this.gclass208_1 = gclass208_2;
		}
		this.int_0 = int_2;
		this.string_0 = string_2;
		if (gclass208_3 == null)
		{
			this.gclass208_0 = new GClass208(0U);
			return;
		}
		this.gclass208_0 = gclass208_3;
	}

	public virtual int vmethod_0()
	{
		return 7722;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.gclass208_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass208);
		this.gclass208_0.HrqIugnatr8(binaryStream_0);
		this.FromId = binaryStream_0.smethod_0();
		this.FromId = (this.FromId << 13 | U.smethod_0(this.FromId, 19));
		this.FromName = binaryStream_0.smethod_2();
		this.gclass208_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass208);
		this.gclass208_1.HrqIugnatr8(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7722);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(2933);
		this.gclass208_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.FromId, 13) | this.FromId << 19);
		binaryStream_0.smethod_3(this.FromName);
		this.gclass208_1.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		binaryStream_0.smethod_7(29095);
	}

	public string string_0;

	public GClass208 gclass208_0;

	public int FromId;

	public string FromName;

	public GClass208 gclass208_1;

	public int int_0;
}
