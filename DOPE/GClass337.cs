using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass337 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12331;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass337(int int_3 = 0, int int_4 = 0, bool bool_1 = false, int int_5 = 0, GClass304 gclass304_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_1 = int_3;
		this.int_0 = int_4;
		this.bool_0 = bool_1;
		this.int_2 = int_5;
		if (gclass304_1 == null)
		{
			this.gclass304_0 = new GClass304(0U);
			return;
		}
		this.gclass304_0 = gclass304_1;
	}

	public virtual int vmethod_0()
	{
		return 12331;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass304_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass304);
		this.gclass304_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 13) | this.int_2 << 19);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(12331);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass304_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-27542);
		binaryStream_0.smethod_5(-16039);
		binaryStream_0.fUeiimuocMk(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		binaryStream_0.fUeiimuocMk(this.int_2 << 13 | U.smethod_0(this.int_2, 19));
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public GClass304 gclass304_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public bool bool_0;
}
