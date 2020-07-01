using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass420 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14426;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass420(bool bool_6 = false, bool bool_7 = false, bool bool_8 = false, bool bool_9 = false, bool bool_10 = false, bool bool_11 = false)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.bool_0 = bool_7;
		this.bool_1 = bool_10;
		this.bool_2 = bool_11;
		this.bool_3 = bool_9;
		this.bool_4 = bool_6;
		this.bool_5 = bool_8;
	}

	public virtual int vmethod_0()
	{
		return 14426;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.bool_3 = binaryStream_0.ReadBoolean();
		this.bool_4 = binaryStream_0.ReadBoolean();
		this.bool_5 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14426);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.WriteBoolean(this.bool_3);
		binaryStream_0.WriteBoolean(this.bool_4);
		binaryStream_0.WriteBoolean(this.bool_5);
	}

	public bool bool_0;

	public bool bool_1;

	public bool bool_2;

	public bool bool_3;

	public bool bool_4;

	public bool bool_5;
}
