using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass229 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30682;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 22;
		}
	}

	public GClass229(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, bool bool_3 = false, bool bool_4 = false, bool bool_5 = false, string string_1 = "", bool bool_6 = false)
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		base..ctor();
		this.int_1 = int_4;
		this.int_0 = int_5;
		this.int_2 = int_6;
		this.int_3 = int_7;
		this.bool_1 = bool_3;
		this.bool_2 = bool_4;
		this.bool_0 = bool_5;
		this.string_0 = string_1;
		this.yvsaNhasqP = bool_6;
	}

	public virtual int vmethod_0()
	{
		return 30682;
	}

	public virtual int vmethod_1()
	{
		return 22;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.yvsaNhasqP = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 4) | this.int_1 << 28);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.bool_1 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 7) | this.int_2 << 25);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 1 | U.smethod_0(this.int_3, 31));
		this.bool_2 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30682);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.yvsaNhasqP);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		binaryStream_0.smethod_4(this.int_1 << 4 | U.smethod_0(this.int_1, 28));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(-17760);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_7(27448);
		binaryStream_0.smethod_4(this.int_2 << 7 | U.smethod_0(this.int_2, 25));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 1) | this.int_3 << 31);
		binaryStream_0.WriteBoolean(this.bool_2);
	}

	public bool yvsaNhasqP;

	public int int_0;

	public int int_1;

	public bool bool_0;

	public string string_0;

	public bool bool_1;

	public int int_2;

	public int int_3;

	public bool bool_2;
}
