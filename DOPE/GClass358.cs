using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass358 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 287;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass358(int int_3 = 0, int int_4 = 0, bool bool_1 = false, int int_5 = 0, GClass327 gclass327_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.bool_0 = bool_1;
		this.int_2 = int_5;
		if (gclass327_1 == null)
		{
			this.gclass327_0 = new GClass327(0);
			return;
		}
		this.gclass327_0 = gclass327_1;
	}

	public virtual int vmethod_0()
	{
		return 287;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 1) | this.int_2 << 31);
		this.gclass327_0 = (GClass327)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass327_0 != null)
		{
			this.gclass327_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(287);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.smethod_4(this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_2 << 1 | U.smethod_0(this.int_2, 31));
		if (this.gclass327_0 != null)
		{
			this.gclass327_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public int int_0;

	public int int_1;

	public bool bool_0;

	public int int_2;

	public GClass327 gclass327_0;
}
