using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass718 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22736;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass718(uint uint_1 = 0U, uint uint_2 = 0U, GClass362 gclass362_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.fnwcferoeS = uint_1;
		this.uint_0 = uint_2;
		if (gclass362_1 == null)
		{
			this.gclass362_0 = new GClass362();
			return;
		}
		this.gclass362_0 = gclass362_1;
	}

	public virtual int vmethod_0()
	{
		return 22736;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.fnwcferoeS = (uint)binaryStream_0.smethod_1();
		this.gclass362_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass362);
		this.gclass362_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22736);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.fnwcferoeS);
		this.gclass362_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(-25798);
		binaryStream_0.smethod_6(this.uint_0);
	}

	public uint fnwcferoeS;

	public GClass362 gclass362_0;

	public uint uint_0;
}
