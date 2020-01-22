using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass633 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21989;
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
		Class13.plZSWFPzBWWEZ();
		this.Id = "";
		base..ctor();
		this.Id = string_0;
		this.Progress = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 21989;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.Progress = binaryStream_0.smethod_0();
		this.Progress = (U.smethod_0(this.Progress, 7) | this.Progress << 25);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21989);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.Id);
		binaryStream_0.smethod_7(24476);
		binaryStream_0.smethod_7(-6405);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_4(this.Progress << 7 | U.smethod_0(this.Progress, 25));
	}

	public string Id;

	public int int_0;

	public int Progress;
}
