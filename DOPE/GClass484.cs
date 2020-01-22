using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass484 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26057;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass484(bool bool_9 = false, bool bool_10 = false, bool bool_11 = false, bool bool_12 = false, bool bool_13 = false, bool bool_14 = false, bool bool_15 = false, bool bool_16 = false, bool bool_17 = false)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.bool_6 = bool_9;
		this.bool_3 = bool_10;
		this.bool_1 = bool_11;
		this.bool_8 = bool_12;
		this.bool_4 = bool_13;
		this.bool_5 = bool_14;
		this.bool_2 = bool_15;
		this.bool_0 = bool_16;
		this.bool_7 = bool_17;
	}

	public virtual int vmethod_0()
	{
		return 26057;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.bool_3 = binaryStream_0.ReadBoolean();
		this.bool_4 = binaryStream_0.ReadBoolean();
		this.bool_5 = binaryStream_0.ReadBoolean();
		this.bool_6 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.bool_7 = binaryStream_0.ReadBoolean();
		this.bool_8 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(26057);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.WriteBoolean(this.bool_3);
		binaryStream_0.WriteBoolean(this.bool_4);
		binaryStream_0.WriteBoolean(this.bool_5);
		binaryStream_0.WriteBoolean(this.bool_6);
		binaryStream_0.smethod_7(32741);
		binaryStream_0.smethod_7(25493);
		binaryStream_0.WriteBoolean(this.bool_7);
		binaryStream_0.WriteBoolean(this.bool_8);
	}

	public bool bool_0;

	public bool bool_1;

	public bool bool_2;

	public bool bool_3;

	public bool bool_4;

	public bool bool_5;

	public bool bool_6;

	public bool bool_7;

	public bool bool_8;
}
