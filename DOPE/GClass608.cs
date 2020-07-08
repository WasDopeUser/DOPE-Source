using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass608 : GInterface0
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

	public GClass608(int int_2 = 0, GClass635 gclass635_1 = null, int int_3 = 0, bool bool_1 = false)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_2;
		if (gclass635_1 == null)
		{
			this.gclass635_0 = new GClass635(0);
		}
		else
		{
			this.gclass635_0 = gclass635_1;
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
		this.gclass635_0 = (GClass635)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass635_0 != null)
		{
			this.gclass635_0.imethod_1(binaryStream_0);
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(125);
		binaryStream_0.smethod_7(this.int_0);
		if (this.gclass635_0 != null)
		{
			this.gclass635_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int int_0;

	public GClass635 gclass635_0;

	public int int_1;

	public bool bool_0;
}
