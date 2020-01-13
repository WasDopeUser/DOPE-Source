using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass254 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29985;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass254(int int_1 = 0, ByteArray byteArray_1 = null)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.byteArray_0 = new ByteArray();
		this.int_0 = int_1;
		if (byteArray_1 != null)
		{
			this.byteArray_0 = byteArray_1;
		}
	}

	public virtual int vmethod_0()
	{
		return 29985;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.byteArray_0.Clear();
		binaryStream_0.smethod_11(this.byteArray_0, 0, binaryStream_0.smethod_0());
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29985);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.smethod_4(this.byteArray_0.Length);
		binaryStream_0.smethod_12(this.byteArray_0, 0, this.byteArray_0.Length);
	}

	public int int_0;

	public ByteArray byteArray_0;
}
