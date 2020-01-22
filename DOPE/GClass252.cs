using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass252 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13470;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass252(int int_1 = 0, GClass276 gclass276_0 = null, GClass277 gclass277_1 = null, GClass178 gclass178_1 = null, uint uint_2 = 0U, uint uint_3 = 0U, bool bool_1 = false)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_0 = int_1;
		if (gclass276_0 == null)
		{
			this.Status = new GClass276(false, false, "", null, null, false, 0.0, 0.0, 0U, "", false, false, false);
		}
		else
		{
			this.Status = gclass276_0;
		}
		if (gclass277_1 == null)
		{
			this.gclass277_0 = new GClass277("", null, 0.0, 0.0, false);
		}
		else
		{
			this.gclass277_0 = gclass277_1;
		}
		if (gclass178_1 == null)
		{
			this.gclass178_0 = new GClass178(0U);
		}
		else
		{
			this.gclass178_0 = gclass178_1;
		}
		this.uint_1 = uint_2;
		this.uint_0 = uint_3;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 13470;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.Status = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass276);
		this.Status.imethod_1(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.uint_1 = (uint)binaryStream_0.smethod_1();
		this.gclass277_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass277);
		this.gclass277_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		this.gclass178_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass178);
		this.gclass178_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13470);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.uint_0);
		this.Status.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_6(this.uint_1);
		this.gclass277_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.gclass178_0.imethod_2(binaryStream_0);
	}

	public uint uint_0;

	public GClass276 Status;

	public bool bool_0;

	public uint uint_1;

	public GClass277 gclass277_0;

	public int int_0;

	public GClass178 gclass178_0;
}
