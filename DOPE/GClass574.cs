using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass574 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1283;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass574(bool bool_1 = false, GClass367 gclass367_2 = null, GClass367 gclass367_3 = null, GClass526 gclass526_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass367_3 == null)
		{
			this.gclass367_0 = new GClass367("", 0, 0, 0, 0, 0, 0, 0.0);
		}
		else
		{
			this.gclass367_0 = gclass367_3;
		}
		this.bool_0 = bool_1;
		if (gclass526_1 == null)
		{
			this.gclass526_0 = new GClass526("");
		}
		else
		{
			this.gclass526_0 = gclass526_1;
		}
		if (gclass367_2 == null)
		{
			this.gclass367_1 = new GClass367("", 0, 0, 0, 0, 0, 0, 0.0);
			return;
		}
		this.gclass367_1 = gclass367_2;
	}

	public virtual int vmethod_0()
	{
		return 1283;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass367_0 = (GClass367)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass367_0 != null)
		{
			this.gclass367_0.imethod_1(binaryStream_0);
		}
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass526_0 = (GClass526)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass526_0 != null)
		{
			this.gclass526_0.imethod_1(binaryStream_0);
		}
		this.gclass367_1 = (GClass367)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass367_1 != null)
		{
			this.gclass367_1.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1283);
		if (this.gclass367_0 != null)
		{
			this.gclass367_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteBoolean(this.bool_0);
		if (this.gclass526_0 != null)
		{
			this.gclass526_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass367_1 != null)
		{
			this.gclass367_1.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass367 gclass367_0;

	public bool bool_0;

	public GClass526 gclass526_0;

	public GClass367 gclass367_1;
}
