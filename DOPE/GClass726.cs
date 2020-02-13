using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass726 : GClass724, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29974;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass726(bool bool_1 = false)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.bool_0 = bool_1;
	}

	public override int vmethod_0()
	{
		return 29974;
	}

	public override int vmethod_1()
	{
		return 1;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(29974);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_6(20575);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_6(24858);
	}

	public bool bool_0;
}
