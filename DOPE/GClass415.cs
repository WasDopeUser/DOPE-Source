using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass415 : GInterface0
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

	public GClass415(GClass286 gclass286_0 = null, bool bool_2 = false, int int_0 = 0, bool bool_3 = false, GClass488 gclass488_1 = null, string string_1 = "")
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (gclass488_1 == null)
		{
			this.gclass488_0 = new GClass488(false, 0);
		}
		else
		{
			this.gclass488_0 = gclass488_1;
		}
		if (gclass286_0 == null)
		{
			this.Window = new GClass286(0);
		}
		else
		{
			this.Window = gclass286_0;
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

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass488_0 = (GClass488)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass488_0 != null)
		{
			this.gclass488_0.imethod_0(binaryStream_0);
		}
		this.Window = (GClass286)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.Window != null)
		{
			this.Window.imethod_0(binaryStream_0);
		}
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.Visibility = (int)binaryStream_0.smethod_1();
		this.bool_1 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25975);
		binaryStream_0.smethod_3(this.string_0);
		if (this.gclass488_0 != null)
		{
			this.gclass488_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.Window != null)
		{
			this.Window.imethod_1(binaryStream_0);
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

	public GClass488 gclass488_0;

	public GClass286 Window;

	public bool bool_0;

	public int Visibility;

	public bool bool_1;
}
