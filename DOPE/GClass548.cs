using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass548 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23099;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass548(string string_3 = "", int int_1 = 0, string string_4 = "", int int_2 = 0, string string_5 = "")
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		base..ctor();
		this.string_1 = string_3;
		this.dkspgqFcve = int_1;
		this.string_0 = string_4;
		this.int_0 = int_2;
		this.string_2 = string_5;
	}

	public virtual int vmethod_0()
	{
		return 23099;
	}

	public virtual int vmethod_1()
	{
		return 14;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		this.dkspgqFcve = binaryStream_0.smethod_0();
		this.dkspgqFcve = (this.dkspgqFcve << 6 | U.smethod_0(this.dkspgqFcve, 26));
		this.string_1 = binaryStream_0.smethod_2();
		this.string_2 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(23099);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.dkspgqFcve, 6) | this.dkspgqFcve << 26);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_3(this.string_2);
	}

	public string string_0;

	public int int_0;

	public int dkspgqFcve;

	public string string_1;

	public string string_2;
}
