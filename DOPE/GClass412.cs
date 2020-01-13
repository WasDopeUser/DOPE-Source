using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass412 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5746;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass412(GClass284 gclass284_0 = null, bool bool_2 = false, uint uint_0 = 0U, bool bool_3 = false, GClass481 gclass481_1 = null, string string_1 = "")
	{
		Class13.tMHx78BzgCM8j();
		this.string_0 = "";
		base..ctor();
		if (gclass284_0 == null)
		{
			this.Window = new GClass284(0U);
		}
		else
		{
			this.Window = gclass284_0;
		}
		this.bool_1 = bool_2;
		this.Visibility = uint_0;
		this.bool_0 = bool_3;
		if (gclass481_1 == null)
		{
			this.gclass481_0 = new GClass481(false, 0);
		}
		else
		{
			this.gclass481_0 = gclass481_1;
		}
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 5746;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.Window = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass284);
		this.Window.imethod_1(binaryStream_0);
		this.gclass481_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass481);
		this.gclass481_0.imethod_1(binaryStream_0);
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
		this.Visibility = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5746);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(2031);
		this.Window.imethod_2(binaryStream_0);
		this.gclass481_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_6(this.Visibility);
	}

	public bool bool_0;

	public GClass284 Window;

	public GClass481 gclass481_0;

	public bool bool_1;

	public string string_0;

	public uint Visibility;
}
