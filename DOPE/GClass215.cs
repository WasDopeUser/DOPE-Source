using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass215 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27880;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass215(ByteArray byteArray_0 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.NboSgGytuJ = new ByteArray();
		if (byteArray_0 != null)
		{
			this.NboSgGytuJ = byteArray_0;
		}
	}

	public virtual int vmethod_0()
	{
		return 27880;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.NboSgGytuJ.Clear();
		binaryStream_0.smethod_11(this.NboSgGytuJ, 0, binaryStream_0.smethod_0());
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27880);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.NboSgGytuJ.Length);
		binaryStream_0.smethod_12(this.NboSgGytuJ, 0, this.NboSgGytuJ.Length);
	}

	public ByteArray NboSgGytuJ;
}
