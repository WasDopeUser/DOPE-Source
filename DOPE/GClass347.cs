using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass347 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11008;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass347(bool bool_0 = false)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.avDxeyyly2 = bool_0;
	}

	public virtual int vmethod_0()
	{
		return 11008;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.avDxeyyly2 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(11008);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(-13255);
		binaryStream_0.WriteBoolean(this.avDxeyyly2);
	}

	public bool avDxeyyly2;
}
