using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass240 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24532;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass240(int int_3 = 0, int int_4 = 0, int int_5 = 0, bool bool_2 = false, bool bool_3 = false, int int_6 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_0 = int_3;
		this.int_2 = int_4;
		this.UayDxomhHO = int_5;
		this.bool_1 = bool_2;
		this.bool_0 = bool_3;
		this.int_1 = int_6;
	}

	public virtual int vmethod_0()
	{
		return 24532;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 14) | this.int_1 << 18);
		binaryStream_0.smethod_1();
		this.UayDxomhHO = binaryStream_0.smethod_0();
		this.UayDxomhHO = (U.smethod_0(this.UayDxomhHO, 14) | this.UayDxomhHO << 18);
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 2 | U.smethod_0(this.int_2, 30));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(24532);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		binaryStream_0.smethod_7(25557);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_1 << 14 | U.smethod_0(this.int_1, 18));
		binaryStream_0.smethod_7(8393);
		binaryStream_0.smethod_4(this.UayDxomhHO << 14 | U.smethod_0(this.UayDxomhHO, 18));
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 2) | this.int_2 << 30);
	}

	public int int_0;

	public bool bool_0;

	public int int_1;

	public int UayDxomhHO;

	public bool bool_1;

	public int int_2;
}
