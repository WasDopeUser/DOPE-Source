using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass562 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -19924;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass562(bool bool_4 = false, bool bool_5 = false, bool bool_6 = false, bool bool_7 = false)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.bool_0 = bool_5;
		this.bool_1 = bool_6;
		this.bool_2 = bool_7;
		this.bool_3 = bool_4;
	}

	public virtual int vmethod_0()
	{
		return -19924;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.bool_3 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-19924);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.WriteBoolean(this.bool_3);
	}

	public bool bool_0;

	public bool bool_1;

	public bool bool_2;

	public bool bool_3;
}
