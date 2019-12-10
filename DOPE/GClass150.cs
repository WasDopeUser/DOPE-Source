using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass150 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27455;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass150(int int_1 = 0, int int_2 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_0 = int_1;
		this.Ntylhkodnu = int_2;
	}

	public virtual int vmethod_0()
	{
		return 27455;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.Ntylhkodnu = binaryStream_0.smethod_0();
		this.Ntylhkodnu = (this.Ntylhkodnu << 13 | U.smethod_0(this.Ntylhkodnu, 19));
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 10 | U.smethod_0(this.int_0, 22));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(27455);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(6477);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.Ntylhkodnu, 13) | this.Ntylhkodnu << 19);
		binaryStream_0.smethod_5(16226);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 10) | this.int_0 << 22);
	}

	public int Ntylhkodnu;

	public int int_0;
}
