using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass351 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4790;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass351(int int_1 = 0, int int_2 = 0)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.int_0 = int_1;
		this.SqdhtordvF = int_2;
	}

	public virtual int vmethod_0()
	{
		return 4790;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.SqdhtordvF = binaryStream_0.smethod_0();
		this.SqdhtordvF = (this.SqdhtordvF << 14 | U.smethod_0(this.SqdhtordvF, 18));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4790);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.SqdhtordvF, 14) | this.SqdhtordvF << 18);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
	}

	public int SqdhtordvF;

	public int int_0;
}
