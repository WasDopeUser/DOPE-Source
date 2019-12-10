using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass529 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12793;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 7;
		}
	}

	public GClass529(int int_1 = 0, string string_0 = "", bool bool_1 = false)
	{
		Class8.xDph7tozmh5WD();
		this.Name = "";
		base..ctor();
		this.int_0 = int_1;
		this.Name = string_0;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 12793;
	}

	public virtual int vmethod_1()
	{
		return 7;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.Name = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(12793);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.smethod_5(26725);
		binaryStream_0.smethod_5(-30474);
		binaryStream_0.smethod_3(this.Name);
	}

	public bool bool_0;

	public int int_0;

	public string Name;
}
