using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass629 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 890;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 23;
		}
	}

	public GClass629(bool bool_21 = false, bool bool_22 = false, bool bool_23 = false, bool bool_24 = false, bool bool_25 = false, bool bool_26 = false, bool bool_27 = false, bool bool_28 = false, bool bool_29 = false, bool bool_30 = false, bool bool_31 = false, bool bool_32 = false, bool bool_33 = false, bool bool_34 = false, bool bool_35 = false, bool bool_36 = false, bool bool_37 = false, bool bool_38 = false, bool bool_39 = false, bool bool_40 = false, bool bool_41 = false, bool bool_42 = false, bool bool_43 = false, GClass320 gclass320_1 = null, GClass320 gclass320_2 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.bWiDaAoMmf = bool_21;
		this.bool_9 = bool_22;
		this.pAgDzevjh7 = bool_23;
		this.bool_19 = bool_24;
		this.bool_13 = bool_25;
		this.bool_16 = bool_26;
		this.bool_4 = bool_27;
		this.bool_1 = bool_28;
		this.bool_15 = bool_29;
		this.bool_5 = bool_30;
		this.bool_14 = bool_31;
		this.bool_6 = bool_32;
		this.bool_20 = bool_33;
		this.bool_2 = bool_34;
		this.bool_0 = bool_35;
		this.bool_7 = bool_36;
		this.bool_12 = bool_37;
		this.bool_17 = bool_38;
		this.bool_18 = bool_39;
		this.bool_10 = bool_40;
		this.bool_3 = bool_41;
		this.bool_8 = bool_42;
		this.bool_11 = bool_43;
		if (gclass320_1 == null)
		{
			this.gclass320_0 = new GClass320(0U);
		}
		else
		{
			this.gclass320_0 = gclass320_1;
		}
		if (gclass320_2 == null)
		{
			this.BfubnqPhdA = new GClass320(0U);
			return;
		}
		this.BfubnqPhdA = gclass320_2;
	}

	public virtual int vmethod_0()
	{
		return 890;
	}

	public virtual int vmethod_1()
	{
		return 23;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass320_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass320);
		this.gclass320_0.imethod_1(binaryStream_0);
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.bool_3 = binaryStream_0.ReadBoolean();
		this.bool_4 = binaryStream_0.ReadBoolean();
		this.bool_5 = binaryStream_0.ReadBoolean();
		this.bool_6 = binaryStream_0.ReadBoolean();
		this.bool_7 = binaryStream_0.ReadBoolean();
		this.bool_8 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.bool_9 = binaryStream_0.ReadBoolean();
		this.bool_10 = binaryStream_0.ReadBoolean();
		this.bool_11 = binaryStream_0.ReadBoolean();
		this.bool_12 = binaryStream_0.ReadBoolean();
		this.bool_13 = binaryStream_0.ReadBoolean();
		this.bool_14 = binaryStream_0.ReadBoolean();
		this.bool_15 = binaryStream_0.ReadBoolean();
		this.bool_16 = binaryStream_0.ReadBoolean();
		this.bWiDaAoMmf = binaryStream_0.ReadBoolean();
		this.bool_17 = binaryStream_0.ReadBoolean();
		this.bool_18 = binaryStream_0.ReadBoolean();
		this.pAgDzevjh7 = binaryStream_0.ReadBoolean();
		this.BfubnqPhdA = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass320);
		this.BfubnqPhdA.imethod_1(binaryStream_0);
		this.bool_19 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.bool_20 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(890);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass320_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.WriteBoolean(this.bool_3);
		binaryStream_0.WriteBoolean(this.bool_4);
		binaryStream_0.WriteBoolean(this.bool_5);
		binaryStream_0.WriteBoolean(this.bool_6);
		binaryStream_0.WriteBoolean(this.bool_7);
		binaryStream_0.WriteBoolean(this.bool_8);
		binaryStream_0.smethod_6(16055);
		binaryStream_0.WriteBoolean(this.bool_9);
		binaryStream_0.WriteBoolean(this.bool_10);
		binaryStream_0.WriteBoolean(this.bool_11);
		binaryStream_0.WriteBoolean(this.bool_12);
		binaryStream_0.WriteBoolean(this.bool_13);
		binaryStream_0.WriteBoolean(this.bool_14);
		binaryStream_0.WriteBoolean(this.bool_15);
		binaryStream_0.WriteBoolean(this.bool_16);
		binaryStream_0.WriteBoolean(this.bWiDaAoMmf);
		binaryStream_0.WriteBoolean(this.bool_17);
		binaryStream_0.WriteBoolean(this.bool_18);
		binaryStream_0.WriteBoolean(this.pAgDzevjh7);
		this.BfubnqPhdA.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_19);
		binaryStream_0.smethod_6(29255);
		binaryStream_0.WriteBoolean(this.bool_20);
	}

	public bool bool_0;

	public GClass320 gclass320_0;

	public bool bool_1;

	public bool bool_2;

	public bool bool_3;

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

	public bool bWiDaAoMmf;

	public bool bool_17;

	public bool bool_18;

	public bool pAgDzevjh7;

	public GClass320 BfubnqPhdA;

	public bool bool_19;

	public bool bool_20;
}
