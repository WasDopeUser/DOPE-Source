using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass697 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 123;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass697(int int_2 = 0, GClass353 gclass353_0 = null, int int_3 = 0, bool bool_1 = false)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_2;
		if (gclass353_0 == null)
		{
			this.MxoNoxgeFu = new GClass353(0);
		}
		else
		{
			this.MxoNoxgeFu = gclass353_0;
		}
		this.int_1 = int_3;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 123;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.MxoNoxgeFu = (GClass353)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.MxoNoxgeFu != null)
		{
			this.MxoNoxgeFu.imethod_1(binaryStream_0);
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 6) | this.int_1 << 26);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(123);
		binaryStream_0.smethod_7(this.int_0);
		if (this.MxoNoxgeFu != null)
		{
			this.MxoNoxgeFu.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(this.int_1 << 6 | U.smethod_0(this.int_1, 26));
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int int_0;

	public GClass353 MxoNoxgeFu;

	public int int_1;

	public bool bool_0;
}
