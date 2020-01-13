using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass315 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23531;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 3;
		}
	}

	public GClass315(bool bool_3 = false, bool bool_4 = false, bool bool_5 = false)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.bool_0 = bool_3;
		this.bool_2 = bool_4;
		this.bool_1 = bool_5;
	}

	public virtual int vmethod_0()
	{
		return 23531;
	}

	public virtual int vmethod_1()
	{
		return 3;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.bool_2 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23531);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-25831);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.WriteBoolean(this.bool_2);
	}

	public bool bool_0;

	public bool bool_1;

	public bool bool_2;
}
