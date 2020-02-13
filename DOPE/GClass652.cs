using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass652 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9914;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass652(double double_1 = 0.0, bool bool_2 = false, bool bool_3 = false)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.double_0 = double_1;
		this.bool_0 = bool_2;
		this.bool_1 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 9914;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(9914);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-1731);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
	}

	public double double_0;

	public bool bool_0;

	public bool bool_1;
}
