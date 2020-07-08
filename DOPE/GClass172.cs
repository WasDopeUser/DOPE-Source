using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass172 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16576;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass172(string string_1 = "", int int_1 = 0, int int_2 = 0)
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		base..ctor();
		this.ioRoSscCeP = int_2;
		this.string_0 = string_1;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 16576;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.ioRoSscCeP = (int)binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16576);
		binaryStream_0.smethod_7(this.ioRoSscCeP);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(this.int_0);
	}

	public int ioRoSscCeP;

	public string string_0;

	public int int_0;
}
