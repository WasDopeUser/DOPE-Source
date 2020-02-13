using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass742 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18352;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 25;
		}
	}

	public GClass742(int int_5 = 0, int int_6 = 0, string string_2 = "", string string_3 = "", GClass201 gclass201_1 = null, GClass551 gclass551_0 = null, GClass722 gclass722_1 = null, int int_7 = 0, int int_8 = 0, int int_9 = 0, bool bool_1 = false)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_2 = int_5;
		this.int_4 = int_6;
		this.string_1 = string_2;
		this.string_0 = string_3;
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0U);
		}
		else
		{
			this.gclass201_0 = gclass201_1;
		}
		if (gclass551_0 == null)
		{
			this.State = new GClass551(0, 0, "", false, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, null, false);
		}
		else
		{
			this.State = gclass551_0;
		}
		if (gclass722_1 == null)
		{
			this.gclass722_0 = new GClass722(null);
		}
		else
		{
			this.gclass722_0 = gclass722_1;
		}
		this.int_0 = int_7;
		this.int_1 = int_8;
		this.int_3 = int_9;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 18352;
	}

	public virtual int vmethod_1()
	{
		return 25;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass722_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass722);
		this.gclass722_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 8) | this.int_1 << 24);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 4) | this.int_2 << 28);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 15 | U.smethod_0(this.int_3, 17));
		this.State = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass551);
		this.State.imethod_1(binaryStream_0);
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 7) | this.int_4 << 25);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(18352);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass722_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.MoioCjQkqp0(this.string_1);
		binaryStream_0.smethod_3(this.int_1 << 8 | U.smethod_0(this.int_1, 24));
		binaryStream_0.smethod_3(this.int_2 << 4 | U.smethod_0(this.int_2, 28));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_3, 15) | this.int_3 << 17);
		this.State.imethod_2(binaryStream_0);
		this.gclass201_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.int_4 << 7 | U.smethod_0(this.int_4, 25));
	}

	public GClass722 gclass722_0;

	public int int_0;

	public string string_0;

	public string string_1;

	public int int_1;

	public int int_2;

	public bool bool_0;

	public int int_3;

	public GClass551 State;

	public GClass201 gclass201_0;

	public int int_4;
}
