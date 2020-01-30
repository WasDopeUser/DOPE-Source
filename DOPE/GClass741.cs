using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass741 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17370;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 25;
		}
	}

	public GClass741(int int_4 = 0, int int_5 = 0, string string_2 = "", string string_3 = "", GClass201 gclass201_0 = null, GClass550 gclass550_0 = null, GClass721 gclass721_1 = null, int int_6 = 0, int int_7 = 0, int int_8 = 0, bool bool_1 = false)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_1 = int_4;
		this.int_3 = int_5;
		this.string_1 = string_2;
		this.string_0 = string_3;
		if (gclass201_0 == null)
		{
			this.lsKebIbnfv = new GClass201(0U);
		}
		else
		{
			this.lsKebIbnfv = gclass201_0;
		}
		if (gclass550_0 == null)
		{
			this.State = new GClass550(0, 0, "", false, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, null, false);
		}
		else
		{
			this.State = gclass550_0;
		}
		if (gclass721_1 == null)
		{
			this.gclass721_0 = new GClass721(null);
		}
		else
		{
			this.gclass721_0 = gclass721_1;
		}
		this.eeUelyIsWg = int_6;
		this.int_0 = int_7;
		this.int_2 = int_8;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 17370;
	}

	public virtual int vmethod_1()
	{
		return 25;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.eeUelyIsWg = binaryStream_0.smethod_0();
		this.eeUelyIsWg = (U.smethod_0(this.eeUelyIsWg, 11) | this.eeUelyIsWg << 21);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		this.lsKebIbnfv = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.lsKebIbnfv.imethod_1(binaryStream_0);
		this.string_1 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 2 | U.smethod_0(this.int_2, 30));
		this.gclass721_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass721);
		this.gclass721_0.imethod_1(binaryStream_0);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 8) | this.int_3 << 24);
		binaryStream_0.smethod_1();
		this.State = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass550);
		this.State.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(17370);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.eeUelyIsWg << 11 | U.smethod_0(this.eeUelyIsWg, 21));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.lsKebIbnfv.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 2) | this.int_2 << 30);
		this.gclass721_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_3 << 8 | U.smethod_0(this.int_3, 24));
		binaryStream_0.smethod_7(-3455);
		this.State.imethod_2(binaryStream_0);
	}

	public bool bool_0;

	public int eeUelyIsWg;

	public string string_0;

	public int int_0;

	public GClass201 lsKebIbnfv;

	public string string_1;

	public int int_1;

	public int int_2;

	public GClass721 gclass721_0;

	public int int_3;

	public GClass550 State;
}
