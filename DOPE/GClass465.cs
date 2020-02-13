using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass465 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9813;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass465(int int_1 = 0, int int_2 = 0, bool bool_1 = false)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.MapId = int_1;
		this.int_0 = int_2;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 9813;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 6) | this.MapId << 26);
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(9813);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.MapId << 6 | U.smethod_0(this.MapId, 26));
		binaryStream_0.smethod_6(-5741);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int MapId;

	public int int_0;

	public bool bool_0;
}
