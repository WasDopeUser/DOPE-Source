using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass650 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25037;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass650(double double_1 = 0.0, bool bool_2 = false, bool bool_3 = false)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.double_0 = double_1;
		this.bool_1 = bool_2;
		this.bool_0 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 25037;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
		this.bool_1 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25037);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(19551);
		binaryStream_0.smethod_7(-3426);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteBoolean(this.bool_1);
	}

	public bool bool_0;

	public double double_0;

	public bool bool_1;
}
