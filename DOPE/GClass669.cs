﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass669 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 88;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 23;
		}
	}

	public GClass669(bool bool_22 = false, bool bool_23 = false, bool bool_24 = false, bool bool_25 = false, bool bool_26 = false, bool bool_27 = false, bool bool_28 = false, bool bool_29 = false, bool bool_30 = false, bool bool_31 = false, bool bool_32 = false, bool bool_33 = false, bool bool_34 = false, bool bool_35 = false, bool bool_36 = false, bool bool_37 = false, bool bool_38 = false, bool bool_39 = false, bool bool_40 = false, bool bool_41 = false, bool bool_42 = false, bool bool_43 = false, bool bool_44 = false, GClass327 gclass327_2 = null, GClass327 gclass327_3 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.bool_0 = bool_22;
		this.bool_1 = bool_23;
		this.bool_2 = bool_24;
		this.bool_3 = bool_25;
		this.sqfVwhoUdK = bool_26;
		this.bool_4 = bool_27;
		this.bool_5 = bool_28;
		this.bool_6 = bool_29;
		this.bool_7 = bool_30;
		this.bool_8 = bool_31;
		this.bool_9 = bool_32;
		this.bool_10 = bool_33;
		this.bool_11 = bool_34;
		this.bool_12 = bool_35;
		this.bool_13 = bool_36;
		this.bool_14 = bool_37;
		this.bool_15 = bool_38;
		this.bool_16 = bool_39;
		this.bool_17 = bool_40;
		this.bool_18 = bool_41;
		this.bool_19 = bool_42;
		this.bool_20 = bool_43;
		this.bool_21 = bool_44;
		if (gclass327_2 == null)
		{
			this.gclass327_0 = new GClass327(0);
		}
		else
		{
			this.gclass327_0 = gclass327_2;
		}
		if (gclass327_3 == null)
		{
			this.gclass327_1 = new GClass327(0);
			return;
		}
		this.gclass327_1 = gclass327_3;
	}

	public virtual int vmethod_0()
	{
		return 88;
	}

	public virtual int vmethod_1()
	{
		return 23;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.bool_3 = binaryStream_0.ReadBoolean();
		this.sqfVwhoUdK = binaryStream_0.ReadBoolean();
		this.bool_4 = binaryStream_0.ReadBoolean();
		this.bool_5 = binaryStream_0.ReadBoolean();
		this.bool_6 = binaryStream_0.ReadBoolean();
		this.bool_7 = binaryStream_0.ReadBoolean();
		this.bool_8 = binaryStream_0.ReadBoolean();
		this.bool_9 = binaryStream_0.ReadBoolean();
		this.bool_10 = binaryStream_0.ReadBoolean();
		this.bool_11 = binaryStream_0.ReadBoolean();
		this.bool_12 = binaryStream_0.ReadBoolean();
		this.bool_13 = binaryStream_0.ReadBoolean();
		this.bool_14 = binaryStream_0.ReadBoolean();
		this.bool_15 = binaryStream_0.ReadBoolean();
		this.bool_16 = binaryStream_0.ReadBoolean();
		this.bool_17 = binaryStream_0.ReadBoolean();
		this.bool_18 = binaryStream_0.ReadBoolean();
		this.bool_19 = binaryStream_0.ReadBoolean();
		this.bool_20 = binaryStream_0.ReadBoolean();
		this.bool_21 = binaryStream_0.ReadBoolean();
		this.gclass327_0 = (GClass327)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass327_0 != null)
		{
			this.gclass327_0.imethod_1(binaryStream_0);
		}
		this.gclass327_1 = (GClass327)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass327_1 != null)
		{
			this.gclass327_1.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(88);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.WriteBoolean(this.bool_3);
		binaryStream_0.WriteBoolean(this.sqfVwhoUdK);
		binaryStream_0.WriteBoolean(this.bool_4);
		binaryStream_0.WriteBoolean(this.bool_5);
		binaryStream_0.WriteBoolean(this.bool_6);
		binaryStream_0.WriteBoolean(this.bool_7);
		binaryStream_0.WriteBoolean(this.bool_8);
		binaryStream_0.WriteBoolean(this.bool_9);
		binaryStream_0.WriteBoolean(this.bool_10);
		binaryStream_0.WriteBoolean(this.bool_11);
		binaryStream_0.WriteBoolean(this.bool_12);
		binaryStream_0.WriteBoolean(this.bool_13);
		binaryStream_0.WriteBoolean(this.bool_14);
		binaryStream_0.WriteBoolean(this.bool_15);
		binaryStream_0.WriteBoolean(this.bool_16);
		binaryStream_0.WriteBoolean(this.bool_17);
		binaryStream_0.WriteBoolean(this.bool_18);
		binaryStream_0.WriteBoolean(this.bool_19);
		binaryStream_0.WriteBoolean(this.bool_20);
		binaryStream_0.WriteBoolean(this.bool_21);
		if (this.gclass327_0 != null)
		{
			this.gclass327_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass327_1 != null)
		{
			this.gclass327_1.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public bool bool_0;

	public bool bool_1;

	public bool bool_2;

	public bool bool_3;

	public bool sqfVwhoUdK;

	public bool bool_4;

	public bool bool_5;

	public bool bool_6;

	public bool bool_7;

	public bool bool_8;

	public bool bool_9;

	public bool bool_10;

	public bool bool_11;

	public bool bool_12;

	public bool bool_13;

	public bool bool_14;

	public bool bool_15;

	public bool bool_16;

	public bool bool_17;

	public bool bool_18;

	public bool bool_19;

	public bool bool_20;

	public bool bool_21;

	public GClass327 gclass327_0;

	public GClass327 gclass327_1;
}
