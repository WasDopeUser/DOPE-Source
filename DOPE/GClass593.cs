using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass593 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14883;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass593(string string_3 = "", string string_4 = "", string string_5 = "")
	{
		Class13.tMHx78BzgCM8j();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		base..ctor();
		this.string_1 = string_3;
		this.string_0 = string_4;
		this.string_2 = string_5;
	}

	public virtual int vmethod_0()
	{
		return 14883;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.string_2 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14883);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_3(this.string_2);
	}

	public string string_0;

	public string string_1;

	public string string_2;
}
