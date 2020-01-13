using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass654 : GClass651, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13010;
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
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.Value = int_0;
	}

	public override int vmethod_0()
	{
		return 13010;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.Value = binaryStream_0.smethod_0();
		this.Value = (U.smethod_0(this.Value, 4) | this.Value << 28);
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13010);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-19457);
		binaryStream_0.smethod_4(this.Value << 4 | U.smethod_0(this.Value, 28));
		binaryStream_0.smethod_7(15580);
	}

	public int Value;
}
