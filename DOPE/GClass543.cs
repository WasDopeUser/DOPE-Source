using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass543 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19203;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 7;
		}
	}

	public GClass543(int int_1 = 0, string string_0 = "", bool bool_1 = false)
	{
		Class13.igxcIukzfpare();
		this.Name = "";
		base..ctor();
		this.int_0 = int_1;
		this.Name = string_0;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 19203;
	}

	public virtual int vmethod_1()
	{
		return 7;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Name = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(19203);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.MoioCjQkqp0(this.Name);
		binaryStream_0.smethod_6(21690);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public string Name;

	public int int_0;

	public bool bool_0;
}
