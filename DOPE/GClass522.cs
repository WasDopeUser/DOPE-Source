using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass522 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18464;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass522(int int_1 = 0, double double_0 = 0.0, int int_2 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_2;
		this.MsNsacHelu = double_0;
		this.Mode = int_1;
	}

	public virtual int vmethod_0()
	{
		return 18464;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		this.MsNsacHelu = binaryStream_0.ReadDouble();
		this.Mode = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18464);
		binaryStream_0.smethod_4(this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		binaryStream_0.WriteDouble(this.MsNsacHelu);
		binaryStream_0.smethod_7(this.Mode);
	}

	public int int_0;

	public double MsNsacHelu;

	public int Mode;
}
