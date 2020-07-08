using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass168 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32572;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass168(string string_2 = "", string string_3 = "")
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.string_0 = string_3;
		this.string_1 = string_2;
	}

	public virtual int vmethod_0()
	{
		return 32572;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32572);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
	}

	public string string_0;

	public string string_1;
}
