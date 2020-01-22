using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass342 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3486;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass342(int int_2 = 0, string string_1 = "", string string_2 = "", int int_3 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		this.Name = "";
		this.string_0 = "";
		base..ctor();
		this.int_1 = int_2;
		this.Name = string_1;
		this.string_0 = string_2;
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 3486;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		this.Name = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3486);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-14613);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		binaryStream_0.smethod_3(this.string_0);
	}

	public int int_0;

	public string Name;

	public int int_1;

	public string string_0;
}
