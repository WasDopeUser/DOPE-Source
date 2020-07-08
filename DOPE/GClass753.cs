using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass753 : GInterface0
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

	public GClass753(GClass531 gclass531_1 = null, GClass636 gclass636_1 = null, GClass396 gclass396_1 = null, GClass760 gclass760_1 = null, GClass281 gclass281_1 = null, GClass420 gclass420_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass396_1 == null)
		{
			this.gclass396_0 = new GClass396(false, 0, 0, 0, false);
		}
		else
		{
			this.gclass396_0 = gclass396_1;
		}
		if (gclass760_1 == null)
		{
			this.gclass760_0 = new GClass760(0, "", false);
		}
		else
		{
			this.gclass760_0 = gclass760_1;
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

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass396_0 = (GClass396)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass396_0 != null)
		{
			this.gclass396_0.imethod_1(binaryStream_0);
		}
		this.gclass760_0 = (GClass760)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass760_0 != null)
		{
			this.gclass760_0.imethod_1(binaryStream_0);
		}
		this.gclass281_0 = (GClass281)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass281_0 != null)
		{
			this.gclass281_0.imethod_1(binaryStream_0);
		}
		this.gclass420_0 = (GClass420)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass420_0 != null)
		{
			this.gclass420_0.imethod_1(binaryStream_0);
		}
		this.gclass531_0 = (GClass531)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass531_0 != null)
		{
			this.gclass531_0.imethod_1(binaryStream_0);
		}
		this.gclass636_0 = (GClass636)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass636_0 != null)
		{
			this.gclass636_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-10768);
		if (this.gclass396_0 != null)
		{
			this.gclass396_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass760_0 != null)
		{
			this.gclass760_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass281_0 != null)
		{
			this.gclass281_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass420_0 != null)
		{
			this.gclass420_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass531_0 != null)
		{
			this.gclass531_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass636_0 != null)
		{
			this.gclass636_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass396 gclass396_0;

	public GClass760 gclass760_0;

	public GClass281 gclass281_0;

	public GClass420 gclass420_0;

	public GClass531 gclass531_0;

	public GClass636 gclass636_0;
}
