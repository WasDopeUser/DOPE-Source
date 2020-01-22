using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass248 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23260;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass248(string string_0 = "")
	{
		Class13.plZSWFPzBWWEZ();
		this.Name = "";
		base..ctor();
		this.Name = string_0;
	}

	public virtual int vmethod_0()
	{
		return 23260;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.Name = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23260);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-30975);
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_7(9452);
	}

	public string Name;
}
