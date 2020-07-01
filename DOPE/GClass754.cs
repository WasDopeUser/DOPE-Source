using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass754 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -10768;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass754(GClass531 gclass531_1 = null, GClass636 gclass636_1 = null, GClass396 gclass396_1 = null, GClass761 gclass761_1 = null, GClass281 gclass281_1 = null, GClass420 gclass420_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass396_1 == null)
		{
			this.gclass396_0 = new GClass396(false, 0, 0, 0, false);
		}
		else
		{
			this.gclass396_0 = gclass396_1;
		}
		if (gclass761_1 == null)
		{
			this.gclass761_0 = new GClass761(0, "", false);
		}
		else
		{
			this.gclass761_0 = gclass761_1;
		}
		if (gclass281_1 == null)
		{
			this.gclass281_0 = new GClass281(false, false, false, false, false, false, false, false, false, false);
		}
		else
		{
			this.gclass281_0 = gclass281_1;
		}
		if (gclass420_1 == null)
		{
			this.gclass420_0 = new GClass420(false, false, false, false, false, false);
		}
		else
		{
			this.gclass420_0 = gclass420_1;
		}
		if (gclass531_1 == null)
		{
			this.gclass531_0 = new GClass531(false, 0, 0, 0, false, 0, 0, 0, 0, 0, 0);
		}
		else
		{
			this.gclass531_0 = gclass531_1;
		}
		if (gclass636_1 == null)
		{
			this.gclass636_0 = new GClass636(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 0, 0, 0, 0, 0, 0, 0, 0, false, false, false, false, false);
			return;
		}
		this.gclass636_0 = gclass636_1;
	}

	public virtual int vmethod_0()
	{
		return -10768;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass396_0 = (GClass396)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass396_0 != null)
		{
			this.gclass396_0.imethod_0(binaryStream_0);
		}
		this.gclass761_0 = (GClass761)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass761_0 != null)
		{
			this.gclass761_0.imethod_0(binaryStream_0);
		}
		this.gclass281_0 = (GClass281)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass281_0 != null)
		{
			this.gclass281_0.imethod_0(binaryStream_0);
		}
		this.gclass420_0 = (GClass420)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass420_0 != null)
		{
			this.gclass420_0.imethod_0(binaryStream_0);
		}
		this.gclass531_0 = (GClass531)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass531_0 != null)
		{
			this.gclass531_0.imethod_0(binaryStream_0);
		}
		this.gclass636_0 = (GClass636)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass636_0 != null)
		{
			this.gclass636_0.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-10768);
		if (this.gclass396_0 != null)
		{
			this.gclass396_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass761_0 != null)
		{
			this.gclass761_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass281_0 != null)
		{
			this.gclass281_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass420_0 != null)
		{
			this.gclass420_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass531_0 != null)
		{
			this.gclass531_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass636_0 != null)
		{
			this.gclass636_0.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass396 gclass396_0;

	public GClass761 gclass761_0;

	public GClass281 gclass281_0;

	public GClass420 gclass420_0;

	public GClass531 gclass531_0;

	public GClass636 gclass636_0;
}
