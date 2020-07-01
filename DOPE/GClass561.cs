using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass561 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19746;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 7;
		}
	}

	public GClass561(int int_1 = 0, string string_0 = "", bool bool_1 = false)
	{
		Class13.F93tSdiz1aNIA();
		this.Name = "";
		base..ctor();
		this.int_0 = int_1;
		this.bool_0 = bool_1;
		this.Name = string_0;
	}

	public virtual int vmethod_0()
	{
		return 19746;
	}

	public virtual int vmethod_1()
	{
		return 7;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.Name = binaryStream_0.smethod_2();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19746);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.Name);
	}

	public int int_0;

	public bool bool_0;

	public string Name;
}
