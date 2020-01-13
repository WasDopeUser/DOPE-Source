using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass151 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28613;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass151(string string_0 = "")
	{
		Class13.tMHx78BzgCM8j();
		this.Name = "";
		base..ctor();
		this.Name = string_0;
	}

	public virtual int vmethod_0()
	{
		return 28613;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.Name = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28613);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-7819);
		binaryStream_0.smethod_7(-14682);
		binaryStream_0.smethod_3(this.Name);
	}

	public string Name;
}
