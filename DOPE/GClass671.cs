using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass671 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20348;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 19;
		}
	}

	public GClass671(string string_1 = "", int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0, bool bool_1 = false)
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.Width = int_5;
		this.int_2 = int_6;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 20348;
	}

	public virtual int vmethod_1()
	{
		return 19;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 14 | U.smethod_0(this.int_1, 18));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 11 | U.smethod_0(this.int_2, 21));
		this.Width = binaryStream_0.smethod_0();
		this.Width = (this.Width << 5 | U.smethod_0(this.Width, 27));
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20348);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 14) | this.int_1 << 18);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 11) | this.int_2 << 21);
		binaryStream_0.smethod_4(U.smethod_0(this.Width, 5) | this.Width << 27);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(18142);
	}

	public bool bool_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int Width;

	public string string_0;
}
