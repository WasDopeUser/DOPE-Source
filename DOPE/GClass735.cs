using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass735 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -24244;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass735(bool bool_1 = false, Vector<GClass735> vector_1 = null, string string_0 = "", GClass402 gclass402_1 = null, string string_1 = "")
	{
		Class13.lOBHd9Nzn7x2T();
		this.ToolTip = "";
		this.Name = "";
		base..ctor();
		if (gclass402_1 == null)
		{
			this.gclass402_0 = new GClass402();
		}
		else
		{
			this.gclass402_0 = gclass402_1;
		}
		this.ToolTip = string_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass735>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.Name = string_0;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return -24244;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass402_0 = (GClass402)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass402_0 != null)
		{
			this.gclass402_0.imethod_1(binaryStream_0);
		}
		this.ToolTip = binaryStream_0.smethod_2();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = (int)binaryStream_0.smethod_1();
		while (i < num)
		{
			GClass735 gclass = (GClass735)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.Name = binaryStream_0.smethod_2();
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-24244);
		if (this.gclass402_0 != null)
		{
			this.gclass402_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_3(this.ToolTip);
		binaryStream_0.smethod_7(this.vector_0.Length);
		foreach (GClass735 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public GClass402 gclass402_0;

	public string ToolTip;

	public Vector<GClass735> vector_0;

	public string Name;

	public bool bool_0;
}
