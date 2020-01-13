using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass564 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3080;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass564(double double_1 = 0.0, string string_0 = "")
	{
		Class13.tMHx78BzgCM8j();
		this.ivRsywZcBC = "";
		base..ctor();
		this.double_0 = double_1;
		this.ivRsywZcBC = string_0;
	}

	public virtual int vmethod_0()
	{
		return 3080;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
		this.ivRsywZcBC = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3080);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-114);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_7(-17275);
		binaryStream_0.smethod_3(this.ivRsywZcBC);
	}

	public double double_0;

	public string ivRsywZcBC;
}
