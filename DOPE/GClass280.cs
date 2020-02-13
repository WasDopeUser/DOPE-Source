using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass280 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 667;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass280(int int_3 = 0, int int_4 = 129, int int_5 = 5, bool bool_1 = false)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.int_2 = int_5;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 667;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_2 = binaryStream_0.smethod_0();
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(667);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0);
		binaryStream_0.smethod_3(this.int_1);
		binaryStream_0.smethod_3(this.int_2);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public bool bool_0;
}
