using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass147 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28753;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass147(string string_1 = "", int int_1 = 0, uint uint_1 = 0U)
	{
		Class13.tMHx78BzgCM8j();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.int_0 = int_1;
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 28753;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28753);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(-29137);
		binaryStream_0.smethod_6(this.uint_0);
	}

	public int int_0;

	public string string_0;

	public uint uint_0;
}
