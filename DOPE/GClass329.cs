using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass329 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 179;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass329(int int_1 = 0, bool bool_0 = false)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_1;
		this.Visible = bool_0;
	}

	public virtual int vmethod_0()
	{
		return 179;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		this.Visible = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(179);
		binaryStream_0.smethod_4(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		binaryStream_0.WriteBoolean(this.Visible);
	}

	public int int_0;

	public bool Visible;
}
