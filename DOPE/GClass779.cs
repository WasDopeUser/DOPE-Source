using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass779 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 222;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass779(int int_0 = 0, int int_1 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.jwngorFwJv = int_0;
		this.MapId = int_1;
	}

	public virtual int vmethod_0()
	{
		return 222;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.jwngorFwJv = binaryStream_0.smethod_0();
		this.jwngorFwJv = (this.jwngorFwJv << 12 | U.smethod_0(this.jwngorFwJv, 20));
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 14 | U.smethod_0(this.MapId, 18));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(222);
		binaryStream_0.smethod_4(U.smethod_0(this.jwngorFwJv, 12) | this.jwngorFwJv << 20);
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 14) | this.MapId << 18);
	}

	public int jwngorFwJv;

	public int MapId;
}
