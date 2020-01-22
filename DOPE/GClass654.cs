using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass654 : GClass651, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22952;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass654(int int_0 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.Value = int_0;
	}

	public override int vmethod_0()
	{
		return 22952;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.Value = binaryStream_0.smethod_0();
		this.Value = (this.Value << 10 | U.smethod_0(this.Value, 22));
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22952);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.Value, 10) | this.Value << 22);
		binaryStream_0.smethod_7(24044);
		binaryStream_0.smethod_7(-31651);
	}

	public int Value;
}
