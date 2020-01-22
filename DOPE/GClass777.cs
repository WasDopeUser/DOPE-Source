using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass777 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6926;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass777(string string_1 = "", double double_1 = 0.0, int int_1 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.double_0 = double_1;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 6926;
	}

	public virtual int vmethod_1()
	{
		return 14;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.double_0 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6926);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.WriteDouble(this.double_0);
	}

	public string string_0;

	public int int_0;

	public double double_0;
}
