using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass660 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8794;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 19;
		}
	}

	public GClass660(string string_1 = "", int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0, bool bool_1 = false)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.int_2 = int_3;
		this.int_0 = int_4;
		this.Width = int_5;
		this.int_1 = int_6;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 8794;
	}

	public virtual int vmethod_1()
	{
		return 19;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Width = binaryStream_0.smethod_0();
		this.Width = (this.Width << 16 | U.smethod_0(this.Width, 16));
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 6 | U.smethod_0(this.int_1, 26));
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 8) | this.int_2 << 24);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(8794);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.Width, 16) | this.Width << 16);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_5(-28363);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 6) | this.int_1 << 26);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_5(-7976);
		binaryStream_0.fUeiimuocMk(this.int_2 << 8 | U.smethod_0(this.int_2, 24));
	}

	public int Width;

	public bool bool_0;

	public int int_0;

	public int int_1;

	public string string_0;

	public int int_2;
}
