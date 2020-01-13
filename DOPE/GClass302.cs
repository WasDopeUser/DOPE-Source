using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass302 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6204;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass302(int int_2 = 0, int int_3 = 0, int int_4 = 0)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.xvewxhZfkG = int_2;
		this.int_0 = int_3;
		this.int_1 = int_4;
	}

	public virtual int vmethod_0()
	{
		return 6204;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.xvewxhZfkG = binaryStream_0.smethod_0();
		this.xvewxhZfkG = (U.smethod_0(this.xvewxhZfkG, 15) | this.xvewxhZfkG << 17);
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 4) | this.int_1 << 28);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6204);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.smethod_4(this.xvewxhZfkG << 15 | U.smethod_0(this.xvewxhZfkG, 17));
		binaryStream_0.smethod_7(-31960);
		binaryStream_0.smethod_4(this.int_1 << 4 | U.smethod_0(this.int_1, 28));
	}

	public int int_0;

	public int xvewxhZfkG;

	public int int_1;
}
