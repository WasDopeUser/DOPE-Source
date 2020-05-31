using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass406 : GClass403, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18280;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass406(int int_1 = 0, int int_2 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.tvJcaqMokL = int_1;
		this.int_0 = int_2;
	}

	public override int vmethod_0()
	{
		return 18280;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		this.tvJcaqMokL = binaryStream_0.smethod_0();
		this.tvJcaqMokL = (U.smethod_0(this.tvJcaqMokL, 11) | this.tvJcaqMokL << 21);
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18280);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(28099);
		binaryStream_0.smethod_4(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.smethod_4(this.tvJcaqMokL << 11 | U.smethod_0(this.tvJcaqMokL, 21));
	}

	public int int_0;

	public int tvJcaqMokL;
}
