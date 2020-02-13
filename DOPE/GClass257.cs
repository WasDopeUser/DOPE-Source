using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass257 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13270;
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
		Class13.igxcIukzfpare();
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
		return 13270;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		this.gclass258_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass258);
		this.gclass258_0.imethod_1(binaryStream_0);
		this.Enabled = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(13270);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.smethod_6(360);
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		this.gclass258_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.Enabled);
	}

	public int int_0;

	public int int_1;

	public GClass258 gclass258_0;

	public bool Enabled;
}
