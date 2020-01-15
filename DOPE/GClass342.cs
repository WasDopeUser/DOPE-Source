using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass342 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22326;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass342(int int_1 = 0, string string_1 = "", string string_2 = "", int int_2 = 0)
	{
		Class13.nIxas2ezryi9b();
		this.string_0 = "";
		this.Name = "";
		base..ctor();
		this.rAyhsDmyVm = int_1;
		this.Name = string_1;
		this.string_0 = string_2;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 22326;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.Name = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.rAyhsDmyVm = binaryStream_0.smethod_0();
		this.rAyhsDmyVm = (U.smethod_0(this.rAyhsDmyVm, 3) | this.rAyhsDmyVm << 29);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22326);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.smethod_4(this.rAyhsDmyVm << 3 | U.smethod_0(this.rAyhsDmyVm, 29));
	}

	public string string_0;

	public string Name;

	public int int_0;

	public int rAyhsDmyVm;
}
