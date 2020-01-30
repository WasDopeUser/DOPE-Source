using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass643 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5739;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass643(int int_0 = 0, string string_1 = "")
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		base..ctor();
		this.MapId = int_0;
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 5739;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 3 | U.smethod_0(this.MapId, 29));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5739);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 3) | this.MapId << 29);
	}

	public string string_0;

	public int MapId;
}
