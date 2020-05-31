using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass304 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30340;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass304(string string_1 = "", GClass187 gclass187_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (gclass187_1 == null)
		{
			this.gclass187_0 = new GClass187(0, 0U, 0, "", 0, false);
			return;
		}
		this.gclass187_0 = gclass187_1;
	}

	public virtual int vmethod_0()
	{
		return 30340;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass187_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass187);
		this.gclass187_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30340);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-18973);
		binaryStream_0.smethod_3(this.string_0);
		this.gclass187_0.imethod_1(binaryStream_0);
	}

	public string string_0;

	public GClass187 gclass187_0;
}
