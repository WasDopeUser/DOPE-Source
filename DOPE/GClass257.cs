using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass257 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13887;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass257(GClass258 gclass258_1 = null, int int_2 = 0, int int_3 = 0, bool bool_0 = false)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (gclass258_1 == null)
		{
			this.gclass258_0 = new GClass258(0U);
		}
		else
		{
			this.gclass258_0 = gclass258_1;
		}
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.Enabled = bool_0;
	}

	public virtual int vmethod_0()
	{
		return 13887;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass258_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass258);
		this.gclass258_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 8 | U.smethod_0(this.int_1, 24));
		binaryStream_0.smethod_1();
		this.Enabled = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13887);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass258_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 8) | this.int_1 << 24);
		binaryStream_0.smethod_7(-23805);
		binaryStream_0.WriteBoolean(this.Enabled);
	}

	public GClass258 gclass258_0;

	public int int_0;

	public int int_1;

	public bool Enabled;
}
