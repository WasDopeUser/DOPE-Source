using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass685 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24888;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass685(GClass673 gclass673_1 = null, string string_1 = "", GClass614 gclass614_1 = null, GClass489 gclass489_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		base..ctor();
		if (gclass489_1 == null)
		{
			this.gclass489_0 = new GClass489(false, 0);
		}
		else
		{
			this.gclass489_0 = gclass489_1;
		}
		if (gclass673_1 == null)
		{
			this.gclass673_0 = new GClass673(0);
		}
		else
		{
			this.gclass673_0 = gclass673_1;
		}
		this.string_0 = string_1;
		if (gclass614_1 == null)
		{
			this.gclass614_0 = new GClass614(0);
			return;
		}
		this.gclass614_0 = gclass614_1;
	}

	public virtual int vmethod_0()
	{
		return 24888;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass489_0 = (GClass489)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass489_0 != null)
		{
			this.gclass489_0.imethod_1(binaryStream_0);
		}
		this.gclass673_0 = (GClass673)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass673_0 != null)
		{
			this.gclass673_0.imethod_1(binaryStream_0);
		}
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass614_0 = (GClass614)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass614_0 != null)
		{
			this.gclass614_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(24888);
		if (this.gclass489_0 != null)
		{
			this.gclass489_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass673_0 != null)
		{
			this.gclass673_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_3(this.string_0);
		if (this.gclass614_0 != null)
		{
			this.gclass614_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass489 gclass489_0;

	public GClass673 gclass673_0;

	public string string_0;

	public GClass614 gclass614_0;
}
