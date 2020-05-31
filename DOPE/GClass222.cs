using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass222 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25305;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass222(bool bool_0 = false)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.DwtpGiCyHZ = bool_0;
	}

	public virtual int vmethod_0()
	{
		return 25305;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.DwtpGiCyHZ = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25305);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18609);
		binaryStream_0.smethod_7(-4800);
		binaryStream_0.WriteBoolean(this.DwtpGiCyHZ);
	}

	public bool DwtpGiCyHZ;
}
