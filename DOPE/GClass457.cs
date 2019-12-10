using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass457 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14386;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass457(GClass618 gclass618_1 = null, string string_1 = "", GClass568 gclass568_1 = null)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		if (gclass618_1 == null)
		{
			this.gclass618_0 = new GClass618(0U);
		}
		else
		{
			this.gclass618_0 = gclass618_1;
		}
		this.string_0 = string_1;
		if (gclass568_1 == null)
		{
			this.gclass568_0 = new GClass568(0U);
			return;
		}
		this.gclass568_0 = gclass568_1;
	}

	public virtual int vmethod_0()
	{
		return 14386;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass568_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass568);
		this.gclass568_0.imethod_1(binaryStream_0);
		this.gclass618_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass618);
		this.gclass618_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(14386);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass568_0.imethod_2(binaryStream_0);
		this.gclass618_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-19693);
		binaryStream_0.smethod_5(-31272);
		binaryStream_0.smethod_3(this.string_0);
	}

	public GClass568 gclass568_0;

	public GClass618 gclass618_0;

	public string string_0;
}
