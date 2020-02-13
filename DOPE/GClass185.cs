using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass185 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25297;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass185(int int_0 = 0, uint uint_0 = 0U, bool bool_1 = false, GClass361 gclass361_0 = null, GClass773 gclass773_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.Id = int_0;
		this.State = uint_0;
		this.bool_0 = bool_1;
		if (gclass361_0 == null)
		{
			this.ToolTip = new GClass361(null);
		}
		else
		{
			this.ToolTip = gclass361_0;
		}
		if (gclass773_1 == null)
		{
			this.gclass773_0 = new GClass773();
			return;
		}
		this.gclass773_0 = gclass773_1;
	}

	public virtual int vmethod_0()
	{
		return 25297;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.ToolTip = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass361);
		this.ToolTip.imethod_1(binaryStream_0);
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 16) | this.Id << 16);
		binaryStream_0.smethod_1();
		this.gclass773_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass773);
		this.gclass773_0.imethod_1(binaryStream_0);
		this.State = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(25297);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		this.ToolTip.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.Id << 16 | U.smethod_0(this.Id, 16));
		binaryStream_0.smethod_6(-16933);
		this.gclass773_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(this.State);
	}

	public bool bool_0;

	public GClass361 ToolTip;

	public int Id;

	public GClass773 gclass773_0;

	public uint State;
}
