using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass676 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32320;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass676(string string_0 = "", int int_1 = 0, int int_2 = 0)
	{
		Class13.F93tSdiz1aNIA();
		this.Id = "";
		base..ctor();
		this.Id = string_0;
		this.Progress = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 32320;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_2();
		this.Progress = binaryStream_0.smethod_0();
		this.Progress = (this.Progress << 10 | U.smethod_0(this.Progress, 22));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32320);
		binaryStream_0.smethod_3(this.Id);
		binaryStream_0.smethod_4(U.smethod_0(this.Progress, 10) | this.Progress << 22);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
	}

	public string Id;

	public int Progress;

	public int int_0;
}
