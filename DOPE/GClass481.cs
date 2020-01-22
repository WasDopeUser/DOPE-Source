using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass481 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29758;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass481(bool bool_1 = false, int int_0 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.bool_0 = bool_1;
		this.dKeTydBbsV = int_0;
	}

	public virtual int vmethod_0()
	{
		return 29758;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.dKeTydBbsV = binaryStream_0.smethod_0();
		this.dKeTydBbsV = (this.dKeTydBbsV << 14 | U.smethod_0(this.dKeTydBbsV, 18));
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29758);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.dKeTydBbsV, 14) | this.dKeTydBbsV << 18);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int dKeTydBbsV;

	public bool bool_0;
}
