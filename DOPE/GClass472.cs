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

	public GClass472(int int_0 = 0, int int_1 = 0, bool bool_1 = false)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.MapId = int_0;
		this.aHcjhHyag1 = int_1;
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

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 13 | U.smethod_0(this.MapId, 19));
		this.aHcjhHyag1 = binaryStream_0.smethod_0();
		this.aHcjhHyag1 = (U.smethod_0(this.aHcjhHyag1, 9) | this.aHcjhHyag1 << 23);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(63);
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 13) | this.MapId << 19);
		binaryStream_0.smethod_4(this.aHcjhHyag1 << 9 | U.smethod_0(this.aHcjhHyag1, 23));
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int MapId;

	public int aHcjhHyag1;

	public bool bool_0;
}
