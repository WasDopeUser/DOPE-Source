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

	public GClass754(GClass532 gclass532_1 = null, GClass637 gclass637_1 = null, GClass397 gclass397_0 = null, GClass761 gclass761_1 = null, GClass282 gclass282_1 = null, GClass421 gclass421_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass397_0 == null)
		{
			this.nxeXirFdVK = new GClass397(false, 0, 0, 0, false);
		}
		else
		{
			this.nxeXirFdVK = gclass397_0;
		}
		if (gclass761_1 == null)
		{
			this.gclass761_0 = new GClass761(0, "", false);
		}
		else
		{
			this.gclass761_0 = gclass761_1;
		}
		if (gclass282_1 == null)
		{
			this.gclass282_0 = new GClass282(false, false, false, false, false, false, false, false, false, false);
		}
		else
		{
			this.gclass282_0 = gclass282_1;
		}
		if (gclass421_1 == null)
		{
			this.gclass421_0 = new GClass421(false, false, false, false, false, false);
		}
		else
		{
			this.gclass421_0 = gclass421_1;
		}
		if (gclass532_1 == null)
		{
			this.gclass532_0 = new GClass532(false, 0, 0, 0, false, 0, 0, 0, 0, 0, 0);
		}
		else
		{
			this.gclass532_0 = gclass532_1;
		}
		if (gclass637_1 == null)
		{
			this.gclass637_0 = new GClass637(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 0, 0, 0, 0, 0, 0, 0, 0, false, false, false, false, false);
			return;
		}
		this.gclass637_0 = gclass637_1;
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
		this.nxeXirFdVK = (GClass397)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.nxeXirFdVK != null)
		{
			this.nxeXirFdVK.imethod_1(binaryStream_0);
		}
		this.gclass761_0 = (GClass761)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass761_0 != null)
		{
			this.gclass761_0.imethod_1(binaryStream_0);
		}
		this.gclass282_0 = (GClass282)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass282_0 != null)
		{
			this.gclass282_0.imethod_1(binaryStream_0);
		}
		this.gclass421_0 = (GClass421)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass421_0 != null)
		{
			this.gclass421_0.imethod_1(binaryStream_0);
		}
		this.gclass532_0 = (GClass532)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass532_0 != null)
		{
			this.gclass532_0.imethod_1(binaryStream_0);
		}
		this.gclass637_0 = (GClass637)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass637_0 != null)
		{
			this.gclass637_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-10768);
		if (this.nxeXirFdVK != null)
		{
			this.nxeXirFdVK.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass761_0 != null)
		{
			this.gclass761_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass282_0 != null)
		{
			this.gclass282_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass421_0 != null)
		{
			this.gclass421_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass532_0 != null)
		{
			this.gclass532_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass637_0 != null)
		{
			this.gclass637_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass397 nxeXirFdVK;

	public GClass761 gclass761_0;

	public GClass282 gclass282_0;

	public GClass421 gclass421_0;

	public GClass532 gclass532_0;

	public GClass637 gclass637_0;
}
