using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass330 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12220;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass330(uint uint_0 = 0U, int int_1 = 0, bool bool_1 = false)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.State = uint_0;
		this.int_0 = int_1;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 12220;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		this.State = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(12220);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		binaryStream_0.smethod_5(this.State);
		binaryStream_0.smethod_6(22008);
		binaryStream_0.smethod_6(-687);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int int_0;

	public uint State;

	public bool bool_0;
}
