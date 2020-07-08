using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass423 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2271;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass423(int int_0 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.Id = int_0;
	}

	public virtual int vmethod_0()
	{
		return 2271;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 11) | this.Id << 21);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2271);
		binaryStream_0.smethod_4(this.Id << 11 | U.smethod_0(this.Id, 21));
	}

	public int Id;
}
