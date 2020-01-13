using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass319 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18039;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass319(int int_1 = 0, bool bool_0 = false)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.int_0 = int_1;
		this.Visible = bool_0;
	}

	public virtual int vmethod_0()
	{
		return 18039;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		this.Visible = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18039);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		binaryStream_0.WriteBoolean(this.Visible);
	}

	public int int_0;

	public bool Visible;
}
