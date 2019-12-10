using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass744 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30143;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass744(uint uint_1 = 0U, GClass760 gclass760_2 = null, GClass760 gclass760_3 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.uint_0 = uint_1;
		if (gclass760_2 == null)
		{
			this.gclass760_0 = new GClass760(0, 0, false);
		}
		else
		{
			this.gclass760_0 = gclass760_2;
		}
		if (gclass760_3 == null)
		{
			this.gclass760_1 = new GClass760(0, 0, false);
			return;
		}
		this.gclass760_1 = gclass760_3;
	}

	public virtual int vmethod_0()
	{
		return 30143;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass760_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass760);
		this.gclass760_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass760_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass760);
		this.gclass760_1.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(30143);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass760_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(17283);
		this.gclass760_1.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-6006);
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
	}

	public GClass760 gclass760_0;

	public GClass760 gclass760_1;

	public uint uint_0;
}
