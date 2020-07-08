using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass334 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15181;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass334(bool bool_1 = false, bool bool_2 = false)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.oyIhYijfu2 = bool_1;
		this.bool_0 = bool_2;
	}

	public virtual int vmethod_0()
	{
		return 15181;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.oyIhYijfu2 = binaryStream_0.ReadBoolean();
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(15181);
		binaryStream_0.WriteBoolean(this.oyIhYijfu2);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public bool oyIhYijfu2;

	public bool bool_0;
}
