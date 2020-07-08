using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass802 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6004;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 25;
		}
	}

	public GClass802(int int_5 = 0, int int_6 = 0, string string_2 = "", string string_3 = "", GClass200 gclass200_1 = null, GClass572 gclass572_0 = null, GClass780 gclass780_1 = null, int int_7 = 0, int int_8 = 0, int int_9 = 0, bool bool_1 = false)
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_0 = int_5;
		this.int_1 = int_6;
		this.string_0 = string_2;
		this.string_1 = string_3;
		if (gclass200_1 == null)
		{
			this.gclass200_0 = new GClass200(0);
		}
		else
		{
			this.gclass200_0 = gclass200_1;
		}
		if (gclass572_0 == null)
		{
			this.State = new GClass572(0, 0, "", false, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, null, false);
		}
		else
		{
			this.State = gclass572_0;
		}
		if (gclass780_1 == null)
		{
			this.gclass780_0 = new GClass780(null);
		}
		else
		{
			this.gclass780_0 = gclass780_1;
		}
		this.int_2 = int_7;
		this.int_3 = int_8;
		this.int_4 = int_9;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 6004;
	}

	public virtual int vmethod_1()
	{
		return 25;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.gclass200_0 = (GClass200)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass200_0 != null)
		{
			this.gclass200_0.imethod_1(binaryStream_0);
		}
		this.State = (GClass572)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.State != null)
		{
			this.State.imethod_1(binaryStream_0);
		}
		this.gclass780_0 = (GClass780)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass780_0 != null)
		{
			this.gclass780_0.imethod_1(binaryStream_0);
		}
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 13) | this.int_2 << 19);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 8) | this.int_3 << 24);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 15 | U.smethod_0(this.int_4, 17));
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6004);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.smethod_4(this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		if (this.gclass200_0 != null)
		{
			this.gclass200_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.State != null)
		{
			this.State.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass780_0 != null)
		{
			this.gclass780_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(this.int_2 << 13 | U.smethod_0(this.int_2, 19));
		binaryStream_0.smethod_4(this.int_3 << 8 | U.smethod_0(this.int_3, 24));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 15) | this.int_4 << 17);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int int_0;

	public int int_1;

	public string string_0;

	public string string_1;

	public GClass200 gclass200_0;

	public GClass572 State;

	public GClass780 gclass780_0;

	public int int_2;

	public int int_3;

	public int int_4;

	public bool bool_0;
}
