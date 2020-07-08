using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass186 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 280;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 15;
		}
	}

	public GClass186(int int_2 = 0, int int_3 = 0, int int_4 = 0, string string_1 = "", int int_5 = 0, bool bool_1 = false)
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		base..ctor();
		this.zgNxkCynsb = int_2;
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.string_0 = string_1;
		this.Count = int_5;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 280;
	}

	public virtual int vmethod_1()
	{
		return 15;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.zgNxkCynsb = binaryStream_0.smethod_0();
		this.zgNxkCynsb = (U.smethod_0(this.zgNxkCynsb, 12) | this.zgNxkCynsb << 20);
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 7 | U.smethod_0(this.int_1, 25));
		this.string_0 = binaryStream_0.smethod_2();
		this.Count = binaryStream_0.smethod_0();
		this.Count = (U.smethod_0(this.Count, 14) | this.Count << 18);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(280);
		binaryStream_0.smethod_4(this.zgNxkCynsb << 12 | U.smethod_0(this.zgNxkCynsb, 20));
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 7) | this.int_1 << 25);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.Count << 14 | U.smethod_0(this.Count, 18));
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int zgNxkCynsb;

	public int int_0;

	public int int_1;

	public string string_0;

	public int Count;

	public bool bool_0;
}
