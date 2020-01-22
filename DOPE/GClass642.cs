using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass642 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 725;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass642(int int_0 = 0, string string_1 = "")
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		base..ctor();
		this.MapId = int_0;
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 725;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 13 | U.smethod_0(this.MapId, 19));
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(725);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 13) | this.MapId << 19);
		binaryStream_0.smethod_7(-24186);
		binaryStream_0.smethod_3(this.string_0);
	}

	public int MapId;

	public string string_0;
}
