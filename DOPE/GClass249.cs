using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass249 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13476;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass249(int int_3 = 0, GClass275 gclass275_0 = null, GClass276 gclass276_1 = null, GClass177 gclass177_1 = null, int int_4 = 0, int int_5 = 0, bool bool_1 = false)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_3;
		this.bool_0 = bool_1;
		if (gclass276_1 == null)
		{
			this.gclass276_0 = new GClass276("", null, 0.0, 0.0, false);
		}
		else
		{
			this.gclass276_0 = gclass276_1;
		}
		this.int_1 = int_5;
		if (gclass275_0 == null)
		{
			this.Status = new GClass275(false, false, "", null, null, false, 0.0, 0.0, 0, "", false, false, false);
		}
		else
		{
			this.Status = gclass275_0;
		}
		this.int_2 = int_4;
		if (gclass177_1 == null)
		{
			this.gclass177_0 = new GClass177(0);
			return;
		}
		this.gclass177_0 = gclass177_1;
	}

	public virtual int vmethod_0()
	{
		return 13476;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass276_0 = (GClass276)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass276_0 != null)
		{
			this.gclass276_0.imethod_1(binaryStream_0);
		}
		this.int_1 = (int)binaryStream_0.smethod_1();
		this.Status = (GClass275)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.Status != null)
		{
			this.Status.imethod_1(binaryStream_0);
		}
		this.int_2 = (int)binaryStream_0.smethod_1();
		this.gclass177_0 = (GClass177)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass177_0 != null)
		{
			this.gclass177_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13476);
		binaryStream_0.smethod_4(this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		binaryStream_0.WriteBoolean(this.bool_0);
		if (this.gclass276_0 != null)
		{
			this.gclass276_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_7(this.int_1);
		if (this.Status != null)
		{
			this.Status.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_7(this.int_2);
		if (this.gclass177_0 != null)
		{
			this.gclass177_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public int int_0;

	public bool bool_0;

	public GClass276 gclass276_0;

	public int int_1;

	public GClass275 Status;

	public int int_2;

	public GClass177 gclass177_0;
}
