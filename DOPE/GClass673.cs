using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass673 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11717;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 19;
		}
	}

	public GClass673(string string_1 = "", int int_2 = 0, int int_3 = 0, int int_4 = 0, int int_5 = 0, bool bool_1 = false)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.Width = int_4;
		this.hyvrxCtlpI = int_5;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 11717;
	}

	public virtual int vmethod_1()
	{
		return 19;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		binaryStream_0.smethod_1();
		this.Width = binaryStream_0.smethod_0();
		this.Width = (U.smethod_0(this.Width, 16) | this.Width << 16);
		this.string_0 = binaryStream_0.smethod_2();
		this.hyvrxCtlpI = binaryStream_0.smethod_0();
		this.hyvrxCtlpI = (U.smethod_0(this.hyvrxCtlpI, 9) | this.hyvrxCtlpI << 23);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 8) | this.int_1 << 24);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(11717);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.smethod_6(-6041);
		binaryStream_0.smethod_3(this.Width << 16 | U.smethod_0(this.Width, 16));
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_3(this.hyvrxCtlpI << 9 | U.smethod_0(this.hyvrxCtlpI, 23));
		binaryStream_0.smethod_3(this.int_1 << 8 | U.smethod_0(this.int_1, 24));
	}

	public bool bool_0;

	public int int_0;

	public int Width;

	public string string_0;

	public int hyvrxCtlpI;

	public int int_1;
}
