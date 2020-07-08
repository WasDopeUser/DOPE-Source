using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass171 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass171(string string_1 = "", int int_0 = 0)
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.encoQoFjf1 = int_0;
	}

	public virtual int vmethod_0()
	{
		return 14;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.encoQoFjf1 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(this.encoQoFjf1);
	}

	public string string_0;

	public int encoQoFjf1;
}
