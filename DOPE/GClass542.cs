using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass542 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27134;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 7;
		}
	}

	public GClass542(int int_1 = 0, string string_0 = "", bool bool_1 = false)
	{
		Class13.Gj4N3WdzaR1LY();
		this.Name = "";
		base..ctor();
		this.int_0 = int_1;
		this.Name = string_0;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 27134;
	}

	public virtual int vmethod_1()
	{
		return 7;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Name = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27134);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_4(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(-17841);
	}

	public string Name;

	public int int_0;

	public bool bool_0;
}
