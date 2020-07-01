using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass472 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 63;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass472(int int_1 = 0, int int_2 = 0, bool bool_1 = false)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.MapId = int_1;
		this.int_0 = int_2;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 63;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 13 | U.smethod_0(this.MapId, 19));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(63);
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 13) | this.MapId << 19);
		binaryStream_0.smethod_4(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int MapId;

	public int int_0;

	public bool bool_0;
}
