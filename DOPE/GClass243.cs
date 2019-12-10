using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass243 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6766;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass243(GClass244 gclass244_1 = null, int int_2 = 0, int int_3 = 0, bool bool_0 = false)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass244_1 == null)
		{
			this.gclass244_0 = new GClass244(0U);
		}
		else
		{
			this.gclass244_0 = gclass244_1;
		}
		this.int_1 = int_2;
		this.int_0 = int_3;
		this.Enabled = bool_0;
	}

	public virtual int vmethod_0()
	{
		return 6766;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		this.gclass244_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass244);
		this.gclass244_0.imethod_1(binaryStream_0);
		this.Enabled = binaryStream_0.ReadBoolean();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 16 | U.smethod_0(this.int_1, 16));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(6766);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(-10339);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		this.gclass244_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.Enabled);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 16) | this.int_1 << 16);
	}

	public int int_0;

	public GClass244 gclass244_0;

	public bool Enabled;

	public int int_1;
}
