using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass690 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28952;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass690(string string_0 = "")
	{
		Class13.xnk8ImWzpOt04();
		this.IeLynTmDcT = "";
		base..ctor();
		this.IeLynTmDcT = string_0;
	}

	public virtual int vmethod_0()
	{
		return 28952;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.IeLynTmDcT = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28952);
		binaryStream_0.smethod_3(this.IeLynTmDcT);
	}

	public string IeLynTmDcT;
}
