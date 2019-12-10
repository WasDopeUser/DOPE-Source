using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass214 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30859;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass214(int int_1 = 0, int int_2 = 0, bool bool_1 = false)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.opInfZiQoO = int_1;
		this.int_0 = int_2;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 30859;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		binaryStream_0.smethod_1();
		this.opInfZiQoO = binaryStream_0.smethod_0();
		this.opInfZiQoO = (U.smethod_0(this.opInfZiQoO, 4) | this.opInfZiQoO << 28);
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(30859);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.smethod_5(-4679);
		binaryStream_0.fUeiimuocMk(this.opInfZiQoO << 4 | U.smethod_0(this.opInfZiQoO, 28));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_5(28410);
	}

	public int int_0;

	public int opInfZiQoO;

	public bool bool_0;
}
