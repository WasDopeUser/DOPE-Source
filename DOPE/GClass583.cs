using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass583 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 253;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass583(GClass258 gclass258_1 = null, GClass671 gclass671_1 = null, bool bool_1 = false, int int_1 = 0, GClass513 gclass513_4 = null, GClass513 gclass513_5 = null, GClass513 gclass513_6 = null, GClass513 gclass513_7 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass258_1 == null)
		{
			this.gclass258_0 = new GClass258(0);
		}
		else
		{
			this.gclass258_0 = gclass258_1;
		}
		if (gclass671_1 == null)
		{
			this.gclass671_0 = new GClass671(0, 0);
		}
		else
		{
			this.gclass671_0 = gclass671_1;
		}
		this.bool_0 = bool_1;
		this.int_0 = int_1;
		if (gclass513_4 == null)
		{
			this.gclass513_0 = new GClass513("", null, null);
		}
		else
		{
			this.gclass513_0 = gclass513_4;
		}
		if (gclass513_5 == null)
		{
			this.gclass513_1 = new GClass513("", null, null);
		}
		else
		{
			this.gclass513_1 = gclass513_5;
		}
		if (gclass513_6 == null)
		{
			this.gclass513_2 = new GClass513("", null, null);
		}
		else
		{
			this.gclass513_2 = gclass513_6;
		}
		if (gclass513_7 == null)
		{
			this.gclass513_3 = new GClass513("", null, null);
			return;
		}
		this.gclass513_3 = gclass513_7;
	}

	public virtual int vmethod_0()
	{
		return 253;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass258_0 = (GClass258)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass258_0 != null)
		{
			this.gclass258_0.imethod_0(binaryStream_0);
		}
		this.gclass671_0 = (GClass671)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass671_0 != null)
		{
			this.gclass671_0.imethod_0(binaryStream_0);
		}
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		this.gclass513_0 = (GClass513)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass513_0 != null)
		{
			this.gclass513_0.imethod_0(binaryStream_0);
		}
		this.gclass513_1 = (GClass513)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass513_1 != null)
		{
			this.gclass513_1.imethod_0(binaryStream_0);
		}
		this.gclass513_2 = (GClass513)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass513_2 != null)
		{
			this.gclass513_2.imethod_0(binaryStream_0);
		}
		this.gclass513_3 = (GClass513)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass513_3 != null)
		{
			this.gclass513_3.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(253);
		if (this.gclass258_0 != null)
		{
			this.gclass258_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass671_0 != null)
		{
			this.gclass671_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		if (this.gclass513_0 != null)
		{
			this.gclass513_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass513_1 != null)
		{
			this.gclass513_1.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass513_2 != null)
		{
			this.gclass513_2.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass513_3 != null)
		{
			this.gclass513_3.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass258 gclass258_0;

	public GClass671 gclass671_0;

	public bool bool_0;

	public int int_0;

	public GClass513 gclass513_0;

	public GClass513 gclass513_1;

	public GClass513 gclass513_2;

	public GClass513 gclass513_3;
}
