using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass706 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 61;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass706(int int_1 = 0, int int_2 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_1;
		this.MapId = int_2;
	}

	public virtual int vmethod_0()
	{
		return 61;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 6 | U.smethod_0(this.MapId, 26));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(61);
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 6) | this.MapId << 26);
	}

	public int int_0;

	public int MapId;
}
