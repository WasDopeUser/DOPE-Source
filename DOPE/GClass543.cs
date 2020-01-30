using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass543 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31368;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass543(bool bool_4 = false, bool bool_5 = false, bool bool_6 = false, bool bool_7 = false)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.bool_3 = bool_4;
		this.bool_0 = bool_5;
		this.bool_2 = bool_6;
		this.bool_1 = bool_7;
	}

	public virtual int vmethod_0()
	{
		return 31368;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.bool_3 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31368);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
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
