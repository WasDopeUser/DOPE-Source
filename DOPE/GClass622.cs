using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass622 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19338;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass622(string string_1 = "", string string_2 = "", int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.Name = "";
		base..ctor();
		this.Name = string_1;
		this.string_0 = string_2;
		this.int_1 = int_3;
		this.int_0 = int_4;
		this.int_2 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 19338;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		this.Name = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 7) | this.int_1 << 25);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 7 | U.smethod_0(this.int_2, 25));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(19338);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.fUeiimuocMk(this.int_1 << 7 | U.smethod_0(this.int_1, 25));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 7) | this.int_2 << 25);
	}

	public string string_0;

	public int int_0;

	public string Name;

	public int int_1;

	public int int_2;
}
