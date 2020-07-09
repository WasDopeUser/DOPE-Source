using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass416 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25975;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass416(GClass287 gclass287_0 = null, bool bool_2 = false, int int_0 = 0, bool bool_3 = false, GClass489 gclass489_1 = null, string string_1 = "")
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (gclass489_1 == null)
		{
			this.gclass489_0 = new GClass489(false, 0);
		}
		else
		{
			this.gclass489_0 = gclass489_1;
		}
		if (gclass287_0 == null)
		{
			this.Window = new GClass287(0);
		}
		else
		{
			this.Window = gclass287_0;
		}
		this.bool_0 = bool_2;
		this.Visibility = int_0;
		this.bool_1 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 25975;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass489_0 = (GClass489)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass489_0 != null)
		{
			this.gclass489_0.imethod_1(binaryStream_0);
		}
		this.Window = (GClass287)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.Window != null)
		{
			this.Window.imethod_1(binaryStream_0);
		}
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.Visibility = (int)binaryStream_0.smethod_1();
		this.bool_1 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25975);
		binaryStream_0.smethod_3(this.string_0);
		if (this.gclass489_0 != null)
		{
			this.gclass489_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.Window != null)
		{
			this.Window.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(this.Visibility);
		binaryStream_0.WriteBoolean(this.bool_1);
	}

	public string string_0;

	public GClass489 gclass489_0;

	public GClass287 Window;

	public bool bool_0;

	public int Visibility;

	public bool bool_1;
}
