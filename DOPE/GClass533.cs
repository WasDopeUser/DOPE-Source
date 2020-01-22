using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass533 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8528;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass533(uint uint_1 = 0U, bool bool_1 = false)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.uint_0 = uint_1;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 8528;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8528);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(-20817);
		binaryStream_0.smethod_6(this.uint_0);
	}

	public bool bool_0;

	public uint uint_0;
}
