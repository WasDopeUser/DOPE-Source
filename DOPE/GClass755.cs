using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass755 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25570;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 25;
		}
	}

	public GClass755(int int_5 = 0, int int_6 = 0, string string_2 = "", string string_3 = "", GClass202 gclass202_1 = null, GClass565 gclass565_0 = null, GClass736 gclass736_1 = null, int int_7 = 0, int int_8 = 0, int int_9 = 0, bool bool_0 = false)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_0 = int_5;
		this.int_4 = int_6;
		this.string_0 = string_2;
		this.string_1 = string_3;
		if (gclass202_1 == null)
		{
			this.gclass202_0 = new GClass202(0U);
		}
		else
		{
			this.gclass202_0 = gclass202_1;
		}
		if (gclass565_0 == null)
		{
			this.State = new GClass565(0, 0, "", false, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, null, false);
		}
		else
		{
			this.State = gclass565_0;
		}
		if (gclass736_1 == null)
		{
			this.gclass736_0 = new GClass736(null);
		}
		else
		{
			this.gclass736_0 = gclass736_1;
		}
		this.int_1 = int_7;
		this.int_2 = int_8;
		this.int_3 = int_9;
		this.hnmrqOcWuw = bool_0;
	}

	public virtual int vmethod_0()
	{
		return 25570;
	}

	public virtual int vmethod_1()
	{
		return 25;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass736_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass736);
		this.gclass736_0.HrqIugnatr8(binaryStream_0);
		this.gclass202_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass202);
		this.gclass202_0.HrqIugnatr8(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		this.hnmrqOcWuw = binaryStream_0.ReadBoolean();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 3 | U.smethod_0(this.int_2, 29));
		this.State = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass565);
		this.State.HrqIugnatr8(binaryStream_0);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 11 | U.smethod_0(this.int_3, 21));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 5 | U.smethod_0(this.int_4, 27));
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25570);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass736_0.imethod_1(binaryStream_0);
		this.gclass202_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.smethod_4(this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		binaryStream_0.WriteBoolean(this.hnmrqOcWuw);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 3) | this.int_2 << 29);
		this.State.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 11) | this.int_3 << 21);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 5) | this.int_4 << 27);
		binaryStream_0.smethod_7(5953);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
	}

	public GClass736 gclass736_0;

	public GClass202 gclass202_0;

	public int int_0;

	public int int_1;

	public bool hnmrqOcWuw;

	public int int_2;

	public GClass565 State;

	public int int_3;

	public int int_4;

	public string string_0;

	public string string_1;
}
