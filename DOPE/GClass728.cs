using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass728 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19233;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass728(int int_1 = 0, int int_2 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.jwbfBjWpyn = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 19233;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.smethod_1();
		this.jwbfBjWpyn = binaryStream_0.smethod_0();
		this.jwbfBjWpyn = (U.smethod_0(this.jwbfBjWpyn, 16) | this.jwbfBjWpyn << 16);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(19233);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		binaryStream_0.smethod_5(-8191);
		binaryStream_0.fUeiimuocMk(this.jwbfBjWpyn << 16 | U.smethod_0(this.jwbfBjWpyn, 16));
	}

	public int int_0;

	public int jwbfBjWpyn;
}
