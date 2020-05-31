using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass712 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17939;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass712(GClass528 gclass528_1 = null, GClass616 gclass616_1 = null, GClass399 gclass399_1 = null, GClass717 gclass717_1 = null, GClass286 gclass286_0 = null, GClass424 gclass424_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass528_1 == null)
		{
			this.gclass528_0 = new GClass528(false, 0, 0, 0, false, 0, 0, 0, 0, 0, 0);
		}
		else
		{
			this.gclass528_0 = gclass528_1;
		}
		if (gclass616_1 == null)
		{
			this.gclass616_0 = new GClass616(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 0, 0, 0, 0, 0, 0, 0, 0, false, false, false, false, false);
		}
		else
		{
			this.gclass616_0 = gclass616_1;
		}
		if (gclass399_1 == null)
		{
			this.gclass399_0 = new GClass399(false, 0, 0, 0, false);
		}
		else
		{
			this.gclass399_0 = gclass399_1;
		}
		if (gclass717_1 == null)
		{
			this.gclass717_0 = new GClass717(0, "", false);
		}
		else
		{
			this.gclass717_0 = gclass717_1;
		}
		if (gclass286_0 == null)
		{
			this.gFbcJneXuk = new GClass286(false, false, false, false, false, false, false, false, false, false);
		}
		else
		{
			this.gFbcJneXuk = gclass286_0;
		}
		if (gclass424_1 == null)
		{
			this.gclass424_0 = new GClass424(false, false, false, false, false, false);
			return;
		}
		this.gclass424_0 = gclass424_1;
	}

	public virtual int vmethod_0()
	{
		return 17939;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass616_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass616);
		this.gclass616_0.HrqIugnatr8(binaryStream_0);
		this.gclass399_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass399);
		this.gclass399_0.HrqIugnatr8(binaryStream_0);
		this.gFbcJneXuk = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass286);
		this.gFbcJneXuk.HrqIugnatr8(binaryStream_0);
		this.gclass424_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass424);
		this.gclass424_0.HrqIugnatr8(binaryStream_0);
		this.gclass717_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass717);
		this.gclass717_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass528_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass528);
		this.gclass528_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(17939);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass616_0.imethod_1(binaryStream_0);
		this.gclass399_0.imethod_1(binaryStream_0);
		this.gFbcJneXuk.imethod_1(binaryStream_0);
		this.gclass424_0.imethod_1(binaryStream_0);
		this.gclass717_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(20174);
		this.gclass528_0.imethod_1(binaryStream_0);
	}

	public GClass616 gclass616_0;

	public GClass399 gclass399_0;

	public GClass286 gFbcJneXuk;

	public GClass424 gclass424_0;

	public GClass717 gclass717_0;

	public GClass528 gclass528_0;
}
