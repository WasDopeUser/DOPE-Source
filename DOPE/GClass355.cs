using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass355 : GClass354, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21205;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass355(GClass434 gclass434_1 = null)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (gclass434_1 == null)
		{
			this.gclass434_0 = new GClass434(0U, "", null, null);
			return;
		}
		this.gclass434_0 = gclass434_1;
	}

	public override int vmethod_0()
	{
		return 21205;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.gclass434_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass434);
		this.gclass434_0.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21205);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass434_0.imethod_2(binaryStream_0);
	}

	public GClass434 gclass434_0;
}
