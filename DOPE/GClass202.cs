using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass202 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24353;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass202(bool bool_0 = false)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.adIiHaIywk = bool_0;
	}

	public override int vmethod_0()
	{
		return 24353;
	}

	public override int vmethod_1()
	{
		return 1;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.adIiHaIywk = binaryStream_0.ReadBoolean();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(24353);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.adIiHaIywk);
	}

	public bool adIiHaIywk;
}
