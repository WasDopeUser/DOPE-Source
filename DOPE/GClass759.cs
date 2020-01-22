using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass759 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19397;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass759(uint uint_0 = 0U)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.vpQvImRlEd = uint_0;
	}

	public virtual int vmethod_0()
	{
		return 19397;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.vpQvImRlEd = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19397);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.vpQvImRlEd);
		binaryStream_0.smethod_7(-19302);
	}

	public uint vpQvImRlEd;
}
