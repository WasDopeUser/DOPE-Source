using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass633 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2391;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass633(string string_0 = "", int int_1 = 0, int int_2 = 0)
	{
		Class13.tMHx78BzgCM8j();
		this.Id = "";
		base..ctor();
		this.Id = string_0;
		this.Progress = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 2391;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_2();
		this.Progress = binaryStream_0.smethod_0();
		this.Progress = (this.Progress << 9 | U.smethod_0(this.Progress, 23));
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2391);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.Id);
		binaryStream_0.smethod_4(U.smethod_0(this.Progress, 9) | this.Progress << 23);
		binaryStream_0.smethod_7(5174);
		binaryStream_0.smethod_4(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
	}

	public string Id;

	public int Progress;

	public int int_0;
}
