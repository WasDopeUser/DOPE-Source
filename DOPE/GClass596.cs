using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass596 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29524;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 17;
		}
	}

	public GClass596(int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0, bool bool_1 = false)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.Id = int_3;
		this.int_1 = int_4;
		this.int_2 = int_5;
		this.int_0 = int_6;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 29524;
	}

	public virtual int vmethod_1()
	{
		return 17;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 2 | U.smethod_0(this.Id, 30));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(29524);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.Id, 2) | this.Id << 30);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		binaryStream_0.smethod_3(this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		binaryStream_0.smethod_6(22205);
	}

	public int Id;

	public int int_0;

	public int int_1;

	public bool bool_0;

	public int int_2;
}
