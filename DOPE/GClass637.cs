using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass637 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11934;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass637(GClass630 gclass630_1 = null, string string_1 = "", GClass580 gclass580_1 = null, GClass481 gclass481_1 = null)
	{
		Class13.tMHx78BzgCM8j();
		this.string_0 = "";
		base..ctor();
		if (gclass630_1 == null)
		{
			this.gclass630_0 = new GClass630(0U);
		}
		else
		{
			this.gclass630_0 = gclass630_1;
		}
		this.string_0 = string_1;
		if (gclass580_1 == null)
		{
			this.gclass580_0 = new GClass580(0U);
		}
		else
		{
			this.gclass580_0 = gclass580_1;
		}
		if (gclass481_1 == null)
		{
			this.gclass481_0 = new GClass481(false, 0);
			return;
		}
		this.gclass481_0 = gclass481_1;
	}

	public virtual int vmethod_0()
	{
		return 11934;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass630_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass630);
		this.gclass630_0.imethod_1(binaryStream_0);
		this.gclass481_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass481);
		this.gclass481_0.imethod_1(binaryStream_0);
		this.gclass580_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass580);
		this.gclass580_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11934);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9069);
		this.gclass630_0.imethod_2(binaryStream_0);
		this.gclass481_0.imethod_2(binaryStream_0);
		this.gclass580_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(30240);
		binaryStream_0.smethod_3(this.string_0);
	}

	public GClass630 gclass630_0;

	public GClass481 gclass481_0;

	public GClass580 gclass580_0;

	public string string_0;
}
