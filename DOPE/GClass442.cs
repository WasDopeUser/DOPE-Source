using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass442 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15336;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass442(int int_1 = 0, bool bool_0 = false)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_0 = int_1;
		this.ynOcVhaNk0 = bool_0;
	}

	public virtual int vmethod_0()
	{
		return 15336;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.ynOcVhaNk0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 5 | U.smethod_0(this.int_0, 27));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(15336);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.ynOcVhaNk0);
		binaryStream_0.smethod_6(2933);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 5) | this.int_0 << 27);
	}

	public bool ynOcVhaNk0;

	public int int_0;
}
