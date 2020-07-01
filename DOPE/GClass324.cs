using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass324 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 229;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 3;
		}
	}

	public GClass324(bool bool_3 = false, bool bool_4 = false, bool bool_5 = false)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.bool_0 = bool_3;
		this.bool_1 = bool_4;
		this.bool_2 = bool_5;
	}

	public virtual int vmethod_0()
	{
		return 229;
	}

	public virtual int vmethod_1()
	{
		return 3;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.bool_2 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(229);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.WriteBoolean(this.bool_2);
	}

	public bool bool_0;

	public bool bool_1;

	public bool bool_2;
}
