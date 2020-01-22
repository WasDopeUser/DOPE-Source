using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass779 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17208;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass779(GClass347 gclass347_1 = null, int int_2 = 0, int int_3 = 0, bool bool_1 = false)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (gclass347_1 == null)
		{
			this.gclass347_0 = new GClass347(0U);
		}
		else
		{
			this.gclass347_0 = gclass347_1;
		}
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 17208;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 7) | this.int_1 << 25);
		this.gclass347_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass347);
		this.gclass347_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(17208);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.smethod_4(this.int_1 << 7 | U.smethod_0(this.int_1, 25));
		this.gclass347_0.imethod_2(binaryStream_0);
	}

	public bool bool_0;

	public int int_0;

	public int int_1;

	public GClass347 gclass347_0;
}
