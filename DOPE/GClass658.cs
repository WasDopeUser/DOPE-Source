using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass658 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1321;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass658(int int_0 = 0, string string_1 = "")
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		this.MapId = int_0;
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 1321;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 6 | U.smethod_0(this.MapId, 26));
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1321);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 6) | this.MapId << 26);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(-3669);
	}

	public int MapId;

	public string string_0;
}
