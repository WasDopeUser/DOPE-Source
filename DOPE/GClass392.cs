using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass392 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20591;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass392(bool bool_2 = false, int int_3 = 0, int int_4 = 0, int int_5 = 0, bool bool_3 = false)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.bool_1 = bool_2;
		this.int_1 = int_3;
		this.int_0 = int_4;
		this.int_2 = int_5;
		this.bool_0 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 20591;
	}

	public virtual int vmethod_1()
	{
		return 14;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 4 | U.smethod_0(this.int_1, 28));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 13 | U.smethod_0(this.int_2, 19));
		this.bool_1 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20591);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 4) | this.int_1 << 28);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 13) | this.int_2 << 19);
		binaryStream_0.WriteBoolean(this.bool_1);
	}

	public int int_0;

	public int int_1;

	public bool bool_0;

	public int int_2;

	public bool bool_1;
}
