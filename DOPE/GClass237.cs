using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass237 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3392;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass237(int int_1 = 0, GClass262 gclass262_0 = null, GClass263 gclass263_1 = null, GClass171 gclass171_1 = null, uint uint_2 = 0U, uint uint_3 = 0U, bool bool_1 = false)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_0 = int_1;
		if (gclass262_0 == null)
		{
			this.Status = new GClass262(false, false, "", null, null, false, 0.0, 0.0, 0U, "", false, false, false);
		}
		else
		{
			this.Status = gclass262_0;
		}
		if (gclass263_1 == null)
		{
			this.gclass263_0 = new GClass263("", null, 0.0, 0.0, false);
		}
		else
		{
			this.gclass263_0 = gclass263_1;
		}
		if (gclass171_1 == null)
		{
			this.gclass171_0 = new GClass171(0U);
		}
		else
		{
			this.gclass171_0 = gclass171_1;
		}
		this.uint_1 = uint_2;
		this.uint_0 = uint_3;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 3392;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.Status = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass262);
		this.Status.imethod_1(binaryStream_0);
		this.gclass263_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass263);
		this.gclass263_0.imethod_1(binaryStream_0);
		this.gclass171_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass171);
		this.gclass171_0.imethod_1(binaryStream_0);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.smethod_1();
		this.uint_1 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(3392);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_5(22984);
		this.Status.imethod_2(binaryStream_0);
		this.gclass263_0.imethod_2(binaryStream_0);
		this.gclass171_0.imethod_2(binaryStream_0);
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		binaryStream_0.fUeiimuocMk(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_5(-13648);
		binaryStream_0.lwAiiEjwcUm(this.uint_1);
	}

	public bool bool_0;

	public GClass262 Status;

	public GClass263 gclass263_0;

	public GClass171 gclass171_0;

	public uint uint_0;

	public int int_0;

	public uint uint_1;
}
