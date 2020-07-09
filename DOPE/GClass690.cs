using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass690 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 188;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass690(int int_0 = 0, string string_1 = "")
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		base..ctor();
		this.MapId = int_0;
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 188;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 8) | this.MapId << 24);
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(188);
		binaryStream_0.smethod_4(this.MapId << 8 | U.smethod_0(this.MapId, 24));
		binaryStream_0.smethod_3(this.string_0);
	}

	public int MapId;

	public string string_0;
}
