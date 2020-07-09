using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass803 : GInterface0
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

	public GClass803(int int_4 = 0, int int_5 = 0, string string_2 = "", string string_3 = "", GClass201 gclass201_1 = null, GClass573 gclass573_0 = null, GClass781 gclass781_1 = null, int int_6 = 0, int int_7 = 0, int int_8 = 0, bool bool_1 = false)
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_0 = int_4;
		this.int_1 = int_5;
		this.string_0 = string_2;
		this.string_1 = string_3;
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0);
		}
		else
		{
			this.gclass201_0 = gclass201_1;
		}
		if (gclass573_0 == null)
		{
			this.State = new GClass573(0, 0, "", false, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, null, false);
		}
		else
		{
			this.State = gclass573_0;
		}
		if (gclass781_1 == null)
		{
			this.gclass781_0 = new GClass781(null);
		}
		else
		{
			this.gclass781_0 = gclass781_1;
		}
		this.EehxkopMbt = int_6;
		this.int_2 = int_7;
		this.int_3 = int_8;
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
		this.gclass201_0 = (GClass201)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass201_0 != null)
		{
			this.gclass201_0.imethod_1(binaryStream_0);
		}
		this.State = (GClass573)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.State != null)
		{
			this.State.imethod_1(binaryStream_0);
		}
		this.gclass781_0 = (GClass781)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass781_0 != null)
		{
			this.gclass781_0.imethod_1(binaryStream_0);
		}
		this.EehxkopMbt = binaryStream_0.smethod_0();
		this.EehxkopMbt = (U.smethod_0(this.EehxkopMbt, 13) | this.EehxkopMbt << 19);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 8) | this.int_2 << 24);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 15 | U.smethod_0(this.int_3, 17));
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6004);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.smethod_4(this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		if (this.gclass201_0 != null)
		{
			this.gclass201_0.imethod_2(binaryStream_0);
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
		if (this.gclass781_0 != null)
		{
			this.gclass781_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(this.EehxkopMbt << 13 | U.smethod_0(this.EehxkopMbt, 19));
		binaryStream_0.smethod_4(this.int_2 << 8 | U.smethod_0(this.int_2, 24));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 15) | this.int_3 << 17);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int int_0;

	public int int_1;

	public string string_0;

	public string string_1;

	public GClass201 gclass201_0;

	public GClass573 State;

	public GClass781 gclass781_0;

	public int EehxkopMbt;

	public int int_2;

	public int int_3;

	public bool bool_0;
}
