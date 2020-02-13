using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass635 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9269;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass635(string string_0 = "", int int_1 = 0, int int_2 = 0)
	{
		Class13.igxcIukzfpare();
		this.Id = "";
		base..ctor();
		this.Id = string_0;
		this.Progress = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 9269;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		this.Id = binaryStream_0.smethod_2();
		this.Progress = binaryStream_0.smethod_0();
		this.Progress = (this.Progress << 13 | U.smethod_0(this.Progress, 19));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(9269);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.MoioCjQkqp0(this.Id);
		binaryStream_0.smethod_3(U.smethod_0(this.Progress, 13) | this.Progress << 19);
	}

	public int int_0;

	public string Id;

	public int Progress;
}
