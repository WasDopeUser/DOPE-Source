using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass661 : GClass660, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18857;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass661(string string_1 = "", int int_0 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor(string_1);
		this.QuSikNxArZ = int_0;
	}

	public override int vmethod_0()
	{
		return 18857;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.QuSikNxArZ = binaryStream_0.smethod_0();
		this.QuSikNxArZ = (U.smethod_0(this.QuSikNxArZ, 15) | this.QuSikNxArZ << 17);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18857);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.QuSikNxArZ << 15 | U.smethod_0(this.QuSikNxArZ, 17));
	}

	public int QuSikNxArZ;
}
