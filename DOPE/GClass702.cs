using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass702 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25970;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 7;
		}
	}

	public GClass702(int int_1 = 0, string string_1 = "", bool bool_0 = false)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_1;
		this.string_0 = string_1;
		this.RwJyIcGlcd = bool_0;
	}

	public virtual int vmethod_0()
	{
		return 25970;
	}

	public virtual int vmethod_1()
	{
		return 7;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.RwJyIcGlcd = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 6) | this.int_0 << 26);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25970);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteBoolean(this.RwJyIcGlcd);
		binaryStream_0.smethod_4(this.int_0 << 6 | U.smethod_0(this.int_0, 26));
	}

	public string string_0;

	public bool RwJyIcGlcd;

	public int int_0;
}
