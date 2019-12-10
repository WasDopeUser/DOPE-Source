using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass178 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16000;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass178(int int_0 = 0, uint uint_0 = 0U, bool bool_1 = false, GClass343 gclass343_0 = null, GClass761 gclass761_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Id = int_0;
		this.State = uint_0;
		this.bool_0 = bool_1;
		if (gclass343_0 == null)
		{
			this.ToolTip = new GClass343(null);
		}
		else
		{
			this.ToolTip = gclass343_0;
		}
		if (gclass761_1 == null)
		{
			this.gclass761_0 = new GClass761();
			return;
		}
		this.gclass761_0 = gclass761_1;
	}

	public virtual int vmethod_0()
	{
		return 16000;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.State = (uint)binaryStream_0.smethod_1();
		this.gclass761_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass761);
		this.gclass761_0.imethod_1(binaryStream_0);
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 7) | this.Id << 25);
		this.ToolTip = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass343);
		this.ToolTip.imethod_1(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(16000);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.lwAiiEjwcUm(this.State);
		this.gclass761_0.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(this.Id << 7 | U.smethod_0(this.Id, 25));
		this.ToolTip.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public uint State;

	public GClass761 gclass761_0;

	public int Id;

	public GClass343 ToolTip;

	public bool bool_0;
}
