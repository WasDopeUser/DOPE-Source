using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass609 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 125;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass609(int int_2 = 0, GClass636 gclass636_0 = null, int int_3 = 0, bool bool_1 = false)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_2;
		if (gclass636_0 == null)
		{
			this.zgNvuIlpLv = new GClass636(0);
		}
		else
		{
			this.zgNvuIlpLv = gclass636_0;
		}
		this.int_1 = int_3;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 125;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.zgNvuIlpLv = (GClass636)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.zgNvuIlpLv != null)
		{
			this.zgNvuIlpLv.imethod_1(binaryStream_0);
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(125);
		binaryStream_0.smethod_7(this.int_0);
		if (this.zgNvuIlpLv != null)
		{
			this.zgNvuIlpLv.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int int_0;

	public GClass636 zgNvuIlpLv;

	public int int_1;

	public bool bool_0;
}
